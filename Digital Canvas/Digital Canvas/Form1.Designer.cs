
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Digital_Canvas
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.percentViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetRotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate90ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flipHorizontallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipVerticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToolOpacitySlider = new System.Windows.Forms.TrackBar();
            this.ToolSizeSlider = new System.Windows.Forms.TrackBar();
            this.ToolOpacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OpacityLabel = new System.Windows.Forms.Label();
            this.ToolSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.ColourButton = new System.Windows.Forms.Button();
            this.ColourLabel = new System.Windows.Forms.Label();
            this.PenButton = new System.Windows.Forms.Button();
            this.EraserButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.layersPanel = new System.Windows.Forms.Panel();
            this.btnLayerMoveDown = new System.Windows.Forms.Button();
            this.btnLayerMoveUp = new System.Windows.Forms.Button();
            this.btnLayerVisible = new System.Windows.Forms.Button();
            this.btnLayerRemove = new System.Windows.Forms.Button();
            this.btnLayerAdd = new System.Windows.Forms.Button();
            this.lstboxLayers = new System.Windows.Forms.ListBox();
            this.TopToolbarPanel = new System.Windows.Forms.Panel();
            this.LeftToolbarPanel = new System.Windows.Forms.Panel();
            this.PaintbrushButton = new System.Windows.Forms.Button();
            this.PencilButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.ToolOpacitySlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ToolSizeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ToolOpacityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ToolSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.layersPanel.SuspendLayout();
            this.LeftToolbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasPanel.BackColor = System.Drawing.Color.Transparent;
            this.CanvasPanel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.CanvasPanel.Location = new System.Drawing.Point(0, 0);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(602, 592);
            this.CanvasPanel.TabIndex = 4;
            this.CanvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CanvasPanel_Paint);
            this.CanvasPanel.Enter += new System.EventHandler(this.CanvasPanel_Enter);
            this.CanvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasPanel_MouseDown);
            this.CanvasPanel.MouseEnter += new System.EventHandler(this.CanvasPanel_MouseEnter);
            this.CanvasPanel.MouseLeave += new System.EventHandler(this.CanvasPanel_MouseLeave);
            this.CanvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasPanel_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem, this.editToolStripMenuItem, this.viewToolStripMenuItem, this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.newToolStripMenuItem, this.openToolStripMenuItem, this.saveToolStripMenuItem, this.saveAsToolStripMenuItem, this.exportToolStripMenuItem, this.importToolStripMenuItem, this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New...";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.bmpBMPToolStripMenuItem, this.jpgJPGToolStripMenuItem, this.pngPNGToolStripMenuItem, this.psdPhotoshopDocumentToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // bmpBMPToolStripMenuItem
            // 
            this.bmpBMPToolStripMenuItem.Name = "bmpBMPToolStripMenuItem";
            this.bmpBMPToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.bmpBMPToolStripMenuItem.Text = ".bmp (BMP)";
            this.bmpBMPToolStripMenuItem.Click += new System.EventHandler(this.bmpBMPToolStripMenuItem_Click);
            // 
            // jpgJPGToolStripMenuItem
            // 
            this.jpgJPGToolStripMenuItem.Name = "jpgJPGToolStripMenuItem";
            this.jpgJPGToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.jpgJPGToolStripMenuItem.Text = ".jpg (JPG)";
            this.jpgJPGToolStripMenuItem.Click += new System.EventHandler(this.jpgJPGToolStripMenuItem_Click);
            // 
            // pngPNGToolStripMenuItem
            // 
            this.pngPNGToolStripMenuItem.Name = "pngPNGToolStripMenuItem";
            this.pngPNGToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.pngPNGToolStripMenuItem.Text = ".png (PNG)";
            this.pngPNGToolStripMenuItem.Click += new System.EventHandler(this.pngPNGToolStripMenuItem_Click);
            // 
            // psdPhotoshopDocumentToolStripMenuItem
            // 
            this.psdPhotoshopDocumentToolStripMenuItem.Name = "psdPhotoshopDocumentToolStripMenuItem";
            this.psdPhotoshopDocumentToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.psdPhotoshopDocumentToolStripMenuItem.Text = ".psd (Photoshop Document)";
            this.psdPhotoshopDocumentToolStripMenuItem.Click += new System.EventHandler(this.psdPhotoshopDocumentToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.undoToolStripMenuItem, this.redoToolStripMenuItem, this.cutToolStripMenuItem, this.copyToolStripMenuItem, this.pasteToolStripMenuItem, this.transformToolStripMenuItem, this.changeCanvasSizeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // transformToolStripMenuItem
            // 
            this.transformToolStripMenuItem.Name = "transformToolStripMenuItem";
            this.transformToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.transformToolStripMenuItem.Text = "Transform";
            // 
            // changeCanvasSizeToolStripMenuItem
            // 
            this.changeCanvasSizeToolStripMenuItem.Name = "changeCanvasSizeToolStripMenuItem";
            this.changeCanvasSizeToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.changeCanvasSizeToolStripMenuItem.Text = "Change Canvas Size";
            this.changeCanvasSizeToolStripMenuItem.Click += new System.EventHandler(this.changeCanvasSizeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.zoomInToolStripMenuItem, this.zoomOutToolStripMenuItem, this.percentViewToolStripMenuItem, this.rotateToolStripMenuItem, this.flipHorizontallyToolStripMenuItem, this.flipVerticallyToolStripMenuItem, this.moveToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // percentViewToolStripMenuItem
            // 
            this.percentViewToolStripMenuItem.Name = "percentViewToolStripMenuItem";
            this.percentViewToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.percentViewToolStripMenuItem.Text = "100% View";
            this.percentViewToolStripMenuItem.Click += new System.EventHandler(this.percentViewToolStripMenuItem_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.resetRotationToolStripMenuItem, this.rotate90ToolStripMenuItem, this.rotate180ToolStripMenuItem, this.rotate90ToolStripMenuItem1});
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.rotateToolStripMenuItem.Text = "Rotate";
            // 
            // resetRotationToolStripMenuItem
            // 
            this.resetRotationToolStripMenuItem.Name = "resetRotationToolStripMenuItem";
            this.resetRotationToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.resetRotationToolStripMenuItem.Text = "Reset Rotation";
            this.resetRotationToolStripMenuItem.Click += new System.EventHandler(this.resetRotationToolStripMenuItem_Click);
            // 
            // rotate90ToolStripMenuItem
            // 
            this.rotate90ToolStripMenuItem.Name = "rotate90ToolStripMenuItem";
            this.rotate90ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.rotate90ToolStripMenuItem.Text = "Rotate +90°";
            this.rotate90ToolStripMenuItem.Click += new System.EventHandler(this.rotate90ToolStripMenuItem_Click);
            // 
            // rotate180ToolStripMenuItem
            // 
            this.rotate180ToolStripMenuItem.Name = "rotate180ToolStripMenuItem";
            this.rotate180ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.rotate180ToolStripMenuItem.Text = "Rotate +180°";
            this.rotate180ToolStripMenuItem.Click += new System.EventHandler(this.rotate180ToolStripMenuItem_Click);
            // 
            // rotate90ToolStripMenuItem1
            // 
            this.rotate90ToolStripMenuItem1.Name = "rotate90ToolStripMenuItem1";
            this.rotate90ToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.rotate90ToolStripMenuItem1.Text = "Rotate -90°";
            this.rotate90ToolStripMenuItem1.Click += new System.EventHandler(this.rotate90ToolStripMenuItem1_Click);
            // 
            // flipHorizontallyToolStripMenuItem
            // 
            this.flipHorizontallyToolStripMenuItem.Name = "flipHorizontallyToolStripMenuItem";
            this.flipHorizontallyToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.flipHorizontallyToolStripMenuItem.Text = "Flip Horizontally";
            this.flipHorizontallyToolStripMenuItem.Click += new System.EventHandler(this.flipHorizontallyToolStripMenuItem_Click);
            // 
            // flipVerticallyToolStripMenuItem
            // 
            this.flipVerticallyToolStripMenuItem.Name = "flipVerticallyToolStripMenuItem";
            this.flipVerticallyToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.flipVerticallyToolStripMenuItem.Text = "Flip Vertically";
            this.flipVerticallyToolStripMenuItem.Click += new System.EventHandler(this.flipVerticallyToolStripMenuItem_Click);
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.upToolStripMenuItem, this.downToolStripMenuItem, this.leftToolStripMenuItem, this.rightToolStripMenuItem});
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.moveToolStripMenuItem.Text = "Move";
            // 
            // upToolStripMenuItem
            // 
            this.upToolStripMenuItem.Name = "upToolStripMenuItem";
            this.upToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.upToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.upToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.upToolStripMenuItem.Text = "Up";
            this.upToolStripMenuItem.Click += new System.EventHandler(this.upToolStripMenuItem_Click);
            // 
            // downToolStripMenuItem
            // 
            this.downToolStripMenuItem.Name = "downToolStripMenuItem";
            this.downToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.downToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.downToolStripMenuItem.Text = "Down";
            this.downToolStripMenuItem.Click += new System.EventHandler(this.downToolStripMenuItem_Click);
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.leftToolStripMenuItem.Text = "Left";
            this.leftToolStripMenuItem.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.rightToolStripMenuItem.Text = "Right";
            this.rightToolStripMenuItem.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ToolOpacitySlider);
            this.panel1.Controls.Add(this.ToolSizeSlider);
            this.panel1.Controls.Add(this.ToolOpacityNumericUpDown);
            this.panel1.Controls.Add(this.OpacityLabel);
            this.panel1.Controls.Add(this.ToolSizeNumericUpDown);
            this.panel1.Controls.Add(this.SizeLabel);
            this.panel1.Controls.Add(this.ColourButton);
            this.panel1.Controls.Add(this.ColourLabel);
            this.panel1.Location = new System.Drawing.Point(-2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 161);
            this.panel1.TabIndex = 9;
            // 
            // ToolOpacitySlider
            // 
            this.ToolOpacitySlider.Location = new System.Drawing.Point(50, 75);
            this.ToolOpacitySlider.Maximum = 100;
            this.ToolOpacitySlider.Name = "ToolOpacitySlider";
            this.ToolOpacitySlider.Size = new System.Drawing.Size(104, 45);
            this.ToolOpacitySlider.TabIndex = 6;
            this.ToolOpacitySlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ToolOpacitySlider.Value = 100;
            this.ToolOpacitySlider.ValueChanged += new System.EventHandler(this.ToolOpacitySlider_ValueChanged);
            // 
            // ToolSizeSlider
            // 
            this.ToolSizeSlider.Location = new System.Drawing.Point(49, 47);
            this.ToolSizeSlider.Maximum = 100;
            this.ToolSizeSlider.Name = "ToolSizeSlider";
            this.ToolSizeSlider.Size = new System.Drawing.Size(104, 45);
            this.ToolSizeSlider.TabIndex = 5;
            this.ToolSizeSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ToolSizeSlider.Value = 10;
            this.ToolSizeSlider.ValueChanged += new System.EventHandler(this.ToolSizeSlider_ValueChanged);
            // 
            // ToolOpacityNumericUpDown
            // 
            this.ToolOpacityNumericUpDown.Location = new System.Drawing.Point(182, 77);
            this.ToolOpacityNumericUpDown.Name = "ToolOpacityNumericUpDown";
            this.ToolOpacityNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.ToolOpacityNumericUpDown.TabIndex = 4;
            this.ToolOpacityNumericUpDown.Value = new decimal(new int[] {100, 0, 0, 0});
            this.ToolOpacityNumericUpDown.ValueChanged += new System.EventHandler(this.ToolOpacityNumericUpDown_ValueChanged);
            // 
            // OpacityLabel
            // 
            this.OpacityLabel.AutoSize = true;
            this.OpacityLabel.Location = new System.Drawing.Point(8, 79);
            this.OpacityLabel.Name = "OpacityLabel";
            this.OpacityLabel.Size = new System.Drawing.Size(43, 13);
            this.OpacityLabel.TabIndex = 3;
            this.OpacityLabel.Text = "Opacity";
            // 
            // ToolSizeNumericUpDown
            // 
            this.ToolSizeNumericUpDown.Location = new System.Drawing.Point(181, 42);
            this.ToolSizeNumericUpDown.Name = "ToolSizeNumericUpDown";
            this.ToolSizeNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToolSizeNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.ToolSizeNumericUpDown.TabIndex = 2;
            this.ToolSizeNumericUpDown.Value = new decimal(new int[] {10, 0, 0, 0});
            this.ToolSizeNumericUpDown.ValueChanged += new System.EventHandler(this.ToolSizeNumericUpDown_ValueChanged);
            // 
            // SizeLabel
            // 
            this.SizeLabel.Location = new System.Drawing.Point(7, 47);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(35, 13);
            this.SizeLabel.TabIndex = 0;
            this.SizeLabel.Text = "Size";
            // 
            // ColourButton
            // 
            this.ColourButton.Location = new System.Drawing.Point(50, 13);
            this.ColourButton.Name = "ColourButton";
            this.ColourButton.Size = new System.Drawing.Size(75, 23);
            this.ColourButton.TabIndex = 1;
            this.ColourButton.UseVisualStyleBackColor = true;
            this.ColourButton.Click += new System.EventHandler(this.ColourButton_Click);
            // 
            // ColourLabel
            // 
            this.ColourLabel.AutoSize = true;
            this.ColourLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ColourLabel.Location = new System.Drawing.Point(7, 18);
            this.ColourLabel.Name = "ColourLabel";
            this.ColourLabel.Size = new System.Drawing.Size(37, 13);
            this.ColourLabel.TabIndex = 0;
            this.ColourLabel.Text = "Colour";
            // 
            // PenButton
            // 
            this.PenButton.BackColor = System.Drawing.Color.Transparent;
            this.PenButton.FlatAppearance.BorderSize = 0;
            this.PenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PenButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PenButton.Location = new System.Drawing.Point(0, 4);
            this.PenButton.Name = "PenButton";
            this.PenButton.Size = new System.Drawing.Size(37, 31);
            this.PenButton.TabIndex = 2;
            this.PenButton.UseVisualStyleBackColor = false;
            this.PenButton.Click += new System.EventHandler(this.PenButton_Click);
            // 
            // EraserButton
            // 
            this.EraserButton.BackColor = System.Drawing.Color.Transparent;
            this.EraserButton.FlatAppearance.BorderSize = 0;
            this.EraserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EraserButton.ForeColor = System.Drawing.SystemColors.Control;
            this.EraserButton.Location = new System.Drawing.Point(0, 117);
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Size = new System.Drawing.Size(37, 32);
            this.EraserButton.TabIndex = 3;
            this.EraserButton.UseVisualStyleBackColor = false;
            this.EraserButton.Click += new System.EventHandler(this.EraserButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(39, 51);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Panel1.Controls.Add(this.CanvasPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(865, 592);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 10;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(4, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.layersPanel);
            this.splitContainer2.Size = new System.Drawing.Size(282, 590);
            this.splitContainer2.SplitterDistance = 164;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 11;
            // 
            // layersPanel
            // 
            this.layersPanel.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.layersPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.layersPanel.Controls.Add(this.btnLayerMoveDown);
            this.layersPanel.Controls.Add(this.btnLayerMoveUp);
            this.layersPanel.Controls.Add(this.btnLayerVisible);
            this.layersPanel.Controls.Add(this.btnLayerRemove);
            this.layersPanel.Controls.Add(this.btnLayerAdd);
            this.layersPanel.Controls.Add(this.lstboxLayers);
            this.layersPanel.Location = new System.Drawing.Point(-2, 2);
            this.layersPanel.Margin = new System.Windows.Forms.Padding(2);
            this.layersPanel.Name = "layersPanel";
            this.layersPanel.Size = new System.Drawing.Size(284, 456);
            this.layersPanel.TabIndex = 10;
            // 
            // btnLayerMoveDown
            // 
            this.btnLayerMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLayerMoveDown.ForeColor = System.Drawing.Color.Black;
            this.btnLayerMoveDown.Location = new System.Drawing.Point(213, 106);
            this.btnLayerMoveDown.Name = "btnLayerMoveDown";
            this.btnLayerMoveDown.Size = new System.Drawing.Size(47, 23);
            this.btnLayerMoveDown.TabIndex = 5;
            this.btnLayerMoveDown.Text = "Down";
            this.btnLayerMoveDown.UseVisualStyleBackColor = true;
            this.btnLayerMoveDown.Click += new System.EventHandler(this.btnLayerMoveDown_Click);
            // 
            // btnLayerMoveUp
            // 
            this.btnLayerMoveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLayerMoveUp.ForeColor = System.Drawing.Color.Black;
            this.btnLayerMoveUp.Location = new System.Drawing.Point(160, 106);
            this.btnLayerMoveUp.Name = "btnLayerMoveUp";
            this.btnLayerMoveUp.Size = new System.Drawing.Size(47, 23);
            this.btnLayerMoveUp.TabIndex = 4;
            this.btnLayerMoveUp.Text = "Up";
            this.btnLayerMoveUp.UseVisualStyleBackColor = true;
            this.btnLayerMoveUp.Click += new System.EventHandler(this.btnLayerMoveUp_Click);
            // 
            // btnLayerVisible
            // 
            this.btnLayerVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLayerVisible.ForeColor = System.Drawing.Color.Black;
            this.btnLayerVisible.Location = new System.Drawing.Point(160, 77);
            this.btnLayerVisible.Name = "btnLayerVisible";
            this.btnLayerVisible.Size = new System.Drawing.Size(100, 23);
            this.btnLayerVisible.TabIndex = 3;
            this.btnLayerVisible.Text = "Visible: True";
            this.btnLayerVisible.UseVisualStyleBackColor = true;
            this.btnLayerVisible.Click += new System.EventHandler(this.btnLayerVisible_Click);
            // 
            // btnLayerRemove
            // 
            this.btnLayerRemove.ForeColor = System.Drawing.Color.Black;
            this.btnLayerRemove.Location = new System.Drawing.Point(160, 48);
            this.btnLayerRemove.Name = "btnLayerRemove";
            this.btnLayerRemove.Size = new System.Drawing.Size(100, 23);
            this.btnLayerRemove.TabIndex = 2;
            this.btnLayerRemove.Text = "Remove layer";
            this.btnLayerRemove.UseVisualStyleBackColor = true;
            this.btnLayerRemove.Click += new System.EventHandler(this.btnLayerRemove_Click);
            // 
            // btnLayerAdd
            // 
            this.btnLayerAdd.ForeColor = System.Drawing.Color.Black;
            this.btnLayerAdd.Location = new System.Drawing.Point(160, 19);
            this.btnLayerAdd.Name = "btnLayerAdd";
            this.btnLayerAdd.Size = new System.Drawing.Size(100, 23);
            this.btnLayerAdd.TabIndex = 1;
            this.btnLayerAdd.Text = "Add layer";
            this.btnLayerAdd.UseVisualStyleBackColor = true;
            this.btnLayerAdd.Click += new System.EventHandler(this.btnLayerAdd_Click);
            // 
            // lstboxLayers
            // 
            this.lstboxLayers.FormattingEnabled = true;
            this.lstboxLayers.Location = new System.Drawing.Point(21, 19);
            this.lstboxLayers.Name = "lstboxLayers";
            this.lstboxLayers.Size = new System.Drawing.Size(133, 290);
            this.lstboxLayers.TabIndex = 0;
            this.lstboxLayers.SelectedIndexChanged += new System.EventHandler(this.lstboxLayers_SelectedIndexChanged);
            // 
            // TopToolbarPanel
            // 
            this.TopToolbarPanel.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.TopToolbarPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.TopToolbarPanel.Location = new System.Drawing.Point(0, 22);
            this.TopToolbarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TopToolbarPanel.Name = "TopToolbarPanel";
            this.TopToolbarPanel.Size = new System.Drawing.Size(904, 28);
            this.TopToolbarPanel.TabIndex = 11;
            // 
            // LeftToolbarPanel
            // 
            this.LeftToolbarPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.LeftToolbarPanel.Controls.Add(this.PaintbrushButton);
            this.LeftToolbarPanel.Controls.Add(this.PencilButton);
            this.LeftToolbarPanel.Controls.Add(this.PenButton);
            this.LeftToolbarPanel.Controls.Add(this.EraserButton);
            this.LeftToolbarPanel.Location = new System.Drawing.Point(0, 51);
            this.LeftToolbarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LeftToolbarPanel.Name = "LeftToolbarPanel";
            this.LeftToolbarPanel.Size = new System.Drawing.Size(37, 592);
            this.LeftToolbarPanel.TabIndex = 12;
            // 
            // PaintbrushButton
            // 
            this.PaintbrushButton.BackColor = System.Drawing.Color.Transparent;
            this.PaintbrushButton.FlatAppearance.BorderSize = 0;
            this.PaintbrushButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PaintbrushButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PaintbrushButton.Location = new System.Drawing.Point(0, 79);
            this.PaintbrushButton.Name = "PaintbrushButton";
            this.PaintbrushButton.Size = new System.Drawing.Size(37, 32);
            this.PaintbrushButton.TabIndex = 5;
            this.PaintbrushButton.UseVisualStyleBackColor = false;
            this.PaintbrushButton.Click += new System.EventHandler(this.PaintbrushButton_Click);
            // 
            // PencilButton
            // 
            this.PencilButton.BackColor = System.Drawing.Color.Transparent;
            this.PencilButton.FlatAppearance.BorderSize = 0;
            this.PencilButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PencilButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PencilButton.Location = new System.Drawing.Point(0, 41);
            this.PencilButton.Name = "PencilButton";
            this.PencilButton.Size = new System.Drawing.Size(37, 32);
            this.PencilButton.TabIndex = 4;
            this.PencilButton.UseVisualStyleBackColor = false;
            this.PencilButton.Click += new System.EventHandler(this.PencilButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(904, 643);
            this.Controls.Add(this.LeftToolbarPanel);
            this.Controls.Add(this.TopToolbarPanel);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Digital Canvas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.ToolOpacitySlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ToolSizeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ToolOpacityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ToolSizeNumericUpDown)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.layersPanel.ResumeLayout(false);
            this.LeftToolbarPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnLayerMoveDown;
        private System.Windows.Forms.Button btnLayerMoveUp;

        private System.Windows.Forms.Button btnLayerVisible;

        private System.Windows.Forms.Button btnLayerAdd;
        private System.Windows.Forms.Button btnLayerRemove;

        private System.Windows.Forms.ListBox lstboxLayers;

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Panel CanvasPanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem bmpBMPToolStripMenuItem;
        private ToolStripMenuItem jpgJPGToolStripMenuItem;
        private ToolStripMenuItem pngPNGToolStripMenuItem;
        private ToolStripMenuItem psdPhotoshopDocumentToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem transformToolStripMenuItem;
        private ToolStripMenuItem changeCanvasSizeToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem percentViewToolStripMenuItem;
        private ToolStripMenuItem rotateToolStripMenuItem;
        private ToolStripMenuItem resetRotationToolStripMenuItem;
        private ToolStripMenuItem rotate90ToolStripMenuItem;
        private ToolStripMenuItem rotate180ToolStripMenuItem;
        private ToolStripMenuItem rotate90ToolStripMenuItem1;
        private ToolStripMenuItem flipHorizontallyToolStripMenuItem;
        private ToolStripMenuItem flipVerticallyToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Panel panel1;
        private Button ColourButton;
        private Label ColourLabel;
        private Button PenButton;
        private Button EraserButton;
        private SplitContainer splitContainer1;
        private Panel TopToolbarPanel;
        private Panel LeftToolbarPanel;
        private SplitContainer splitContainer2;
        private Panel layersPanel;
        private Button PaintbrushButton;
        private Button PencilButton;
        private NumericUpDown ToolSizeNumericUpDown;
        private Label SizeLabel;
        private NumericUpDown ToolOpacityNumericUpDown;
        private Label OpacityLabel;
        private TrackBar ToolSizeSlider;
        private TrackBar ToolOpacitySlider;
        private ToolStripMenuItem moveToolStripMenuItem;
        private ToolStripMenuItem upToolStripMenuItem;
        private ToolStripMenuItem downToolStripMenuItem;
        private ToolStripMenuItem leftToolStripMenuItem;
        private ToolStripMenuItem rightToolStripMenuItem;
    }
}

