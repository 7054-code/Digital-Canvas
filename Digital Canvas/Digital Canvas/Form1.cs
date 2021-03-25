using System;
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
        
        //store current enum tool selected
        Tool currentTool;

        //getting 2 points between cursor locations for brushes
        Point cursorLocationA;
        Point cursorLocationB;

        //used to check if file exists already for 'Save'
        string saveFileName;

        public MainForm()
        {
            InitializeComponent();
            ColourButton.BackColor = Color.Black;
            EraserButton.BackColor = Color.Transparent;

            //setting bitmap to size of CanvasPanel
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

        //identifying when the mouse is down on the canvas panel
        private void CanvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
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
    }

}
