
using System;
using System.CodeDom;
using System.Dynamic;
using System.Reflection;
using System.Windows.Forms;

namespace Digital_Canvas
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bmpBMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jpgJPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pngPNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.psdPhotoshopDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCanvasSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetRotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate90ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate180ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipHorizontallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipVerticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.LeftToolbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.BackColor = System.Drawing.Color.White;
            this.CanvasPanel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.CanvasPanel.Location = new System.Drawing.Point(118, 135);
            this.CanvasPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(692, 581);
            this.CanvasPanel.TabIndex = 4;
            this.CanvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasPanel_MouseDown);
            this.CanvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasPanel_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1356, 31);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newToolStripMenuItem.Text = "New...";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bmpBMPToolStripMenuItem,
            this.jpgJPGToolStripMenuItem,
            this.pngPNGToolStripMenuItem,
            this.psdPhotoshopDocumentToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.transformToolStripMenuItem,
            this.changeCanvasSizeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(60, 27);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // transformToolStripMenuItem
            // 
            this.transformToolStripMenuItem.Name = "transformToolStripMenuItem";
            this.transformToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transformToolStripMenuItem.Text = "Transform";
            // 
            // changeCanvasSizeToolStripMenuItem
            // 
            this.changeCanvasSizeToolStripMenuItem.Name = "changeCanvasSizeToolStripMenuItem";
            this.changeCanvasSizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeCanvasSizeToolStripMenuItem.Text = "Change Canvas Size";
            this.changeCanvasSizeToolStripMenuItem.Click += new System.EventHandler(this.changeCanvasSizeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.viewToolStripMenuItem1,
            this.rotateToolStripMenuItem,
            this.flipHorizontallyToolStripMenuItem,
            this.flipVerticallyToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(69, 27);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.viewToolStripMenuItem1,
            this.rotateToolStripMenuItem,
            this.flipHorizontallyToolStripMenuItem,
            this.flipVerticallyToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.viewToolStripMenuItem1.Text = "100% View";
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetRotationToolStripMenuItem,
            this.rotate90ToolStripMenuItem,
            this.rotate180ToolStripMenuItem,
            this.rotate90ToolStripMenuItem1,
            this.rotate180ToolStripMenuItem1,
            this.rotateLeftToolStripMenuItem,
            this.rotateRightToolStripMenuItem});
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rotateToolStripMenuItem.Text = "Rotate";
            // 
            // resetRotationToolStripMenuItem
            // 
            this.resetRotationToolStripMenuItem.Name = "resetRotationToolStripMenuItem";
            this.resetRotationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetRotationToolStripMenuItem.Text = "Reset Rotation";
            // 
            // rotate90ToolStripMenuItem
            // 
            this.rotate90ToolStripMenuItem.Name = "rotate90ToolStripMenuItem";
            this.rotate90ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rotate90ToolStripMenuItem.Text = "Rotate +90°";
            // 
            // rotate180ToolStripMenuItem
            // 
            this.rotate180ToolStripMenuItem.Name = "rotate180ToolStripMenuItem";
            this.rotate180ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rotate180ToolStripMenuItem.Text = "Rotate +180°";
            // 
            // rotate90ToolStripMenuItem1
            // 
            this.rotate90ToolStripMenuItem1.Name = "rotate90ToolStripMenuItem1";
            this.rotate90ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.rotate90ToolStripMenuItem1.Text = "Rotate -90°";
            // 
            // rotate180ToolStripMenuItem1
            // 
            this.rotate180ToolStripMenuItem1.Name = "rotate180ToolStripMenuItem1";
            this.rotate180ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.rotate180ToolStripMenuItem1.Text = "Rotate -180°";
            // 
            // rotateLeftToolStripMenuItem
            // 
            this.rotateLeftToolStripMenuItem.Name = "rotateLeftToolStripMenuItem";
            this.rotateLeftToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rotateLeftToolStripMenuItem.Text = "Rotate Left";
            // 
            // rotateRightToolStripMenuItem
            // 
            this.rotateRightToolStripMenuItem.Name = "rotateRightToolStripMenuItem";
            this.rotateRightToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rotateRightToolStripMenuItem.Text = "Rotate Right";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1356, 989);
            this.Controls.Add(this.LeftToolbarPanel);
            this.Controls.Add(this.TopToolbarPanel);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Digital Canvas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.LeftToolbarPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.Label ColourLabel;
        private System.Windows.Forms.Button ColourButton;
        private System.Windows.Forms.Button PenButton;
        private System.Windows.Forms.Button EraserButton;
        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bmpBMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jpgJPGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pngPNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem psdPhotoshopDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeCanvasSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetRotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate90ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rotate180ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rotateLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipHorizontallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipVerticallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateRightToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ColourButton;
        private System.Windows.Forms.Label ColourLabel;
        private System.Windows.Forms.Button PenButton;
        private System.Windows.Forms.Button EraserButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel TopToolbarPanel;
        private System.Windows.Forms.Panel LeftToolbarPanel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel layersPanel;
    }
}

