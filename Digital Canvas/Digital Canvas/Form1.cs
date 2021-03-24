using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Digital_Canvas
{
    public partial class MainForm : Form
    {
        public enum Tool
        {
            Pen, Eraser
        }

        //bitmap will be used as a canvas whereas canvaspanel is used to get userinput
        Bitmap bmpCanvas;
        Tool currentTool;
        Point mouseLocationA;
        Point mouseLocationB;
        //used for 'Save' function
        string saveFileName;

        public MainForm()
        {
            InitializeComponent();
            this.ColourButton.BackColor = System.Drawing.Color.Black;
            EraserButton.BackColor = Color.Transparent;

            //setting bitmap to size of CanvasPanel
            bmpCanvas = new Bitmap(CanvasPanel.Width, CanvasPanel.Height);
            //when the .Paint event happens -> do the _Paint method (happens on .Invalidate())
            CanvasPanel.Paint += CanvasPanel_Paint;
            //prevents flickering when drawing on screen
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, CanvasPanel, new object[] { true });
        }

        private void CanvasPanel_Paint(object sender, PaintEventArgs e)
        {
            //draw updated bitmap on canvas
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

        private void CanvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseLocationA = mouseLocationB;
                mouseLocationB = e.Location;
                if (currentTool == Tool.Pen)
                {
                    ToolPenDrawing();
                }

                if (currentTool == Tool.Eraser)
                {
                    ToolErasing();
                }
            }
        }

        private void CanvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocationA = e.Location;
            mouseLocationB = e.Location;

            if (currentTool == Tool.Pen)
            {
                ToolPenDrawing();
            }
            else if (currentTool == Tool.Eraser)
            {
                ToolErasing();
            }
        }

        private void PenButton_Click(object sender, EventArgs e)
        {
            currentTool = Tool.Pen;
        }

        private void EraserButton_Click(object sender, EventArgs e)
        {
            currentTool = Tool.Eraser;
        }

        private void ToolPenDrawing()
        {
            var pen = new Pen(ColourButton.BackColor, 10);
            //instead of drawing onto the canvaspanel, draw onto the bitmap
            var gfx = Graphics.FromImage(bmpCanvas);
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            gfx.DrawLine(pen, mouseLocationA, mouseLocationB);

            //update panel to show changes
            CanvasPanel.Invalidate();

            //frees up system resources since it isn't needed anymore
            gfx.Dispose();
        }
        private void ToolErasing()
        {
            var pen = new Pen(Color.White, 10);
            //instead of drawing onto the canvaspanel, draw onto the bitmap
            var gfx = Graphics.FromImage(bmpCanvas);
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            gfx.DrawLine(pen, mouseLocationA, mouseLocationB);

            //update panel to show changes
            CanvasPanel.Invalidate();

            //frees up system resources since it isn't needed anymore
            gfx.Dispose();
            
        }

        private void ChangeCanvasSizeButton_Click(object sender, EventArgs e)
        {
            CanvasPanel.Width = int.Parse(CanvasWidthTextbox.Text);
            CanvasPanel.Height = int.Parse(CanvasHeightTextbox.Text);

            //reflect size changes on the bitmap aswell
            bmpCanvas = new Bitmap(bmpCanvas, CanvasPanel.Size);
        }

        //serializable lets compiler know that this class can be saved to a file
        //this class stores data types or objects to be restored
        [Serializable()]
        public class CanvasData
        {
            //variables to be saved
            private Bitmap bmpCanvas;
            private Tool currentTool;
            private string fileName;
            private Color currentColor;

            //constructor
            public CanvasData(Bitmap bmp, Tool tool, string file, Color inputColor)
            {
                this.bmpCanvas = bmp;
                this.currentTool = tool;
                this.fileName = file;
                this.currentColor = inputColor;
            }

            //getter setters
            public Bitmap GetBmpCanvas
            {
                get => bmpCanvas;
                set => bmpCanvas = value;
            }
            public Tool GetCurrentTool
            {
                get => currentTool;
                set => currentTool = value;
            }
            public string GetFileName
            {
                get => fileName;
                set => fileName = value;
            }
            public Color GetCurrentColor
            {
                get => currentColor;
                set => currentColor = value;
            }

            //used for debugging, prints to Output window (bottom right)
            public void Print()
            {
                Trace.WriteLine(fileName);
                Trace.WriteLine(currentTool.ToString());
                Trace.WriteLine(bmpCanvas.Width);
                Trace.WriteLine(currentColor);
            }
        }

        //Open data
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileExplorerDialog = new OpenFileDialog();
            fileExplorerDialog.Filter = "Bin file|*.bin";
            fileExplorerDialog.Title = "Open a canvas project";
            //open popup and  check that user picked a location
            if (fileExplorerDialog.ShowDialog() == DialogResult.OK)
            {
                //open file connection
                Stream openFileStream = File.OpenRead(fileExplorerDialog.FileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                //get data from file to object
                CanvasData tempData = (CanvasData)deserializer.Deserialize(openFileStream);
                //end connection to file
                openFileStream.Close();

                //tempData.Print();

                //replace current values with the ones from file
                bmpCanvas = new Bitmap(tempData.GetBmpCanvas);
                currentTool = tempData.GetCurrentTool;
                saveFileName = tempData.GetFileName;
                ColourButton.BackColor = tempData.GetCurrentColor;
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
                CanvasData tempData = new CanvasData(bmpCanvas, currentTool, saveFileName, ColourButton.BackColor);

                //create file at location given by user
                Stream saveFileStream = File.Create(saveFileName);
                BinaryFormatter serializer = new BinaryFormatter();
                //add object data to file
                serializer.Serialize(saveFileStream, tempData);
                //end connection to file
                saveFileStream.Close();
            }
            //if file does not exist
            else
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        //Save As... data
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //allows user to find a location to save file
            SaveFileDialog fileExplorerDialog = new SaveFileDialog();
            //automatically save as this file extension
            fileExplorerDialog.Filter = "Bin file|*.bin";
            fileExplorerDialog.Title = "Save as...";
            //allows user to find a location to save file
            if (fileExplorerDialog.ShowDialog() == DialogResult.OK)
            {
                //store wanted variables/data in this object
                CanvasData tempData = new CanvasData(bmpCanvas, currentTool, fileExplorerDialog.FileName, ColourButton.BackColor);

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
            //allows user to find a location to save file
            SaveFileDialog fileExplorerDialog = new SaveFileDialog();
            //automatically save as this file extension
            fileExplorerDialog.Filter = "Bitmap Image|*.bmp";
            fileExplorerDialog.Title = "Export to BMP";
            //open popup and  check that user picked a location
            if (fileExplorerDialog.ShowDialog() == DialogResult.OK)
            {
                //save at location
                bmpCanvas.Save(fileExplorerDialog.FileName);
            }
        }

        //export to jpg
        private void jpgJPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //allows user to find a location to save file
            SaveFileDialog fileExplorerDialog = new SaveFileDialog();
            //automatically save as this file extension
            fileExplorerDialog.Filter = "JPG Image|*.jpg";
            fileExplorerDialog.Title = "Export to JPG";
            //open popup and  check that user picked a location
            if (fileExplorerDialog.ShowDialog() == DialogResult.OK)
            {
                //save at location
                bmpCanvas.Save(fileExplorerDialog.FileName);
            }
        }

        //export to png
        private void pngPNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //allows user to find a location to save file
            SaveFileDialog fileExplorerDialog = new SaveFileDialog();
            //automatically save as this file extension
            fileExplorerDialog.Filter = "PNG Image|*.png";
            fileExplorerDialog.Title = "Export to PNG";
            //open popup and  check that user picked a location
            if (fileExplorerDialog.ShowDialog() == DialogResult.OK)
            {
                //save at location
                bmpCanvas.Save(fileExplorerDialog.FileName);
            }
        }

    }

}
