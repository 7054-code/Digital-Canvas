using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Digital_Canvas
{
    public partial class MainForm : Form
    {
        //enum constant set of tools to select between
        public enum Tool
        {
            PEN, PENCIL, PAINTBRUSH, ERASER
        }

        //bitmap will be used as a canvas whereas canvaspanel is used to get userinput
        Bitmap bmpCanvas;

        //stacks that stores list of changes for undo/redo
        private Stack<Bitmap> undoList = new Stack<Bitmap>();
        private Stack<Bitmap> redoList = new Stack<Bitmap>();

        //store current enum tool selected
        Tool currentTool;

        //getting 2 points between cursor locations for brushes
        Point cursorLocationA;
        Point cursorLocationB;

        //check for whether colour has been changed or not
        Boolean pencilColourChanged = true;
        Boolean paintbrushColourChanged = true;

        //brush imported images
        Bitmap pencilImage = new Bitmap(@"C:\Users\Phoenix\source\repos\Digital Canvas\Digital Canvas\Resources\Pencil.png");
        Bitmap paintbrushImage = new Bitmap(@"C:\Users\Phoenix\source\repos\Digital Canvas\Digital Canvas\Resources\Paintbrush.png");

        //used to check if file exists already for 'Save'
        string saveFileName;

        //simple list of transformations used to reset bmpcanvas back to start
        List<string> transformations = new List<string>();
        public MainForm()
        {
            InitializeComponent();
            ColourButton.BackColor = Color.Black;

            //setting bitmap to CanvasPanel size
            bmpCanvas = new Bitmap(CanvasPanel.Width, CanvasPanel.Height);
            //when the .Paint event happens -> do the _Paint method (happens on .Invalidate() and startup)
            CanvasPanel.Paint += CanvasPanel_Paint;
            //prevents flickering when drawing on screen
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, CanvasPanel,
                new object[] { true });
        }

        private void CanvasPanel_Paint(object sender, PaintEventArgs e)
        {
            //draw updated bitmap on canvaspanel
            e.Graphics.DrawImage(bmpCanvas, Point.Empty);
        }

        private void ColourButton_Click(object sender, EventArgs e)
        {
            using (var diag = new ColorDialog())
                if (diag.ShowDialog() == DialogResult.OK)
                {
                    ColourButton.BackColor = diag.Color;
                }
            pencilColourChanged = true;
            paintbrushColourChanged = true;
        }

        //movement on canvas panel for brush tool movements
        private void CanvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            var gfx = Graphics.FromImage(bmpCanvas);

            if (e.Button == MouseButtons.Left)
            {
                cursorLocationA = cursorLocationB;
                cursorLocationB = e.Location;

                if (currentTool == Tool.PEN)
                {
                    ToolPenDrawing();
                }
                if (currentTool == Tool.PENCIL)
                {
                    ToolPencilDrawing();
                }
                if (currentTool == Tool.PAINTBRUSH)
                {
                    ToolPaintbrushDrawing();
                }
                if (currentTool == Tool.ERASER)
                {
                    ToolErasing();
                }
            }
        }

        //identifying when the mouse is down on the canvas panel
        private void CanvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            //save current bitmap before changing it
            undoList.Push(new Bitmap(bmpCanvas));

            cursorLocationA = e.Location;
            cursorLocationB = e.Location;

            if (currentTool == Tool.PEN)
            {
                ToolPenDrawing();
            }
            else if (currentTool == Tool.PENCIL)
            {
                ToolPencilDrawing();
            }
            else if (currentTool == Tool.PAINTBRUSH)
            {
                ToolPaintbrushDrawing();
            }
            else if (currentTool == Tool.ERASER)
            {
                ToolErasing();
            }
        }

        //pen button icon click event for pen tool selected
        private void PenButton_Click(object sender, EventArgs e)
        {
            currentTool = Tool.PEN;
        }

        //pencil button icon click event for pencil tool selected
        private void PencilButton_Click(object sender, EventArgs e)
        {
            currentTool = Tool.PENCIL;
        }

        //paintbrush button icon click event for paintbrush tool selected
        private void PaintbrushButton_Click(object sender, EventArgs e)
        {
            currentTool = Tool.PAINTBRUSH;
        }

        //eraser button icon click event for eraser tool selected
        private void EraserButton_Click(object sender, EventArgs e)
        {
            currentTool = Tool.ERASER;
        }

        //equating tool size numeric up down value to tool size slider value to keep them constant with each other
        private void ToolSizeSlider_ValueChanged(object sender, EventArgs e)
        {
            ToolSizeNumericUpDown.Value = ToolSizeSlider.Value;
        }

        private void ToolSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ToolSizeSlider.Value = (int)ToolSizeNumericUpDown.Value;
        }

        //equating opacity numeric up down value to opacity slider value to keep them constant with each other
        private void ToolOpacitySlider_ValueChanged(object sender, EventArgs e)
        {
            ToolOpacityNumericUpDown.Value = ToolOpacitySlider.Value;
        }

        private void ToolOpacityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ToolOpacitySlider.Value = (int)ToolOpacityNumericUpDown.Value;
        }

        //creating a pen with opacity, colour and size and passing it to the DrawLineCanvas method
        private void ToolPenDrawing()
        {
            var pen = new Pen(Color.FromArgb((int)ToolOpacityNumericUpDown.Value, ColourButton.BackColor), (int)ToolSizeNumericUpDown.Value);
            DrawLineCanvas(pen);
        }
        private void ToolErasing()
        {
            var pen = new Pen(Color.FromArgb((int)ToolOpacityNumericUpDown.Value, Color.White), (int)ToolSizeNumericUpDown.Value);
            DrawLineCanvas(pen);
        }

        private void ToolPencilDrawing()
        {
            int height = pencilImage.Height;
            int width = pencilImage.Width;

            float diameter = (float)ToolSizeNumericUpDown.Value;
            float radius = diameter / 2;

            var gfx = Graphics.FromImage(bmpCanvas);

            //changing pixel colours for pencil
            if (pencilColourChanged == true)
            {
                //nested for loop to go through every pixel height x width
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        if (pencilImage.GetPixel(y, x).A == 0)
                        {
                            //do nothing and keep transparent pixels
                        }
                        else
                        {
                            //change pencil colour to user choice by changing the pixel colour
                            pencilImage.SetPixel(y, x, Color.FromArgb((int)ToolOpacityNumericUpDown.Value, ColourButton.BackColor));
                        }
                    }
                }
                pencilColourChanged = false;
            }
            
            //gfx.DrawImage(newPencilImage, cursorLocationA.X - radius, cursorLocationA.Y - radius, diameter, diameter);
            gfx.DrawImage(pencilImage, cursorLocationA.X - radius, cursorLocationA.Y - radius, diameter, diameter);
            //update panel to show changes - results in .Paint event so _Paint method is called
            CanvasPanel.Invalidate();
            //frees up system resources since it isn't needed anymore
            gfx.Dispose();
        }

        private void ToolPaintbrushDrawing()
        {
            int height = paintbrushImage.Height;
            int width = paintbrushImage.Width;

            float diameter = (float)ToolSizeNumericUpDown.Value;
            float radius = diameter / 2;

            var gfx = Graphics.FromImage(bmpCanvas);

            //changing pixel colours for paintbrush
            if (paintbrushColourChanged == true)
            {
                //nested for loop to go through every pixel height x width
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        if (paintbrushImage.GetPixel(y, x).A == 0)
                        {
                            //do nothing and keep transparent pixels
                        }
                        else
                        {
                            //change paintbrush colour to user choice by changing the pixel colour
                            paintbrushImage.SetPixel(y, x, Color.FromArgb((int)ToolOpacityNumericUpDown.Value, ColourButton.BackColor));
                        }
                    }
                }
                paintbrushColourChanged = false;
            }

            gfx.DrawImage(paintbrushImage, cursorLocationA.X - radius, cursorLocationA.Y - radius, diameter, diameter);

            //update panel to show changes - results in .Paint event so _Paint method is called
            CanvasPanel.Invalidate();
            //frees up system resources since it isn't needed anymore
            gfx.Dispose();
        }

        //passes pen properties through and renders line drawn
        private void DrawLineCanvas(Pen pen)
        {
            //instead of drawing onto the canvaspanel directly, draw onto the bitmap
            var gfx = Graphics.FromImage(bmpCanvas);
            gfx.SmoothingMode = SmoothingMode.AntiAlias;
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            gfx.DrawLine(pen, cursorLocationA, cursorLocationB);

            //update panel to show changes - results in .Paint event so _Paint method is called
            CanvasPanel.Invalidate();

            //frees up system resources since it isn't needed anymore
            gfx.Dispose();
        }

        //resize canvas but keep drawing/image scale the same
        private void changeCanvasSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //user inputs width and height for canvas change
            using(Form2 form2 = new Form2(this)) 
            {
                //if user pressed the confirm button
                if(form2.ShowDialog() == DialogResult.OK) 
                {
                    //set panel dimensions to user input
                    CanvasPanel.Width = form2.InputWidth;
                    CanvasPanel.Height = form2.InputHeight;
                    //create blank bitmap with updated dimensions
                    Bitmap tempBitmap = new Bitmap(CanvasPanel.Width, CanvasPanel.Height);
                    using (Graphics g = Graphics.FromImage(tempBitmap))
                    {
                        //draw original bitmap on the new bitmap keeping scale the same
                        g.DrawImage(bmpCanvas, 0, 0, bmpCanvas.Width, bmpCanvas.Height);
                    }
                    //replace original bitmap with updated bitmap and new dimensions
                    bmpCanvas = new Bitmap(tempBitmap, CanvasPanel.Size);
                    //update canvas display
                    CanvasPanel.Invalidate();
                }
            }
        }

        //serializable lets compiler know that this class can be saved to a file
        //this class stores data types or objects to be restored
        [Serializable]
        public class CanvasData
        {
            //variables to be saved
            private Bitmap _bmpCanvas;
            private Tool _currentTool;
            private string _fileName;
            private Color _currentColor;
            private int _canvasWidth, _canvasHeight;

            //constructor
            public CanvasData(Bitmap bmp, Tool tool, string file, Color inputColor, int width, int height)
            {
                _bmpCanvas = bmp;
                _currentTool = tool;
                _fileName = file;
                _currentColor = inputColor;
                _canvasWidth = width;
                _canvasHeight = height;
            }

            //getters
            public Bitmap GetBmpCanvas => _bmpCanvas;
            public Tool GetCurrentTool => _currentTool;
            public string GetFileName => _fileName;
            public Color GetCurrentColor => _currentColor;
            public int GetCanvasWidth => _canvasWidth;
            public int GetCanvasHeight => _canvasHeight;


            //used for debugging, prints to Output window (bottom right)
            public void Print()
            {
                Trace.WriteLine("File path/name: "+_fileName);
                Trace.WriteLine("Current tool: "+_currentTool);
                Trace.WriteLine("Bitmap width: "+_bmpCanvas.Width);
                Trace.WriteLine("Colour: "+_currentColor);
                Trace.WriteLine("Canvas size: "+_canvasWidth+"x"+_canvasHeight);
            }
        }

        //Open data
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileExplorerDialog = new OpenFileDialog
            {
                Filter = "Bin file|*.bin",
                Title = "Open a canvas project"
            };
            //open popup and  check that user picked a location
            if (fileExplorerDialog.ShowDialog() == DialogResult.OK)
            {
                //open file connection
                Stream openFileStream = File.OpenRead(fileExplorerDialog.FileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                //get data from file to object
                CanvasData tempData = (CanvasData) deserializer.Deserialize(openFileStream);
                //end connection to file
                openFileStream.Close();

                //replace current values with the ones from file
                bmpCanvas = new Bitmap(tempData.GetBmpCanvas);
                currentTool = tempData.GetCurrentTool;
                saveFileName = tempData.GetFileName;
                ColourButton.BackColor = tempData.GetCurrentColor;
                CanvasPanel.Width = tempData.GetCanvasWidth;
                CanvasPanel.Height = tempData.GetCanvasHeight;
                //update panel with new bitmap
                CanvasPanel.Invalidate();
            }
        }

        //Save data
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if file exists
            if (File.Exists(saveFileName))
            {
                //store wanted variables/data in this object
                CanvasData tempData = new CanvasData(bmpCanvas, currentTool, saveFileName, ColourButton.BackColor,
                    CanvasPanel.Width, CanvasPanel.Height);

                //create file at location given by user
                Stream saveFileStream = File.Create(saveFileName);
                BinaryFormatter serializer = new BinaryFormatter();
                //add object data to file
                serializer.Serialize(saveFileStream, tempData);
                //end connection to file
                saveFileStream.Close();
            }
            //if file does not exist do Save As...
            else
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        //Save As... data
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //allows user to find a location to save file
            SaveFileDialog fileExplorerDialog = new SaveFileDialog
            {
                //automatically save as this file extension
                Filter = "Bin file|*.bin",
                Title = "Save as..."
            };
            //allows user to find a location to save file
            if (fileExplorerDialog.ShowDialog() == DialogResult.OK)
            {
                //store wanted variables/data in this object
                CanvasData tempData = new CanvasData(bmpCanvas, currentTool, fileExplorerDialog.FileName,
                    ColourButton.BackColor, CanvasPanel.Width, CanvasPanel.Height);

                //create file at location given by user
                Stream saveFileStream = File.Create(fileExplorerDialog.FileName);
                BinaryFormatter serializer = new BinaryFormatter();
                //add object data to file
                serializer.Serialize(saveFileStream, tempData);
                //end connection to file
                saveFileStream.Close();
            }
        }

        //export to BMP
        private void bmpBMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export("bmp");
        }

        //export to jpg
        private void jpgJPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export("jpg");
        }

        //export to png
        private void pngPNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export("png");
        }

        //export to psd
        private void psdPhotoshopDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export("psd");
        }

        private void Export(string fileType)
        {
            //allows user to find a location to save file
            SaveFileDialog fileExplorerDialog = new SaveFileDialog
            {
                //automatically save as this file extension
                Filter = fileType.ToUpper() + " Image|*." + fileType,
                Title = "Export to " + fileType.ToUpper()
            };
            //open popup and  check that user picked a location
            if (fileExplorerDialog.ShowDialog() == DialogResult.OK)
                //save at location
                bmpCanvas.Save(fileExplorerDialog.FileName);
        }

        //check if user wants to save before closing program
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //yes or no input pop-up
            DialogResult dialogResult = MessageBox.Show("Do you want to save before exiting?", "Unsaved progress",
                MessageBoxButtons.YesNo);
            switch (dialogResult)
            {
                //if user pressed 'yes' button
                case DialogResult.Yes:
                    //call 'save' function
                    saveToolStripMenuItem_Click(sender, e);
                    //close program
                    Close();
                    break;
                case DialogResult.No:
                    Close();
                    break;
            }
        }
        //fit canvas panel to bmpcanvas
        private void fitPanelToBmp()
        {
            CanvasPanel.Size = bmpCanvas.Size;
        }
        //rotate bmpcanvas +90°
        private void rotate90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save current bitmap before changing it
            undoList.Push(new Bitmap(bmpCanvas));
            
            bmpCanvas.RotateFlip(RotateFlipType.Rotate90FlipNone);
            transformations.Add("plus90");
            fitPanelToBmp();
            //update canvas
            CanvasPanel.Invalidate();
        }
        //rotate bmpccanvas +180°
        private void rotate180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save current bitmap before changing it
            undoList.Push(new Bitmap(bmpCanvas));

            bmpCanvas.RotateFlip(RotateFlipType.Rotate180FlipNone);
            transformations.Add("plus180");
            fitPanelToBmp();
            CanvasPanel.Invalidate();
        }
        //rotate bmpcanvas -90°
        private void rotate90ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //save current bitmap before changing it
            undoList.Push(new Bitmap(bmpCanvas));

            bmpCanvas.RotateFlip(RotateFlipType.Rotate270FlipNone);
            transformations.Add("minus90");
            fitPanelToBmp();
            CanvasPanel.Invalidate();
        }
        //iterate through transformations list and apply opposite transformation
        private void resetRotationToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            //save current bitmap before changing it
            undoList.Push(new Bitmap(bmpCanvas));

            //for all historical transformations
            for (int i = 0;i<transformations.Count;i++)
            {   //if currently considered transformation is a plus 90 rotate
                if (transformations[i]=="plus90")
                {   //rotate it minus 90        //the other rotations are a continuation along these lines
                    bmpCanvas.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    
                }
                else if (transformations[i] == "minus90")
                {
                    bmpCanvas.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                else if (transformations[i] == "plus180")
                {
                    bmpCanvas.RotateFlip(RotateFlipType.Rotate180FlipNone);
                }
                
                
            }
            //clear the transformations history
            transformations.Clear();
            //use the function which resizes the panel to the dimensions of the bmppanel
            fitPanelToBmp();
            //redraw the panel
            CanvasPanel.Invalidate();
        }

        //undo a change by restoring a previous bitmap
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //error checking
            if (undoList.Count != 0)
            {
                //add current bitmap to redolist
                redoList.Push(new Bitmap(bmpCanvas));
                //sets current bitmap to last change and removes it from undoList
                bmpCanvas = new Bitmap(undoList.Pop());
                //update canvas
                CanvasPanel.Invalidate();   
            }
        }
        
        //same as undo
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (redoList.Count != 0)
            {
                undoList.Push(new Bitmap(bmpCanvas));
                bmpCanvas = new Bitmap(redoList.Pop());
                CanvasPanel.Invalidate();   
            }
        }

        private void CanvasPanel_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void CanvasPanel_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }
    }

}
