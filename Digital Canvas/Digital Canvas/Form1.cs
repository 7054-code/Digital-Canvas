using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Canvas
{
    public partial class MainForm : Form
    {
        public enum Tool
        {
            Pen, Eraser
        }

        Tool currentTool;
        Point mouseLocationA;
        Point mouseLocationB;

        public MainForm()
        {
            InitializeComponent();
            this.ColourButton.BackColor = System.Drawing.Color.Black;
            EraserButton.BackColor = Color.Transparent;
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
            var gfx = CanvasPanel.CreateGraphics();
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            gfx.DrawLine(pen, mouseLocationA, mouseLocationB);
        }
        private void ToolErasing()
        {
            var pen = new Pen(Color.White, 10);
            var gfx = CanvasPanel.CreateGraphics();
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            gfx.DrawLine(pen, mouseLocationA, mouseLocationB);
        }

       
        
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void changeCanvasSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2(ref CanvasPanel, this);
            newform.Show();
        }

        private void ColourLabel_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
              this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
