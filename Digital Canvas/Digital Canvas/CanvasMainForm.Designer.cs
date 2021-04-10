
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
            this.components = new System.ComponentModel.Container();
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
            this.instructionManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToolOpacitySlider = new System.Windows.Forms.TrackBar();
            this.ToolSizeSlider = new System.Windows.Forms.TrackBar();
            this.ToolOpacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OpacityLabel = new System.Windows.Forms.Label();
            this.ToolSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.ColourButton = new System.Windows.Forms.Button();
            this.ColourLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.layersPanel = new System.Windows.Forms.Panel();
            this.btnLayersVisible = new System.Windows.Forms.Button();
            this.btnLayersMoveDown = new System.Windows.Forms.Button();
            this.btnLayersMoveUp = new System.Windows.Forms.Button();
            this.btnLayersRemove = new System.Windows.Forms.Button();
            this.btnLayersAdd = new System.Windows.Forms.Button();
            this.lstboxLayers = new System.Windows.Forms.ListBox();
            this.TopToolbarPanel = new System.Windows.Forms.Panel();
            this.FlipVerticallyButton = new System.Windows.Forms.Button();
            this.FlipHorizontallyButton = new System.Windows.Forms.Button();
            this.ZoomInButton = new System.Windows.Forms.Button();
            this.ZoomOutButton = new System.Windows.Forms.Button();
            this.RotateRightButton = new System.Windows.Forms.Button();
            this.RotateLeftButton = new System.Windows.Forms.Button();
            this.RedoButton = new System.Windows.Forms.Button();
            this.UndoButton = new System.Windows.Forms.Button();
            this.YPositionLabel = new System.Windows.Forms.Label();
            this.XPositionLabel = new System.Windows.Forms.Label();
            this.LeftToolbarPanel = new System.Windows.Forms.Panel();
            this.TransformResizeButton = new System.Windows.Forms.Button();
            this.TransformRotateButton = new System.Windows.Forms.Button();
            this.SelectFlipVerticalButton = new System.Windows.Forms.Button();
            this.SelectFlipHorizontalButton = new System.Windows.Forms.Button();
            this.DeselectButton = new System.Windows.Forms.Button();
            this.SelectionButton = new System.Windows.Forms.Button();
            this.FillButton = new System.Windows.Forms.Button();
            this.TextButton = new System.Windows.Forms.Button();
            this.EyedropperButton = new System.Windows.Forms.Button();
            this.PaintbrushButton = new System.Windows.Forms.Button();
            this.PencilButton = new System.Windows.Forms.Button();
            this.PenButton = new System.Windows.Forms.Button();
            this.EraserButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.TopToolbarPanel.SuspendLayout();
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
            this.CanvasPanel.Size = new System.Drawing.Size(608, 586);
            this.CanvasPanel.TabIndex = 4;
            this.CanvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CanvasPanel_Paint);
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
            this.newToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.newToolStripMenuItem.Text = "New...";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.bmpBMPToolStripMenuItem, this.jpgJPGToolStripMenuItem, this.pngPNGToolStripMenuItem, this.psdPhotoshopDocumentToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
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
            this.importToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
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
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
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
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.instructionManualToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionManualToolStripMenuItem
            // 
            this.instructionManualToolStripMenuItem.Name = "instructionManualToolStripMenuItem";
            this.instructionManualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.instructionManualToolStripMenuItem.Text = "Instruction Manual";
            this.instructionManualToolStripMenuItem.Click += new System.EventHandler(this.instructionManualToolStripMenuItem_Click);
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
            this.panel1.Size = new System.Drawing.Size(287, 160);
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
            this.ToolOpacityNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.ToolSizeNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.splitContainer1.Size = new System.Drawing.Size(865, 589);
            this.splitContainer1.SplitterDistance = 607;
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
            this.splitContainer2.SplitterDistance = 163;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 11;
            // 
            // layersPanel
            // 
            this.layersPanel.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.layersPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.layersPanel.Controls.Add(this.btnLayersVisible);
            this.layersPanel.Controls.Add(this.btnLayersMoveDown);
            this.layersPanel.Controls.Add(this.btnLayersMoveUp);
            this.layersPanel.Controls.Add(this.btnLayersRemove);
            this.layersPanel.Controls.Add(this.btnLayersAdd);
            this.layersPanel.Controls.Add(this.lstboxLayers);
            this.layersPanel.Location = new System.Drawing.Point(-2, 2);
            this.layersPanel.Margin = new System.Windows.Forms.Padding(2);
            this.layersPanel.Name = "layersPanel";
            this.layersPanel.Size = new System.Drawing.Size(284, 462);
            this.layersPanel.TabIndex = 10;
            // 
            // btnLayersVisible
            // 
            this.btnLayersVisible.BackColor = System.Drawing.Color.Transparent;
            this.btnLayersVisible.BackgroundImage = global::Digital_Canvas.Properties.Resources.hideLayerIcon;
            this.btnLayersVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLayersVisible.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLayersVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLayersVisible.ForeColor = System.Drawing.Color.Transparent;
            this.btnLayersVisible.Location = new System.Drawing.Point(216, 3);
            this.btnLayersVisible.Name = "btnLayersVisible";
            this.btnLayersVisible.Size = new System.Drawing.Size(34, 32);
            this.btnLayersVisible.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnLayersVisible, "Hide/show layer");
            this.btnLayersVisible.UseVisualStyleBackColor = false;
            this.btnLayersVisible.Click += new System.EventHandler(this.btnLayersVisible_Click);
            // 
            // btnLayersMoveDown
            // 
            this.btnLayersMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLayersMoveDown.ForeColor = System.Drawing.Color.Black;
            this.btnLayersMoveDown.Location = new System.Drawing.Point(194, 41);
            this.btnLayersMoveDown.Name = "btnLayersMoveDown";
            this.btnLayersMoveDown.Size = new System.Drawing.Size(56, 23);
            this.btnLayersMoveDown.TabIndex = 9;
            this.btnLayersMoveDown.Text = "Down";
            this.toolTip1.SetToolTip(this.btnLayersMoveDown, "Move layer down");
            this.btnLayersMoveDown.UseVisualStyleBackColor = true;
            this.btnLayersMoveDown.Click += new System.EventHandler(this.btnLayersMoveDown_Click);
            // 
            // btnLayersMoveUp
            // 
            this.btnLayersMoveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLayersMoveUp.ForeColor = System.Drawing.Color.Black;
            this.btnLayersMoveUp.Location = new System.Drawing.Point(135, 41);
            this.btnLayersMoveUp.Name = "btnLayersMoveUp";
            this.btnLayersMoveUp.Size = new System.Drawing.Size(56, 23);
            this.btnLayersMoveUp.TabIndex = 8;
            this.btnLayersMoveUp.Text = "Up";
            this.toolTip1.SetToolTip(this.btnLayersMoveUp, "Move layer up");
            this.btnLayersMoveUp.UseVisualStyleBackColor = true;
            this.btnLayersMoveUp.Click += new System.EventHandler(this.btnLayersMoveUp_Click);
            // 
            // btnLayersRemove
            // 
            this.btnLayersRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnLayersRemove.BackgroundImage = global::Digital_Canvas.Properties.Resources.deleteLayerIcon;
            this.btnLayersRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLayersRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLayersRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLayersRemove.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLayersRemove.Location = new System.Drawing.Point(175, 0);
            this.btnLayersRemove.Name = "btnLayersRemove";
            this.btnLayersRemove.Size = new System.Drawing.Size(32, 32);
            this.btnLayersRemove.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnLayersRemove, "Delete layer");
            this.btnLayersRemove.UseVisualStyleBackColor = false;
            this.btnLayersRemove.Click += new System.EventHandler(this.btnLayersRemove_Click);
            // 
            // btnLayersAdd
            // 
            this.btnLayersAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnLayersAdd.BackgroundImage = global::Digital_Canvas.Properties.Resources.addLayerIcon;
            this.btnLayersAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLayersAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLayersAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLayersAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLayersAdd.Location = new System.Drawing.Point(135, 1);
            this.btnLayersAdd.Name = "btnLayersAdd";
            this.btnLayersAdd.Size = new System.Drawing.Size(34, 34);
            this.btnLayersAdd.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnLayersAdd, "Add layer");
            this.btnLayersAdd.UseVisualStyleBackColor = false;
            this.btnLayersAdd.Click += new System.EventHandler(this.btnLayersAdd_Click);
            // 
            // lstboxLayers
            // 
            this.lstboxLayers.FormattingEnabled = true;
            this.lstboxLayers.Location = new System.Drawing.Point(9, 3);
            this.lstboxLayers.Name = "lstboxLayers";
            this.lstboxLayers.Size = new System.Drawing.Size(120, 108);
            this.lstboxLayers.TabIndex = 1;
            this.toolTip1.SetToolTip(this.lstboxLayers, "Each layer is independant and has it\'s own canvas");
            this.lstboxLayers.SelectedIndexChanged += new System.EventHandler(this.lstboxLayers_SelectedIndexChanged);
            // 
            // TopToolbarPanel
            // 
            this.TopToolbarPanel.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.TopToolbarPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.TopToolbarPanel.Controls.Add(this.FlipVerticallyButton);
            this.TopToolbarPanel.Controls.Add(this.FlipHorizontallyButton);
            this.TopToolbarPanel.Controls.Add(this.ZoomInButton);
            this.TopToolbarPanel.Controls.Add(this.ZoomOutButton);
            this.TopToolbarPanel.Controls.Add(this.RotateRightButton);
            this.TopToolbarPanel.Controls.Add(this.RotateLeftButton);
            this.TopToolbarPanel.Controls.Add(this.RedoButton);
            this.TopToolbarPanel.Controls.Add(this.UndoButton);
            this.TopToolbarPanel.Controls.Add(this.YPositionLabel);
            this.TopToolbarPanel.Controls.Add(this.XPositionLabel);
            this.TopToolbarPanel.Location = new System.Drawing.Point(0, 22);
            this.TopToolbarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TopToolbarPanel.Name = "TopToolbarPanel";
            this.TopToolbarPanel.Size = new System.Drawing.Size(904, 28);
            this.TopToolbarPanel.TabIndex = 11;
            // 
            // FlipVerticallyButton
            // 
            this.FlipVerticallyButton.BackColor = System.Drawing.Color.Transparent;
            this.FlipVerticallyButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.flipVerticallyIcon;
            this.FlipVerticallyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FlipVerticallyButton.FlatAppearance.BorderSize = 0;
            this.FlipVerticallyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FlipVerticallyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FlipVerticallyButton.Location = new System.Drawing.Point(278, 0);
            this.FlipVerticallyButton.Name = "FlipVerticallyButton";
            this.FlipVerticallyButton.Size = new System.Drawing.Size(28, 28);
            this.FlipVerticallyButton.TabIndex = 16;
            this.toolTip1.SetToolTip(this.FlipVerticallyButton, "Flip Vertically");
            this.FlipVerticallyButton.UseVisualStyleBackColor = false;
            this.FlipVerticallyButton.Click += new System.EventHandler(this.FlipVerticallyButton_Click);
            // 
            // FlipHorizontallyButton
            // 
            this.FlipHorizontallyButton.BackColor = System.Drawing.Color.Transparent;
            this.FlipHorizontallyButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.flipHorizontallyIcon;
            this.FlipHorizontallyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FlipHorizontallyButton.FlatAppearance.BorderSize = 0;
            this.FlipHorizontallyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FlipHorizontallyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FlipHorizontallyButton.Location = new System.Drawing.Point(244, 0);
            this.FlipHorizontallyButton.Name = "FlipHorizontallyButton";
            this.FlipHorizontallyButton.Size = new System.Drawing.Size(28, 28);
            this.FlipHorizontallyButton.TabIndex = 15;
            this.toolTip1.SetToolTip(this.FlipHorizontallyButton, "Flip Horizontally");
            this.FlipHorizontallyButton.UseVisualStyleBackColor = false;
            this.FlipHorizontallyButton.Click += new System.EventHandler(this.FlipHorizontallyButton_Click);
            // 
            // ZoomInButton
            // 
            this.ZoomInButton.BackColor = System.Drawing.Color.Transparent;
            this.ZoomInButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.zoomInIcon;
            this.ZoomInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ZoomInButton.FlatAppearance.BorderSize = 0;
            this.ZoomInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ZoomInButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ZoomInButton.Location = new System.Drawing.Point(210, 0);
            this.ZoomInButton.Name = "ZoomInButton";
            this.ZoomInButton.Size = new System.Drawing.Size(28, 28);
            this.ZoomInButton.TabIndex = 14;
            this.toolTip1.SetToolTip(this.ZoomInButton, "Zoom In");
            this.ZoomInButton.UseVisualStyleBackColor = false;
            this.ZoomInButton.Click += new System.EventHandler(this.ZoomInButton_Click);
            // 
            // ZoomOutButton
            // 
            this.ZoomOutButton.BackColor = System.Drawing.Color.Transparent;
            this.ZoomOutButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.zoomOutIcon;
            this.ZoomOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ZoomOutButton.FlatAppearance.BorderSize = 0;
            this.ZoomOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ZoomOutButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ZoomOutButton.Location = new System.Drawing.Point(176, 0);
            this.ZoomOutButton.Name = "ZoomOutButton";
            this.ZoomOutButton.Size = new System.Drawing.Size(28, 28);
            this.ZoomOutButton.TabIndex = 13;
            this.toolTip1.SetToolTip(this.ZoomOutButton, "Zoom Out");
            this.ZoomOutButton.UseVisualStyleBackColor = false;
            this.ZoomOutButton.Click += new System.EventHandler(this.ZoomOutButton_Click);
            // 
            // RotateRightButton
            // 
            this.RotateRightButton.BackColor = System.Drawing.Color.Transparent;
            this.RotateRightButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.rotateRightIcon;
            this.RotateRightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RotateRightButton.FlatAppearance.BorderSize = 0;
            this.RotateRightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RotateRightButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RotateRightButton.Location = new System.Drawing.Point(142, 0);
            this.RotateRightButton.Name = "RotateRightButton";
            this.RotateRightButton.Size = new System.Drawing.Size(28, 28);
            this.RotateRightButton.TabIndex = 12;
            this.toolTip1.SetToolTip(this.RotateRightButton, "Rotate Right");
            this.RotateRightButton.UseVisualStyleBackColor = false;
            this.RotateRightButton.Click += new System.EventHandler(this.RotateRightButton_Click);
            // 
            // RotateLeftButton
            // 
            this.RotateLeftButton.BackColor = System.Drawing.Color.Transparent;
            this.RotateLeftButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.rotateLeftIcon;
            this.RotateLeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RotateLeftButton.FlatAppearance.BorderSize = 0;
            this.RotateLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RotateLeftButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RotateLeftButton.Location = new System.Drawing.Point(108, 0);
            this.RotateLeftButton.Name = "RotateLeftButton";
            this.RotateLeftButton.Size = new System.Drawing.Size(28, 28);
            this.RotateLeftButton.TabIndex = 11;
            this.toolTip1.SetToolTip(this.RotateLeftButton, "Rotate Left");
            this.RotateLeftButton.UseVisualStyleBackColor = false;
            this.RotateLeftButton.Click += new System.EventHandler(this.RotateLeftButton_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.BackColor = System.Drawing.Color.Transparent;
            this.RedoButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.redoIcon;
            this.RedoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RedoButton.FlatAppearance.BorderSize = 0;
            this.RedoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RedoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RedoButton.Location = new System.Drawing.Point(74, 0);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(28, 28);
            this.RedoButton.TabIndex = 10;
            this.toolTip1.SetToolTip(this.RedoButton, "Redo");
            this.RedoButton.UseVisualStyleBackColor = false;
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.BackColor = System.Drawing.Color.Transparent;
            this.UndoButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.undoIcon;
            this.UndoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UndoButton.FlatAppearance.BorderSize = 0;
            this.UndoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UndoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.UndoButton.Location = new System.Drawing.Point(40, 0);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(28, 28);
            this.UndoButton.TabIndex = 9;
            this.toolTip1.SetToolTip(this.UndoButton, "Undo");
            this.UndoButton.UseVisualStyleBackColor = false;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // YPositionLabel
            // 
            this.YPositionLabel.AutoSize = true;
            this.YPositionLabel.Location = new System.Drawing.Point(842, 9);
            this.YPositionLabel.Name = "YPositionLabel";
            this.YPositionLabel.Size = new System.Drawing.Size(20, 13);
            this.YPositionLabel.TabIndex = 1;
            this.YPositionLabel.Text = "Y: ";
            // 
            // XPositionLabel
            // 
            this.XPositionLabel.AutoSize = true;
            this.XPositionLabel.Location = new System.Drawing.Point(796, 9);
            this.XPositionLabel.Name = "XPositionLabel";
            this.XPositionLabel.Size = new System.Drawing.Size(20, 13);
            this.XPositionLabel.TabIndex = 0;
            this.XPositionLabel.Text = "X: ";
            // 
            // LeftToolbarPanel
            // 
            this.LeftToolbarPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.LeftToolbarPanel.Controls.Add(this.TransformResizeButton);
            this.LeftToolbarPanel.Controls.Add(this.TransformRotateButton);
            this.LeftToolbarPanel.Controls.Add(this.SelectFlipVerticalButton);
            this.LeftToolbarPanel.Controls.Add(this.SelectFlipHorizontalButton);
            this.LeftToolbarPanel.Controls.Add(this.DeselectButton);
            this.LeftToolbarPanel.Controls.Add(this.SelectionButton);
            this.LeftToolbarPanel.Controls.Add(this.FillButton);
            this.LeftToolbarPanel.Controls.Add(this.TextButton);
            this.LeftToolbarPanel.Controls.Add(this.EyedropperButton);
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
            // TransformResizeButton
            // 
            this.TransformResizeButton.BackColor = System.Drawing.Color.Transparent;
            this.TransformResizeButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.transformIcon;
            this.TransformResizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TransformResizeButton.FlatAppearance.BorderSize = 0;
            this.TransformResizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TransformResizeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.TransformResizeButton.Location = new System.Drawing.Point(2, 422);
            this.TransformResizeButton.Name = "TransformResizeButton";
            this.TransformResizeButton.Size = new System.Drawing.Size(32, 32);
            this.TransformResizeButton.TabIndex = 14;
            this.toolTip1.SetToolTip(this.TransformResizeButton, "Transform Resize");
            this.TransformResizeButton.UseVisualStyleBackColor = false;
            // 
            // TransformRotateButton
            // 
            this.TransformRotateButton.BackColor = System.Drawing.Color.Transparent;
            this.TransformRotateButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.transformRotateIcon;
            this.TransformRotateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TransformRotateButton.FlatAppearance.BorderSize = 0;
            this.TransformRotateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TransformRotateButton.ForeColor = System.Drawing.SystemColors.Control;
            this.TransformRotateButton.Location = new System.Drawing.Point(2, 460);
            this.TransformRotateButton.Name = "TransformRotateButton";
            this.TransformRotateButton.Size = new System.Drawing.Size(32, 32);
            this.TransformRotateButton.TabIndex = 13;
            this.toolTip1.SetToolTip(this.TransformRotateButton, "Transform Rotate");
            this.TransformRotateButton.UseVisualStyleBackColor = false;
            // 
            // SelectFlipVerticalButton
            // 
            this.SelectFlipVerticalButton.BackColor = System.Drawing.Color.Transparent;
            this.SelectFlipVerticalButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.flipVerticallyIcon;
            this.SelectFlipVerticalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SelectFlipVerticalButton.FlatAppearance.BorderSize = 0;
            this.SelectFlipVerticalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectFlipVerticalButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SelectFlipVerticalButton.Location = new System.Drawing.Point(1, 384);
            this.SelectFlipVerticalButton.Name = "SelectFlipVerticalButton";
            this.SelectFlipVerticalButton.Size = new System.Drawing.Size(32, 32);
            this.SelectFlipVerticalButton.TabIndex = 12;
            this.toolTip1.SetToolTip(this.SelectFlipVerticalButton, "Transform Flip");
            this.SelectFlipVerticalButton.UseVisualStyleBackColor = false;
            this.SelectFlipVerticalButton.Click += new System.EventHandler(this.TransformFlipVerticalButton_Click);
            // 
            // SelectFlipHorizontalButton
            // 
            this.SelectFlipHorizontalButton.BackColor = System.Drawing.Color.Transparent;
            this.SelectFlipHorizontalButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.flipHorizontallyIcon;
            this.SelectFlipHorizontalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SelectFlipHorizontalButton.FlatAppearance.BorderSize = 0;
            this.SelectFlipHorizontalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectFlipHorizontalButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SelectFlipHorizontalButton.Location = new System.Drawing.Point(2, 346);
            this.SelectFlipHorizontalButton.Name = "SelectFlipHorizontalButton";
            this.SelectFlipHorizontalButton.Size = new System.Drawing.Size(32, 32);
            this.SelectFlipHorizontalButton.TabIndex = 11;
            this.toolTip1.SetToolTip(this.SelectFlipHorizontalButton, "Transform Flip");
            this.SelectFlipHorizontalButton.UseVisualStyleBackColor = false;
            this.SelectFlipHorizontalButton.Click += new System.EventHandler(this.TransformFlipHorizontalButton_Click);
            // 
            // DeselectButton
            // 
            this.DeselectButton.BackColor = System.Drawing.Color.Transparent;
            this.DeselectButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.deselectionIcon;
            this.DeselectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeselectButton.FlatAppearance.BorderSize = 0;
            this.DeselectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeselectButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DeselectButton.Location = new System.Drawing.Point(1, 308);
            this.DeselectButton.Name = "DeselectButton";
            this.DeselectButton.Size = new System.Drawing.Size(32, 32);
            this.DeselectButton.TabIndex = 10;
            this.toolTip1.SetToolTip(this.DeselectButton, "Deselect\r\n\r\nResets the selected area so that the whole canvas can be used again\r\n" + "\r\nShortcut: D");
            this.DeselectButton.UseVisualStyleBackColor = false;
            this.DeselectButton.Click += new System.EventHandler(this.DeselectButton_Click);
            // 
            // SelectionButton
            // 
            this.SelectionButton.BackColor = System.Drawing.Color.Transparent;
            this.SelectionButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.selectionIcon;
            this.SelectionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SelectionButton.FlatAppearance.BorderSize = 0;
            this.SelectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectionButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SelectionButton.Location = new System.Drawing.Point(2, 270);
            this.SelectionButton.Name = "SelectionButton";
            this.SelectionButton.Size = new System.Drawing.Size(32, 32);
            this.SelectionButton.TabIndex = 9;
            this.toolTip1.SetToolTip(this.SelectionButton, "Selection\r\n\r\nSelects an area of the canvas to work within\r\n\r\nShortcut: M");
            this.SelectionButton.UseVisualStyleBackColor = false;
            this.SelectionButton.Click += new System.EventHandler(this.SelectionButton_Click);
            // 
            // FillButton
            // 
            this.FillButton.BackColor = System.Drawing.Color.Transparent;
            this.FillButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.fillIcon;
            this.FillButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FillButton.FlatAppearance.BorderSize = 0;
            this.FillButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FillButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FillButton.Location = new System.Drawing.Point(2, 232);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(32, 32);
            this.FillButton.TabIndex = 8;
            this.toolTip1.SetToolTip(this.FillButton, "Fill\r\n\r\nFills an area of the canvas in a solid colour\r\n\r\nShortcut: G");
            this.FillButton.UseVisualStyleBackColor = false;
            this.FillButton.Click += new System.EventHandler(this.FillTool_Click);
            // 
            // TextButton
            // 
            this.TextButton.BackColor = System.Drawing.Color.Transparent;
            this.TextButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.textIcon;
            this.TextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextButton.FlatAppearance.BorderSize = 0;
            this.TextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TextButton.ForeColor = System.Drawing.SystemColors.Control;
            this.TextButton.Location = new System.Drawing.Point(2, 194);
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(32, 32);
            this.TextButton.TabIndex = 7;
            this.toolTip1.SetToolTip(this.TextButton, "Text\r\n\r\nAdds formatted text to the canvas\r\n\r\nShortcut: T");
            this.TextButton.UseVisualStyleBackColor = false;
            this.TextButton.Click += new System.EventHandler(this.TextButton_Click);
            // 
            // EyedropperButton
            // 
            this.EyedropperButton.BackColor = System.Drawing.Color.Transparent;
            this.EyedropperButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.eyedropperIcon;
            this.EyedropperButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EyedropperButton.FlatAppearance.BorderSize = 0;
            this.EyedropperButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EyedropperButton.ForeColor = System.Drawing.SystemColors.Control;
            this.EyedropperButton.Location = new System.Drawing.Point(2, 156);
            this.EyedropperButton.Name = "EyedropperButton";
            this.EyedropperButton.Size = new System.Drawing.Size(32, 32);
            this.EyedropperButton.TabIndex = 6;
            this.toolTip1.SetToolTip(this.EyedropperButton, "Eyedropper\r\n\r\nSets the brush colour to the colour of the pixel you select\r\n\r\nShor" + "tcut: I\r\n");
            this.EyedropperButton.UseVisualStyleBackColor = false;
            this.EyedropperButton.Click += new System.EventHandler(this.EyedropperButton_Click);
            // 
            // PaintbrushButton
            // 
            this.PaintbrushButton.BackColor = System.Drawing.Color.Transparent;
            this.PaintbrushButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.paintbrushIcon;
            this.PaintbrushButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PaintbrushButton.FlatAppearance.BorderSize = 0;
            this.PaintbrushButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PaintbrushButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PaintbrushButton.Location = new System.Drawing.Point(2, 80);
            this.PaintbrushButton.Name = "PaintbrushButton";
            this.PaintbrushButton.Size = new System.Drawing.Size(32, 32);
            this.PaintbrushButton.TabIndex = 5;
            this.toolTip1.SetToolTip(this.PaintbrushButton, "Paintbrush\r\n\r\nUsed for drawing lines on the canvas\r\n\r\nShortcut: B");
            this.PaintbrushButton.UseVisualStyleBackColor = false;
            this.PaintbrushButton.Click += new System.EventHandler(this.PaintbrushButton_Click);
            // 
            // PencilButton
            // 
            this.PencilButton.BackColor = System.Drawing.Color.Transparent;
            this.PencilButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.pencilIcon;
            this.PencilButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PencilButton.FlatAppearance.BorderSize = 0;
            this.PencilButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PencilButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PencilButton.Location = new System.Drawing.Point(2, 42);
            this.PencilButton.Name = "PencilButton";
            this.PencilButton.Size = new System.Drawing.Size(32, 32);
            this.PencilButton.TabIndex = 4;
            this.toolTip1.SetToolTip(this.PencilButton, "Pencil\r\n\r\nUsed for drawing lines on the canvas\r\n\r\nShortcut: Ctrl + P");
            this.PencilButton.UseVisualStyleBackColor = false;
            this.PencilButton.Click += new System.EventHandler(this.PencilButton_Click);
            // 
            // PenButton
            // 
            this.PenButton.BackColor = System.Drawing.Color.Transparent;
            this.PenButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.penIcon;
            this.PenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PenButton.FlatAppearance.BorderSize = 0;
            this.PenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PenButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PenButton.Location = new System.Drawing.Point(2, 4);
            this.PenButton.Name = "PenButton";
            this.PenButton.Size = new System.Drawing.Size(32, 32);
            this.PenButton.TabIndex = 2;
            this.toolTip1.SetToolTip(this.PenButton, "Pen\r\n\r\nUsed for drawing lines on the canvas\r\n\r\nShortcut: P");
            this.PenButton.UseVisualStyleBackColor = false;
            this.PenButton.Click += new System.EventHandler(this.PenButton_Click);
            // 
            // EraserButton
            // 
            this.EraserButton.BackColor = System.Drawing.Color.Transparent;
            this.EraserButton.BackgroundImage = global::Digital_Canvas.Properties.Resources.eraserIcon;
            this.EraserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EraserButton.FlatAppearance.BorderSize = 0;
            this.EraserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EraserButton.ForeColor = System.Drawing.SystemColors.Control;
            this.EraserButton.Location = new System.Drawing.Point(2, 118);
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Size = new System.Drawing.Size(32, 32);
            this.EraserButton.TabIndex = 3;
            this.toolTip1.SetToolTip(this.EraserButton, "Eraser\r\n\r\nUsed for removing lines/areas of colour from the canvas\r\n\r\nShortcut: E");
            this.EraserButton.UseVisualStyleBackColor = false;
            this.EraserButton.Click += new System.EventHandler(this.EraserButton_Click);
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
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Digital Canvas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
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
            this.TopToolbarPanel.ResumeLayout(false);
            this.TopToolbarPanel.PerformLayout();
            this.LeftToolbarPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnLayersAdd;
        private System.Windows.Forms.Button btnLayersMoveDown;
        private System.Windows.Forms.Button btnLayersMoveUp;
        private System.Windows.Forms.Button btnLayersRemove;
        private System.Windows.Forms.Button btnLayersVisible;

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
        private Button EyedropperButton;
        private Button TextButton;
        private Button FillButton;
        private Label XPositionLabel;
        private Label YPositionLabel;
        private Button UndoButton;
        private Button FlipVerticallyButton;
        private Button FlipHorizontallyButton;
        private Button ZoomInButton;
        private Button ZoomOutButton;
        private Button RotateRightButton;
        private Button RotateLeftButton;
        private Button RedoButton;
        private ToolStripMenuItem instructionManualToolStripMenuItem;
        private ToolTip toolTip1;
        private Button SelectionButton;
        private Button DeselectButton;
        private Button SelectFlipVerticalButton;
        private Button SelectFlipHorizontalButton;
        private Button TransformRotateButton;
        private Button TransformResizeButton;
    }
}

