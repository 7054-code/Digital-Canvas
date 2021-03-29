using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        //used to check if file exists already for 'Save'
        string saveFileName;

        //simple list of transformations used to reset bmpcanvas back to start
        List<string> transformations = new List<string>();

        //the zoom scaling 
        private float zoomScale = 1f;
    
        //the position of the bmp on the canvas as displayed to the user
        private PointF canvasPosition = PointF.Empty;
        
        

        public MainForm()
        {
            InitializeComponent();

            ColourButton.BackColor = Color.Black;
            EraserButton.BackColor = Color.Transparent;

            //setting bitmap to CanvasPanel size
            bmpCanvas = new Bitmap(CanvasPanel.Width, CanvasPanel.Height);
            //fill bitmap with background colour
            var gfx = Graphics.FromImage(bmpCanvas);
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255,255)))
            {
                gfx.FillRectangle(brush, 0, 0, CanvasPanel.Width, CanvasPanel.Height);
            }
            //when the .Paint event happens -> do the _Paint method (happens on .Invalidate() and startup)
            CanvasPanel.Paint += CanvasPanel_Paint;
            this.MouseWheel += new MouseEventHandler(splitContainer1_MouseWheel);
            //prevents flickering when drawing on screen
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, CanvasPanel,
                new object[] { true });
           
          
        }
        
        private void CanvasPanel_Paint(object sender, PaintEventArgs e)
        {   //this draws the bmpcanvas at its location with the required scaling
            e.Graphics.DrawImage(bmpCanvas, canvasPosition.X,canvasPosition.Y, bmpCanvas.Size.Width * zoomScale, bmpCanvas.Size.Height * zoomScale);
        }

        private void ColourButton_Click(object sender, EventArgs e)
        {
            using (var diag = new ColorDialog())
                if (diag.ShowDialog() == DialogResult.OK)
                {
                    ColourButton.BackColor = diag.Color;
                }
        }

        //movement on canvas panel for brush tool movements
        private void CanvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
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
        private void splitContainer1_MouseWheel(object sender, MouseEventArgs e)
        {
           
            if (e.Delta > 0)
               
                {
               
                    zoomScale = zoomScale * 1.1f;            //magic numbers are bad, but this just changes the zoomScale, which affects how much the image is resized for the zoom

                    
                    CanvasPanel.Invalidate();
                }

            if (e.Delta < 0)
            {
                zoomScale = zoomScale * 0.9f;


                CanvasPanel.Invalidate();
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
            var pen = new Pen(Color.FromArgb((int)ToolOpacityNumericUpDown.Value, ColourButton.BackColor), (int)ToolSizeNumericUpDown.Value);
            DrawLineCanvas(pen);
        }

        private void ToolPaintbrushDrawing()
        {
            var pen = new Pen(Color.FromArgb((int)ToolOpacityNumericUpDown.Value, ColourButton.BackColor), (int)ToolSizeNumericUpDown.Value);
            DrawLineCanvas(pen);
        }

        //passes pen properties through and renders line drawn
        private void DrawLineCanvas(Pen pen)
        {
            

            //instead of drawing onto the canvaspanel directly, draw onto the bitmap
            var gfx = Graphics.FromImage(bmpCanvas);
            gfx.SmoothingMode = SmoothingMode.AntiAlias;
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

            //the zoomScale multiplier changes the cursor location to match the zoom level, otherwise the cursor would paint in the location at the default zoom
            //the canvasPosition addition changes the cursor to match the canvas when it gets moved up, down, left or right
            gfx.DrawLine(pen,
              (cursorLocationA.X - canvasPosition.X) / zoomScale ,
              (cursorLocationA.Y - canvasPosition.Y) / zoomScale ,
              (cursorLocationB.X - canvasPosition.X) / zoomScale ,
              (cursorLocationB.Y - canvasPosition.Y) / zoomScale );

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
                    //CanvasPanel.Width = form2.InputWidth;
                   // CanvasPanel.Height = form2.InputHeight;

                    //create blank bitmap with updated dimensions
                    Bitmap tempBitmap = new Bitmap(form2.InputWidth,form2.InputHeight);
                    using (Graphics g = Graphics.FromImage(tempBitmap))
                    {
                        //draw original bitmap on the new bitmap keeping scale the same
                        g.DrawImage(bmpCanvas, 0, 0, bmpCanvas.Width, bmpCanvas.Height);
                    }
                    //replace original bitmap with updated bitmap and new dimensions
                    bmpCanvas = new Bitmap(tempBitmap, tempBitmap.Size);
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
        
        //rotate bmpcanvas +90°
        private void rotate90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save current bitmap before changing it
            undoList.Push(new Bitmap(bmpCanvas));
            
            bmpCanvas.RotateFlip(RotateFlipType.Rotate90FlipNone);
            transformations.Add("plus90");
            
            
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
            
           
            CanvasPanel.Invalidate();
        }
        //rotate bmpcanvas -90°
        private void rotate90ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //save current bitmap before changing it
            undoList.Push(new Bitmap(bmpCanvas));

            bmpCanvas.RotateFlip(RotateFlipType.Rotate270FlipNone);
            transformations.Add("minus90");
         
           
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
        
        //import image and resize to fill canvas if larger than it
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //allows user to find an image
            OpenFileDialog fileExplorerDialog = new OpenFileDialog
            {
                //automatically save as this file extension
                Filter = "Image Files|*.bmp; *.jpg; *.jpeg; *.png; *.gif",
                Title = "Import image"
            };
            //open popup and  check that user picked a location
            if (fileExplorerDialog.ShowDialog() == DialogResult.OK)
            {
                //store chosen image
                Bitmap importedImage = new Bitmap(fileExplorerDialog.OpenFile());
                
                //if imported image width and height is larger than bmpCanvas
                if ((importedImage.Width > bmpCanvas.Width) && (importedImage.Height > bmpCanvas.Height))
                {
                    bmpCanvas = new Bitmap(importedImage, bmpCanvas.Size);
                }
                //if width is larger than bmpcanvas width
                else if ((importedImage.Width > bmpCanvas.Width) && (importedImage.Height < bmpCanvas.Height))
                {
                    bmpCanvas = new Bitmap(importedImage, new Size(bmpCanvas.Width, importedImage.Height));
                }
                //if height is larger than bmpcanvas height
                else if ((importedImage.Width < bmpCanvas.Width) && (importedImage.Height > bmpCanvas.Height))
                {
                    bmpCanvas = new Bitmap(importedImage, new Size(importedImage.Width, bmpCanvas.Height));
                }
                //if imported image smaller than bmpcanvas
                else
                {
                    bmpCanvas = new Bitmap(importedImage);
                }
                
                //make it match the entire canvas
                bmpCanvas = new Bitmap(bmpCanvas, CanvasPanel.Size);
                //update canvas
                CanvasPanel.Invalidate();
            }
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            zoomScale = zoomScale *1.1f;            //magic numbers are bad, but this just changes the zoomScale, which affects how much the image is resized for the zoom


            CanvasPanel.Invalidate();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoomScale = zoomScale * 0.9f;


            CanvasPanel.Invalidate();
        }

        private void percentViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoomScale = 1f;
            CanvasPanel.Invalidate();
        }

        private void upToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvasPosition.Y = canvasPosition.Y - 20;
            CanvasPanel.Invalidate();
        }

        private void downToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvasPosition.Y = canvasPosition.Y + 20;
            CanvasPanel.Invalidate();
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvasPosition.X = canvasPosition.X - 20;
            CanvasPanel.Invalidate();
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvasPosition.X = canvasPosition.X + 20;
            CanvasPanel.Invalidate();
        }

        private void CanvasPanel_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
