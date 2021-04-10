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
            PEN, PENCIL, PAINTBRUSH, ERASER, EYEDROPPER, TEXT, FILL, SELECT
        }
        
        //each Layer has its own bitmap
        private List<Layer> listLayers = new List<Layer>();
        //used to know which layer is being edited
        private string currentLayer;

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
        Bitmap pencilImage = new Bitmap(@Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Resources\Pencil.png")));
        Bitmap paintbrushImage = new Bitmap(Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Resources\Paintbrush.png")));

        //pen for drawing the cursor
        Pen cursorPen = new Pen(Brushes.Black);

        //used to check if file exists already for 'Save'
        string saveFileName;

        //simple list of transformations used to reset bmpcanvas back to start
        List<string> transformations = new List<string>();

        //the zoom scaling 
        private float zoomScale = 1f;

        //the position of the bmp on the canvas as displayed to the user
        private PointF canvasPosition = PointF.Empty;

        //area currently able to be drawn to
        //used for selection tool
        public Rectangle activeArea = new Rectangle();
        public Point dragStart;
        public Bitmap highlight;

        public Bitmap copyBmp;

        public MainForm()
        {
            InitializeComponent();

            ColourButton.BackColor = Color.Black;

            //setting bitmap to CanvasPanel size
            bmpCanvas = new Bitmap(CanvasPanel.Width, CanvasPanel.Height);
            
            //when the .Paint event happens -> do the _Paint method (happens on .Invalidate() and startup)
            CanvasPanel.Paint += CanvasPanel_Paint;
            MouseWheel += splitContainer1_MouseWheel;
            //prevents flickering when drawing on screen
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, CanvasPanel,
                new object[] { true });
            //int cursorsize = 0;

            //set default active area
            activeArea = new Rectangle(0, 0, CanvasPanel.Width, CanvasPanel.Height);
            
            //start off with 1 layer
            listLayers.Add(new Layer("layer"+(listLayers.Count+1), bmpCanvas));
            //add layers to listbox
            lstboxLayers.Items.AddRange(listLayers.ToArray());
            currentLayer = lstboxLayers.Items[0].ToString();
        }

        private void CanvasPanel_Paint(object sender, PaintEventArgs e)
        {   
            //this draws the bmpcanvas at its location with the required scaling
            //draws each layer in order
            foreach (Layer layer in listLayers)
            {
                //can be toggled by btnLayerVisible
                if (layer.IsVisible)
                {
                    e.Graphics.DrawImage(layer.BmpLayer, canvasPosition.X,canvasPosition.Y, layer.BmpLayer.Size.Width * zoomScale, layer.BmpLayer.Size.Height * zoomScale);
                }
            }
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

        //movement on canvas panel for brush tool movements and pen cursor
        private void CanvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            var gfx = Graphics.FromImage(bmpCanvas);
            int xPosition = (int)((e.X - canvasPosition.X) / zoomScale);
            int yPosition = (int)((e.Y - canvasPosition.Y) / zoomScale);

            if (e.Button == MouseButtons.Left)
            {
                cursorLocationA = cursorLocationB;
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
                else if (currentTool == Tool.EYEDROPPER)
                {
                    ToolEyedropper(sender, e);
                }
                else if (currentTool == Tool.TEXT)
                {
                    ToolText(sender, e);
                }
                else if (currentTool == Tool.FILL)
                {
                    ToolFill(sender, e);
                }
                else if (currentTool == Tool.SELECT)
                {
                    ToolSelectArea(sender, e);
                }
                //store changes in current Layer, this line is added wherever there is a change to bmpCanvas
                listLayers.Find(layer => layer.LayerName == currentLayer).BmpLayer = bmpCanvas;
            }

            if (currentTool == Tool.PEN || currentTool == Tool.PENCIL || currentTool == Tool.PAINTBRUSH || currentTool == Tool.ERASER)
            {
                cursorCircle(sender, e);
            }
            else
            {
                cursorCross(sender, e);
            }

            if (xPosition < bmpCanvas.Width && xPosition >= 0 && yPosition < bmpCanvas.Height && yPosition >= 0)
            {
                XPositionLabel.Text = "X: " + xPosition.ToString();
                YPositionLabel.Text = "Y: " + yPosition.ToString();
            }
        }

        private void cursorCircle(object sender, MouseEventArgs e)
        {
            float diameter = (float)ToolSizeNumericUpDown.Value;
            float radius = diameter / 2;

            //refresh and draw changes made by the tool if the button is pressed
            CanvasPanel.Refresh();

            //gfx.DrawImage(paintbrushImage, (cursorLocationA.X - radius - canvasPosition.X) / zoomScale, (cursorLocationA.Y - radius - canvasPosition.Y) / zoomScale, diameter, diameter);

            //draw the circle cursor
            CanvasPanel.CreateGraphics().DrawEllipse(cursorPen,
                (e.X - (radius * zoomScale)),
                (e.Y - (radius * zoomScale)),
                diameter * zoomScale,
                diameter * zoomScale);
        }

        private void cursorCross(object sender, MouseEventArgs e)
        {
            //refresh and draw changes made by the tool if the button is pressed
            CanvasPanel.Refresh();

            //draw the cross cursor
            CanvasPanel.CreateGraphics().DrawLine(cursorPen, e.X - 5, e.Y, e.X + 5, e.Y);
            CanvasPanel.CreateGraphics().DrawLine(cursorPen, e.X, e.Y + 5, e.X, e.Y - 5);
        }

        private void splitContainer1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                zoomInFunctionality();
            }

            if (e.Delta < 0)
            {
                zoomOutFunctionality();
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
            else if (currentTool == Tool.EYEDROPPER)
            {
                ToolEyedropper(sender, e);
            }
            else if (currentTool == Tool.TEXT)
            {
                ToolText(sender, e);
            }
            else if (currentTool == Tool.FILL)
            {
                ToolFill(sender, e);
            }
            else if (currentTool == Tool.SELECT)
            {
                dragStart = e.Location;
            }
            //store changes in current Layer, this line is added wherever there is a change to bmpCanvas
            listLayers.Find(layer => layer.LayerName == currentLayer).BmpLayer = bmpCanvas;
        }

        //tool button icons with click events for when a tool is selected
        private void PenButton_Click(object sender, EventArgs e)
        {
            currentTool = Tool.PEN;
        }

        private void PencilButton_Click(object sender, EventArgs e)
        {
            currentTool = Tool.PENCIL;
        }

        private void PaintbrushButton_Click(object sender, EventArgs e)
        {
            currentTool = Tool.PAINTBRUSH;
        }

        private void EraserButton_Click(object sender, EventArgs e)
        {
            currentTool = Tool.ERASER;
        }

        private void EyedropperButton_Click(object sender, EventArgs e)
        {
            currentTool = Tool.EYEDROPPER;
        }

        private void TextButton_Click(object sender, EventArgs e)
        {
            currentTool = Tool.TEXT;
        }

        private void FillTool_Click(object sender, EventArgs e)
        {
            currentTool = Tool.FILL;
        }

        private void SelectionButton_Click(object sender, EventArgs e)
        {
            currentTool = Tool.SELECT;
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

        //creating an eraser with opacity, colour, size and passing it to the DrawLineCanvas method
        private void ToolErasing()
        {
            //alpha = opacity so set to 0 to override previous alpha of whatever is drawn
            var pen = new Pen(Color.FromArgb(0, Color.Transparent), (int)ToolSizeNumericUpDown.Value);
            DrawLineCanvas(pen);
        }

        //creating the pencil tool
        private void ToolPencilDrawing()
        {
            int height = pencilImage.Height;
            int width = pencilImage.Width;

            //pencil diameter and radius
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
            if (mouseInActiveArea())
            {
                gfx.DrawImage(pencilImage, (cursorLocationA.X - (radius * zoomScale) - canvasPosition.X) / zoomScale,
                    (cursorLocationA.Y - (radius * zoomScale) - canvasPosition.Y) / zoomScale,
                    diameter,
                    diameter);
            }

            //update panel to show changes - results in .Paint event so _Paint method is called
            CanvasPanel.Invalidate();
            //frees up system resources since it isn't needed anymore
            gfx.Dispose();
        }

        //creating a paintbrush tool
        private void ToolPaintbrushDrawing()
        {
            int height = paintbrushImage.Height;
            int width = paintbrushImage.Width;

            //paintbrush diameter and radius
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

            if (mouseInActiveArea())
            {
                gfx.DrawImage(paintbrushImage, (cursorLocationA.X - (radius * zoomScale) - canvasPosition.X) / zoomScale,
                  (cursorLocationA.Y - (radius * zoomScale) - canvasPosition.Y) / zoomScale,
                  diameter,
                  diameter);
            }

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
            //SourceCopy allows eraser to work but shouldn't be used when drawing since it looks weird
            if (currentTool == Tool.ERASER)
            {
                gfx.CompositingMode = CompositingMode.SourceCopy;   
            }
            else
            {
                gfx.CompositingMode = CompositingMode.SourceOver;
            }
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

            //the zoomScale multiplier changes the cursor location to match the zoom level, otherwise the cursor would paint in the location at the default zoom
            //the canvasPosition addition changes the cursor to match the canvas when it gets moved up, down, left or right
            if (mouseInActiveArea())
            {
                gfx.DrawLine(pen,
                  (cursorLocationA.X - canvasPosition.X) / zoomScale,
                  (cursorLocationA.Y - canvasPosition.Y) / zoomScale,
                  (cursorLocationB.X - canvasPosition.X) / zoomScale,
                  (cursorLocationB.Y - canvasPosition.Y) / zoomScale);
            }
            //update panel to show changes - results in .Paint event so _Paint method is called
            CanvasPanel.Invalidate();

            //frees up system resources since it isn't needed anymore
            gfx.Dispose();
        }

        //eyedropper tool to get a colour picked from the canvas
        private void ToolEyedropper(object sender, MouseEventArgs e)
        {
            //stores the x and y value of the cursor position which takes into account the canvas position and zoom scale
            int xPosition = (int)((e.X - canvasPosition.X) / zoomScale);
            int yPosition = (int)((e.Y - canvasPosition.Y) / zoomScale);

            //only allows the tool to work in the canvas area
            if (xPosition < bmpCanvas.Width && xPosition >= 0 && yPosition < bmpCanvas.Height && yPosition >= 0)
            {
                //gets the pixel from cursor position and changes the colour to the selected colour
                Color colour = bmpCanvas.GetPixel((int)xPosition, (int)yPosition);
                ColourButton.BackColor = colour;
                CanvasPanel.Invalidate();
            }
        }

        private void ToolText(object sender, MouseEventArgs e)
        {
            int xPosition = (int)((e.X - canvasPosition.X) / zoomScale);
            int yPosition = (int)((e.Y - canvasPosition.Y) / zoomScale);

            if (xPosition < bmpCanvas.Width && xPosition >= 0 && yPosition < bmpCanvas.Height && yPosition >= 0)
            {
                //user inputs width and height for canvas change
                using (TextToolForm textToolForm = new TextToolForm(this))
                {
                    //if user pressed the confirm button
                    if (textToolForm.ShowDialog() == DialogResult.OK)
                    {
                        string textInput = textToolForm.TextInput;
                        string textFontFamily = textToolForm.TextFont;
                        float textSize = textToolForm.TextSize;
                        bool textBold = textToolForm.TextBold;
                        bool textItalics = textToolForm.TextItalics;
                        bool textUnderline = textToolForm.TextUnderline;
                        bool textStrikethrough = textToolForm.TextStrikethrough;

                        Font textFont = new Font(textFontFamily, textSize);
                        Color textColour = textToolForm.TextColour;
                        SolidBrush textBrush = new SolidBrush(textColour);

                        if (textBold == true)
                        {
                            textFont = new Font(textFont, textFont.Style | FontStyle.Bold);
                        }
                        else
                        {
                            textFont = new Font(textFont, textFont.Style & ~FontStyle.Bold);
                        }

                        if (textItalics == true)
                        {
                            textFont = new Font(textFont, textFont.Style | FontStyle.Italic);
                        }
                        else
                        {
                            textFont = new Font(textFont, textFont.Style & ~FontStyle.Italic);
                        }

                        if (textUnderline == true)
                        {
                            textFont = new Font(textFont, textFont.Style | FontStyle.Underline);
                        }
                        else
                        {
                            textFont = new Font(textFont, textFont.Style & ~FontStyle.Underline);
                        }

                        if (textStrikethrough == true)
                        {
                            textFont = new Font(textFont, textFont.Style | FontStyle.Strikeout);
                        }
                        else
                        {
                            textFont = new Font(textFont, textFont.Style & ~FontStyle.Strikeout);
                        }

                        using (Graphics gfx = Graphics.FromImage(bmpCanvas))
                        {
                            gfx.DrawString(textInput, textFont, textBrush, new Point(xPosition, yPosition));

                            gfx.Dispose();
                        }

                        CanvasPanel.Invalidate();
                        textFont.Dispose();
                        textBrush.Dispose();
                    }
                }
            }
        }

        //Floodfill tool
        private void ToolFill(object sender, MouseEventArgs e)
        {
            //Creates a stack for points
            Stack<Point> pixels = new Stack<Point>();

            //stores the x, y and x-y position value of the cursor position which takes into account the canvas position and zoom scale
            int xPosition = (int)((e.X - canvasPosition.X) / zoomScale);
            int yPosition = (int)((e.Y - canvasPosition.Y) / zoomScale);
            Point xyPosition = new Point((int)((e.X - canvasPosition.X) / zoomScale), (int)((e.Y - canvasPosition.Y) / zoomScale));

            //only allows the tool to work in the canvas area
            if (xPosition < bmpCanvas.Width && xPosition >= 0 && yPosition < bmpCanvas.Height && yPosition >= 0)
            {
                //target colour is the one to be replaced by getting the colour from the point passed in
                Color targetColour = bmpCanvas.GetPixel(xPosition, yPosition);
                Color replaceColour = ColourButton.BackColor;

                //pushes stack of pixels to be changed
                pixels.Push(xyPosition);

                //if the target colour and replace colour are equal to each other, return to end the while loop for that pixel
                if (targetColour.ToArgb().Equals(replaceColour.ToArgb()))
                {
                    return;
                }

                //while stack not empty
                while (pixels.Count > 0)
                {
                    //pop off a pixel
                    Point pixel = pixels.Pop();

                    //Only fill within canvas size
                    if (pixel.X < bmpCanvas.Width && pixel.X >= 0 && pixel.Y < bmpCanvas.Height && pixel.Y >= 0)
                    {
                        //if pixel equals to target colour, change pixel to replace colour and push new point for north, east, south and west
                        if (bmpCanvas.GetPixel(pixel.X, pixel.Y) == targetColour)
                        {

                            bmpCanvas.SetPixel(pixel.X, pixel.Y, replaceColour);
                            pixels.Push(new Point(pixel.X - 1, pixel.Y));
                            pixels.Push(new Point(pixel.X + 1, pixel.Y));
                            pixels.Push(new Point(pixel.X, pixel.Y - 1));
                            pixels.Push(new Point(pixel.X, pixel.Y + 1));
                        }
                    }
                }

                //refresh and invalidate canvas panel then return
                CanvasPanel.Refresh();
                CanvasPanel.Invalidate();
                return;
            }
        }

        private void ToolSelectArea(object sender, MouseEventArgs e)
        {
            int xPosition = e.X;
            int yPosition = e.Y;
            int dragStartY = dragStart.X;
            int dragStartX = dragStart.Y;

            activeArea = new Rectangle(dragStartX, dragStartY, xPosition - dragStartX, yPosition - dragStartY);

            if (activeArea.Height > 0 & activeArea.Width > 0 & xPosition < bmpCanvas.Width & xPosition >= 0 & yPosition < bmpCanvas.Height & yPosition >= 0)
            {
                highlight = new Bitmap(activeArea.Width, activeArea.Height);

                //draw the box
                for (int i = 0; i < activeArea.Width; i++)
                {
                    highlight.SetPixel(i, 0, Color.DarkGray);
                    highlight.SetPixel(i, highlight.Height - 1, Color.DarkGray);
                }

                for (int j = 0; j < activeArea.Height; j++)
                {
                    highlight.SetPixel(0, j, Color.DarkGray);
                    highlight.SetPixel(highlight.Width - 1, j, Color.DarkGray);
                }

                using (Graphics gfx = CanvasPanel.CreateGraphics())
                {
                    gfx.DrawImage(highlight, new Point(activeArea.X, activeArea.Y));
                }
            }
        }

        //resize canvas but keep drawing/image scale the same
        private void changeCanvasSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //user inputs width and height for canvas change
            using (CanvasSizeForm canvasSizeForm = new CanvasSizeForm(this))
            {
                //if user pressed the confirm button
                if (canvasSizeForm.ShowDialog() == DialogResult.OK)
                {
                    //set panel dimensions to user input
                    //CanvasPanel.Width = canvasSizeForm.InputWidth;
                    // CanvasPanel.Height = canvasSizeForm.InputHeight;

                    //create blank bitmap with updated dimensions
                    Bitmap tempBitmap = new Bitmap(canvasSizeForm.InputWidth, canvasSizeForm.InputHeight);
                    using (Graphics g = Graphics.FromImage(tempBitmap))
                    {
                        //draw original bitmap on the new bitmap keeping scale the same
                        g.DrawImage(bmpCanvas, 0, 0, bmpCanvas.Width, bmpCanvas.Height);
                    }
                    //replace original bitmap with updated bitmap and new dimensions
                    bmpCanvas = new Bitmap(tempBitmap, tempBitmap.Size);
                    //store changes in current Layer, this line is added wherever there is a change to bmpCanvas
                    listLayers.Find(layer => layer.LayerName == currentLayer).BmpLayer = bmpCanvas;
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
            private List<Layer> _layers;

            //constructor
            public CanvasData(Bitmap bmp, Tool tool, string file, Color inputColor, int width, int height, List<Layer> layers)
            {
                _bmpCanvas = bmp;
                _currentTool = tool;
                _fileName = file;
                _currentColor = inputColor;
                _canvasWidth = width;
                _canvasHeight = height;
                _layers = layers;
            }

            //getters
            public Bitmap GetBmpCanvas => _bmpCanvas;
            public Tool GetCurrentTool => _currentTool;
            public string GetFileName => _fileName;
            public Color GetCurrentColor => _currentColor;
            public int GetCanvasWidth => _canvasWidth;
            public int GetCanvasHeight => _canvasHeight;
            public List<Layer> GetLayerList => _layers;
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
                CanvasData tempData = (CanvasData)deserializer.Deserialize(openFileStream);
                //end connection to file
                openFileStream.Close();

                //replace current values with the ones from file
                bmpCanvas = new Bitmap(tempData.GetBmpCanvas);
                currentTool = tempData.GetCurrentTool;
                saveFileName = tempData.GetFileName;
                ColourButton.BackColor = tempData.GetCurrentColor;
                CanvasPanel.Width = tempData.GetCanvasWidth;
                CanvasPanel.Height = tempData.GetCanvasHeight;
                listLayers = tempData.GetLayerList;
                lstboxLayers.Items.Clear();
                lstboxLayers.Items.AddRange(listLayers.ToArray());
                lstboxLayers.SetSelected(0, true);
                currentLayer = lstboxLayers.SelectedItem.ToString();
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
                    CanvasPanel.Width, CanvasPanel.Height, listLayers);

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
                    ColourButton.BackColor, CanvasPanel.Width, CanvasPanel.Height, listLayers);

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
            {
                //add all the different layers to this new bitmap
                Bitmap tempBitmap = new Bitmap(CanvasPanel.Width, CanvasPanel.Height);
                foreach (Layer layer in listLayers)
                {
                    Graphics tempGraphics = Graphics.FromImage(tempBitmap);
                    tempGraphics.DrawImage(layer.BmpLayer, Point.Empty);
                }
                //save at location
                tempBitmap.Save(fileExplorerDialog.FileName);
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
                listLayers.Find(layer => layer.LayerName == currentLayer).BmpLayer = bmpCanvas;
                //update canvas
                CanvasPanel.Invalidate();
            }
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
        private void rotate90RightFunctionality()
        {
            //save current bitmap before changing it
            undoList.Push(new Bitmap(bmpCanvas));

            bmpCanvas.RotateFlip(RotateFlipType.Rotate90FlipNone);
            listLayers.Find(layer => layer.LayerName == currentLayer).BmpLayer = bmpCanvas;
            transformations.Add("plus90");
            //update canvas
            CanvasPanel.Invalidate();
        }

        //rotate bmpccanvas +180°
        private void rotate180Functionality()
        {
            //save current bitmap before changing it
            undoList.Push(new Bitmap(bmpCanvas));

            bmpCanvas.RotateFlip(RotateFlipType.Rotate180FlipNone);
            listLayers.Find(layer => layer.LayerName == currentLayer).BmpLayer = bmpCanvas;
            transformations.Add("plus180");
            CanvasPanel.Invalidate();
        }

        //rotate bmpcanvas -90°
        private void rotate90LeftFunctionality()
        {
            //save current bitmap before changing it
            undoList.Push(new Bitmap(bmpCanvas));

            bmpCanvas.RotateFlip(RotateFlipType.Rotate270FlipNone);
            listLayers.Find(layer => layer.LayerName == currentLayer).BmpLayer = bmpCanvas;
            transformations.Add("minus90");
            CanvasPanel.Invalidate();
        }

        //iterate through transformations list and apply opposite transformation
        private void resetRotationFunctionality()
        {
            //save current bitmap before changing it
            undoList.Push(new Bitmap(bmpCanvas));

            //for all historical transformations
            for (int i = 0; i < transformations.Count; i++)
            {   //if currently considered transformation is a plus 90 rotate
                if (transformations[i] == "plus90")
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
                else if (transformations[i] == "flipX")
                {
                    bmpCanvas.RotateFlip(RotateFlipType.RotateNoneFlipX);
                }
                else if (transformations[i] == "flipY")
                {
                    bmpCanvas.RotateFlip(RotateFlipType.RotateNoneFlipY);
                }

            }
            //clear the transformations history
            transformations.Clear();
            listLayers.Find(layer => layer.LayerName == currentLayer).BmpLayer = bmpCanvas;
            //redraw the panel
            CanvasPanel.Invalidate();
        }

        private void rotate90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rotate90RightFunctionality();
        }

        private void rotate180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rotate180Functionality();
        }

        private void rotate90ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rotate90LeftFunctionality();
        }

        private void resetRotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetRotationFunctionality();
        }

        private void RotateLeftButton_Click(object sender, EventArgs e)
        {
            rotate90LeftFunctionality();
        }

        private void RotateRightButton_Click(object sender, EventArgs e)
        {
            rotate90RightFunctionality();
        }

        //undo a change by restoring a previous bitmap
        private void undoFunctionality()
        {
            //error checking
            if (undoList.Count != 0)
            {
                //add current bitmap to redolist
                redoList.Push(new Bitmap(bmpCanvas));
                //sets current bitmap to last change and removes it from undoList
                bmpCanvas = new Bitmap(undoList.Pop());
                listLayers.Find(layer => layer.LayerName == currentLayer).BmpLayer = bmpCanvas;
                //update canvas
                CanvasPanel.Invalidate();
            }
        }

        //same as undo
        private void redoFunctionality()
        {
            if (redoList.Count != 0)
            {
                undoList.Push(new Bitmap(bmpCanvas));
                bmpCanvas = new Bitmap(redoList.Pop());
                listLayers.Find(layer => layer.LayerName == currentLayer).BmpLayer = bmpCanvas;
                CanvasPanel.Invalidate();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoFunctionality();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redoFunctionality();
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            undoFunctionality();
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            redoFunctionality();
        }

        //hide cursor when entered canvas panel
        private void CanvasPanel_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        //show cursor when leaving canvas panel
        private void CanvasPanel_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void zoomInFunctionality()
        {
            zoomScale = zoomScale * 1.1f;            //magic numbers are bad, but this just changes the zoomScale, which affects how much the image is resized for the zoom
            CanvasPanel.Invalidate();
        }

        private void zoomOutFunctionality()
        {
            zoomScale = zoomScale * 0.9f;
            CanvasPanel.Invalidate();
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoomInFunctionality();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoomOutFunctionality();
        }

        private void ZoomOutButton_Click(object sender, EventArgs e)
        {
            zoomOutFunctionality();
        }

        private void ZoomInButton_Click(object sender, EventArgs e)
        {
            zoomInFunctionality();
        }

        private void percentViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoomScale = 1f;
            CanvasPanel.Invalidate();
        }

        private void upToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvasPosition.Y = canvasPosition.Y + 20;
            CanvasPanel.Invalidate();
        }

        private void downToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvasPosition.Y = canvasPosition.Y - 20;
            CanvasPanel.Invalidate();
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvasPosition.X = canvasPosition.X + 20;
            CanvasPanel.Invalidate();
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvasPosition.X = canvasPosition.X - 20;
            CanvasPanel.Invalidate();
        }

        private void flipHorizontallyFunctionality()
        {
            //save current bitmap before changing it
            undoList.Push(new Bitmap(bmpCanvas));
            bmpCanvas.RotateFlip(RotateFlipType.RotateNoneFlipX);
            listLayers.Find(layer => layer.LayerName == currentLayer).BmpLayer = bmpCanvas;
            transformations.Add("flipX");
            CanvasPanel.Invalidate();
        }

        private void flipVerticallyFunctionality()
        {
            //save current bitmap before changing it
            undoList.Push(new Bitmap(bmpCanvas));
            bmpCanvas.RotateFlip(RotateFlipType.RotateNoneFlipY);
            listLayers.Find(layer => layer.LayerName == currentLayer).BmpLayer = bmpCanvas;
            transformations.Add("flipY");
            CanvasPanel.Invalidate();
        }

        private void flipHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flipHorizontallyFunctionality();
        }

        private void flipVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flipVerticallyFunctionality();
        }

        private void FlipHorizontallyButton_Click(object sender, EventArgs e)
        {
            flipHorizontallyFunctionality();
        }

        private void FlipVerticallyButton_Click(object sender, EventArgs e)
        {
            flipVerticallyFunctionality();
        }

        private void instructionManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (InstructionManualForm instructionManualForm = new InstructionManualForm(this))
            {
                //Shows read only instruction manual
                if (instructionManualForm.ShowDialog() == DialogResult.OK)
                {
                }
            }

        }

        private void lstboxLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change current layer to selected layer
            currentLayer = lstboxLayers.SelectedItem.ToString();
            //for editing on the new current layer
            bmpCanvas = new Bitmap(listLayers.Find(layer => layer.LayerName == currentLayer).BmpLayer);

            //change image to indicate visibility state to user
            if (listLayers.Find(layer => layer.LayerName == currentLayer).IsVisible)
            {
                btnLayersVisible.BackgroundImage = Image.FromFile(@Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Resources\hideLayerIcon.png")));
            }
            else
            {
                btnLayersVisible.BackgroundImage = Image.FromFile(@Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Resources\viewLayerIcon.png")));
            }

            CanvasPanel.Invalidate();
        }

        private void btnLayersAdd_Click(object sender, EventArgs e)
        {
            //check if layer name already exists
            //prevent same layer name from being used more than once
            if (listLayers.Exists(layer => layer.LayerName == "layer" + (listLayers.Count + 1)))
            {
                int counter = 1;
                //until wanted new layer name doesn't exist
                while (listLayers.Exists(layer => layer.LayerName == "layer" + counter))
                {
                    counter += 1;
                }
                //new layer with empty bitmap using counter to prevent same name
                listLayers.Add(new Layer("layer"+counter, new Bitmap(CanvasPanel.Width, CanvasPanel.Height)));
            }
            else
            {
                //new layer with empty bitmap
                listLayers.Add(new Layer("layer"+(listLayers.Count+1), new Bitmap(CanvasPanel.Width, CanvasPanel.Height)));
            }
            
            //update the listbox
            lstboxLayers.Items.Clear();
            lstboxLayers.Items.AddRange(listLayers.ToArray());
            //this method of updating listbox resets selection, re-select previously selected layer
            int match = lstboxLayers.FindStringExact(currentLayer);
            if (match != ListBox.NoMatches)
            {
                lstboxLayers.SetSelected(match, true);
            }
        }

        private void btnLayersRemove_Click(object sender, EventArgs e)
        {
            //prevent out of bounds error
            if (listLayers.Count > 1)
            {
                //Find is used to get the layer by matching currentLayer to the LayerName property in Layer class
                listLayers.Remove(listLayers.Find(layer => layer.LayerName == currentLayer));
                lstboxLayers.Items.Clear();
                lstboxLayers.Items.AddRange(listLayers.ToArray());
                lstboxLayers.SetSelected(0, true);
                //previous current layer deleted so choose a new one
                currentLayer = lstboxLayers.SelectedItem.ToString();

                //update panel
                CanvasPanel.Invalidate();
            }
        }

        private void btnLayersVisible_Click(object sender, EventArgs e)
        {
            //toggles between true and false
            listLayers.Find(layer => layer.LayerName == currentLayer).IsVisible =
                !listLayers.Find(layer => layer.LayerName == currentLayer).IsVisible;

            //change image to indicate visibility state to user
            if (listLayers.Find(layer => layer.LayerName == currentLayer).IsVisible)
            {
                btnLayersVisible.BackgroundImage = Image.FromFile(@Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Resources\hideLayerIcon.png")));
            }
            else
            {
                btnLayersVisible.BackgroundImage = Image.FromFile(@Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Resources\viewLayerIcon.png")));
            }

            //update panel to show layer change
            CanvasPanel.Invalidate();
        }

        private void btnLayersMoveUp_Click(object sender, EventArgs e)
        {
            //prevent out of bounds error
            if (listLayers.Count > 1 &&  listLayers.IndexOf(listLayers.Find(layer => layer.LayerName == currentLayer)) != 0)
            {
                //check below for Swap method
                Swap(listLayers, listLayers.IndexOf(listLayers.Find(layer => layer.LayerName == currentLayer)), listLayers.IndexOf(listLayers.Find(layer => layer.LayerName == currentLayer))-1);

                lstboxLayers.Items.Clear();
                lstboxLayers.Items.AddRange(listLayers.ToArray());
                lstboxLayers.SetSelected(listLayers.IndexOf(listLayers.Find(layer => layer.LayerName == currentLayer)), true);
                currentLayer = lstboxLayers.SelectedItem.ToString();

                CanvasPanel.Invalidate();
            }
        }

        private void btnLayersMoveDown_Click(object sender, EventArgs e)
        {
            if (listLayers.Count > 1 &&  listLayers.IndexOf(listLayers.Find(layer => layer.LayerName == currentLayer)) != listLayers.Count-1)
            {
                Swap(listLayers, listLayers.IndexOf(listLayers.Find(layer => layer.LayerName == currentLayer)), listLayers.IndexOf(listLayers.Find(layer => layer.LayerName == currentLayer))+1);

                lstboxLayers.Items.Clear();
                lstboxLayers.Items.AddRange(listLayers.ToArray());
                lstboxLayers.SetSelected(listLayers.IndexOf(listLayers.Find(layer => layer.LayerName == currentLayer)), true);
                currentLayer = lstboxLayers.SelectedItem.ToString();

                CanvasPanel.Invalidate();
            }
        }

        //swap layers
        private void Swap<Layer>(List<Layer> list, int indexA, int indexB)
        {
            //store A before it is replaced
            Layer temp = list[indexA];
            //replace A with B
            list[indexA] = list[indexB];
            //replace B with what A was (using temp)
            list[indexB] = temp;
        }

        public bool mouseInActiveArea()
        {
            return (cursorLocationA.X > activeArea.X && cursorLocationA.X < (activeArea.X + activeArea.Width))
                && (cursorLocationA.Y > activeArea.Y && cursorLocationA.Y < (activeArea.Y + activeArea.Height));
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyBmp = bmpCanvas.Clone(activeArea, PixelFormat.Format32bppPArgb);

            SolidBrush transparentBrush = new SolidBrush(Color.FromArgb(0, Color.Transparent));

            using (Graphics gfx = Graphics.FromImage(bmpCanvas))
            {
                gfx.CompositingMode = CompositingMode.SourceCopy;
                gfx.FillRectangle(transparentBrush, activeArea);
            }
            CanvasPanel.Invalidate();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyBmp = bmpCanvas.Clone(activeArea, PixelFormat.Format32bppPArgb);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point p = new Point(activeArea.X, activeArea.Y);

            using (Graphics gfx = Graphics.FromImage(bmpCanvas))
            {
                gfx.DrawImage(copyBmp, p);
                gfx.Dispose();
            }

            CanvasPanel.Invalidate();
        }

        private void DeselectButton_Click(object sender, EventArgs e)
        {
            activeArea = new Rectangle(0, 0, CanvasPanel.Width, CanvasPanel.Height);
        }

        private void TransformFlipHorizontalButton_Click(object sender, EventArgs e)
        {
            undoList.Push(new Bitmap(bmpCanvas));

            Bitmap b = bmpCanvas.Clone(activeArea, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

            //flip the bmp
            b.RotateFlip(RotateFlipType.RotateNoneFlipX);

            using (Graphics gfx = Graphics.FromImage(bmpCanvas))
            {
                gfx.DrawImage(b, new Point(activeArea.X, activeArea.Y));
                gfx.Dispose();
            }

            CanvasPanel.Invalidate();
        }

        private void TransformFlipVerticalButton_Click(object sender, EventArgs e)
        {
            undoList.Push(new Bitmap(bmpCanvas));

            Bitmap b = bmpCanvas.Clone(activeArea, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

            //flip the bmp
            b.RotateFlip(RotateFlipType.RotateNoneFlipY);

            using (Graphics gfx = Graphics.FromImage(bmpCanvas))
            {
                gfx.DrawImage(b, new Point(activeArea.X, activeArea.Y));
                gfx.Dispose();
            }

            CanvasPanel.Invalidate();
        }

        //keyboard shortcuts
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //brush types--------------------------
            if (e.KeyCode == Keys.P && !e.Control)
            {
                PenButton.PerformClick();
            }

            if (e.KeyCode == Keys.P && e.Control)
            {
                PencilButton.PerformClick();
            }

            if (e.KeyCode == Keys.B)
            {
                PaintbrushButton.PerformClick();
            }

            if (e.KeyCode == Keys.E)
            {
                EraserButton.PerformClick();
            }
            //-------------------------------------

            //other tools--------------------------
            if (e.KeyCode == Keys.I)
            {
                EyedropperButton.PerformClick();
            }

            if (e.KeyCode == Keys.T)
            {
                TextButton.PerformClick();
            }

            if (e.KeyCode == Keys.G)
            {
                FillButton.PerformClick();
            }

            if (e.KeyCode == Keys.M)
            {
                SelectionButton.PerformClick();
            }

            if (e.KeyCode == Keys.D)
            {
                DeselectButton.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.Z)
            {
                UndoButton.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.Y)
            {
                RedoButton.PerformClick();
            }
            //-------------------------------------

            //menu strip---------------------------
            if (e.Control && e.KeyCode == Keys.C)
            {
                copyToolStripMenuItem.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.V)
            {
                pasteToolStripMenuItem.PerformClick();
            }
            //-------------------------------------
        }

        
    }

}
