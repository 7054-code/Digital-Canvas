
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
            this.TopToolbarPanel = new System.Windows.Forms.Panel();
            this.LeftToolbarPanel = new System.Windows.Forms.Panel();
            this.PaintbrushButton = new System.Windows.Forms.Button();
            this.PencilButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToolOpacitySlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolSizeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolOpacityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolSizeNumericUpDown)).BeginInit();
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
            this.CanvasPanel.Location = new System.Drawing.Point(79, 88);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(461, 378);
            this.CanvasPanel.TabIndex = 4;
            this.CanvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasPanel_MouseDown);
            this.CanvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasPanel_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.newToolStripMenuItem.Text = "New...";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
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
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // bmpBMPToolStripMenuItem
            // 
            this.bmpBMPToolStripMenuItem.Name = "bmpBMPToolStripMenuItem";
            this.bmpBMPToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.bmpBMPToolStripMenuItem.Text = ".bmp (BMP)";
            this.bmpBMPToolStripMenuItem.Click += new System.EventHandler(this.bmpBMPToolStripMenuItem_Click);
            // 
            // jpgJPGToolStripMenuItem
            // 
            this.jpgJPGToolStripMenuItem.Name = "jpgJPGToolStripMenuItem";
            this.jpgJPGToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.jpgJPGToolStripMenuItem.Text = ".jpg (JPG)";
            this.jpgJPGToolStripMenuItem.Click += new System.EventHandler(this.jpgJPGToolStripMenuItem_Click);
            // 
            // pngPNGToolStripMenuItem
            // 
            this.pngPNGToolStripMenuItem.Name = "pngPNGToolStripMenuItem";
            this.pngPNGToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.pngPNGToolStripMenuItem.Text = ".png (PNG)";
            this.pngPNGToolStripMenuItem.Click += new System.EventHandler(this.pngPNGToolStripMenuItem_Click);
            // 
            // psdPhotoshopDocumentToolStripMenuItem
            // 
            this.psdPhotoshopDocumentToolStripMenuItem.Name = "psdPhotoshopDocumentToolStripMenuItem";
            this.psdPhotoshopDocumentToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.psdPhotoshopDocumentToolStripMenuItem.Text = ".psd (Photoshop Document)";
            this.psdPhotoshopDocumentToolStripMenuItem.Click += new System.EventHandler(this.psdPhotoshopDocumentToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
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
            this.editToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // transformToolStripMenuItem
            // 
            this.transformToolStripMenuItem.Name = "transformToolStripMenuItem";
            this.transformToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.transformToolStripMenuItem.Text = "Transform";
            // 
            // changeCanvasSizeToolStripMenuItem
            // 
            this.changeCanvasSizeToolStripMenuItem.Name = "changeCanvasSizeToolStripMenuItem";
            this.changeCanvasSizeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
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
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
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
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.rotateToolStripMenuItem.Text = "Rotate";
            // 
            // resetRotationToolStripMenuItem
            // 
            this.resetRotationToolStripMenuItem.Name = "resetRotationToolStripMenuItem";
            this.resetRotationToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.resetRotationToolStripMenuItem.Text = "Reset Rotation";
            // 
            // rotate90ToolStripMenuItem
            // 
            this.rotate90ToolStripMenuItem.Name = "rotate90ToolStripMenuItem";
            this.rotate90ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.rotate90ToolStripMenuItem.Text = "Rotate +90°";
            // 
            // rotate180ToolStripMenuItem
            // 
            this.rotate180ToolStripMenuItem.Name = "rotate180ToolStripMenuItem";
            this.rotate180ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.rotate180ToolStripMenuItem.Text = "Rotate +180°";
            // 
            // rotate90ToolStripMenuItem1
            // 
            this.rotate90ToolStripMenuItem1.Name = "rotate90ToolStripMenuItem1";
            this.rotate90ToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.rotate90ToolStripMenuItem1.Text = "Rotate -90°";
            // 
            // rotate180ToolStripMenuItem1
            // 
            this.rotate180ToolStripMenuItem1.Name = "rotate180ToolStripMenuItem1";
            this.rotate180ToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.rotate180ToolStripMenuItem1.Text = "Rotate -180°";
            // 
            // rotateLeftToolStripMenuItem
            // 
            this.rotateLeftToolStripMenuItem.Name = "rotateLeftToolStripMenuItem";
            this.rotateLeftToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.rotateLeftToolStripMenuItem.Text = "Rotate Left";
            // 
            // rotateRightToolStripMenuItem
            // 
            this.rotateRightToolStripMenuItem.Name = "rotateRightToolStripMenuItem";
            this.rotateRightToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.rotateRightToolStripMenuItem.Text = "Rotate Right";
            // 
            // flipHorizontallyToolStripMenuItem
            // 
            this.flipHorizontallyToolStripMenuItem.Name = "flipHorizontallyToolStripMenuItem";
            this.flipHorizontallyToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.flipHorizontallyToolStripMenuItem.Text = "Flip Horizontally";
            // 
            // flipVerticallyToolStripMenuItem
            // 
            this.flipVerticallyToolStripMenuItem.Name = "flipVerticallyToolStripMenuItem";
            this.flipVerticallyToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.flipVerticallyToolStripMenuItem.Text = "Flip Vertically";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.ToolOpacityNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
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
            this.ToolSizeNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
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
            this.PenButton.Image = global::Digital_Canvas.Properties.Resources.penIcon;
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
            this.EraserButton.Image = global::Digital_Canvas.Properties.Resources.eraserIcon;
            this.EraserButton.Location = new System.Drawing.Point(0, 117);
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Size = new System.Drawing.Size(37, 32);
            this.EraserButton.TabIndex = 3;
            this.EraserButton.UseVisualStyleBackColor = false;
            this.EraserButton.Click += new System.EventHandler(this.EraserButton_Click);
            // 
            // splitContainer1
            // 
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
            this.splitContainer1.SplitterDistance = 574;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 10;
            // 
            // splitContainer2
            // 
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
            this.layersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.layersPanel.Location = new System.Drawing.Point(-2, 2);
            this.layersPanel.Margin = new System.Windows.Forms.Padding(2);
            this.layersPanel.Name = "layersPanel";
            this.layersPanel.Size = new System.Drawing.Size(284, 430);
            this.layersPanel.TabIndex = 10;
            // 
            // TopToolbarPanel
            // 
            this.TopToolbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TopToolbarPanel.Location = new System.Drawing.Point(0, 22);
            this.TopToolbarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TopToolbarPanel.Name = "TopToolbarPanel";
            this.TopToolbarPanel.Size = new System.Drawing.Size(904, 28);
            this.TopToolbarPanel.TabIndex = 11;
            // 
            // LeftToolbarPanel
            // 
            this.LeftToolbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Digital Canvas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToolOpacitySlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolSizeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolOpacityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolSizeNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Button PaintbrushButton;
        private System.Windows.Forms.Button PencilButton;
        private System.Windows.Forms.NumericUpDown ToolSizeNumericUpDown;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.NumericUpDown ToolOpacityNumericUpDown;
        private System.Windows.Forms.Label OpacityLabel;
        private System.Windows.Forms.TrackBar ToolSizeSlider;
        private System.Windows.Forms.TrackBar ToolOpacitySlider;
    }
}

