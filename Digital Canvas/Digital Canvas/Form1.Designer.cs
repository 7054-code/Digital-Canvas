
namespace Digital_Canvas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.ColourButton = new System.Windows.Forms.Button();
            this.PenButton = new System.Windows.Forms.Button();
            this.EraserButton = new System.Windows.Forms.Button();
            this.ColourLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.BackColor = System.Drawing.Color.White;
            this.CanvasPanel.Location = new System.Drawing.Point(176, 77);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(427, 492);
            this.CanvasPanel.TabIndex = 0;
            this.CanvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasPanel_MouseDown);
            this.CanvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasPanel_MouseMove);
            // 
            // ColourButton
            // 
            this.ColourButton.Location = new System.Drawing.Point(714, 90);
            this.ColourButton.Name = "ColourButton";
            this.ColourButton.Size = new System.Drawing.Size(75, 23);
            this.ColourButton.TabIndex = 1;
            this.ColourButton.UseVisualStyleBackColor = true;
            this.ColourButton.Click += new System.EventHandler(this.ColourButton_Click);
            // 
            // PenButton
            // 
            this.PenButton.Location = new System.Drawing.Point(714, 119);
            this.PenButton.Name = "PenButton";
            this.PenButton.Size = new System.Drawing.Size(75, 23);
            this.PenButton.TabIndex = 2;
            this.PenButton.Text = "Pen";
            this.PenButton.UseVisualStyleBackColor = true;
            this.PenButton.Click += new System.EventHandler(this.PenButton_Click);
            // 
            // EraserButton
            // 
            this.EraserButton.Location = new System.Drawing.Point(714, 148);
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Size = new System.Drawing.Size(75, 23);
            this.EraserButton.TabIndex = 3;
            this.EraserButton.Text = "Eraser";
            this.EraserButton.UseVisualStyleBackColor = true;
            this.EraserButton.Click += new System.EventHandler(this.EraserButton_Click);
            // 
            // ColourLabel
            // 
            this.ColourLabel.AutoSize = true;
            this.ColourLabel.Location = new System.Drawing.Point(665, 94);
            this.ColourLabel.Name = "ColourLabel";
            this.ColourLabel.Size = new System.Drawing.Size(43, 15);
            this.ColourLabel.TabIndex = 4;
            this.ColourLabel.Text = "Colour";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 639);
            this.Controls.Add(this.ColourLabel);
            this.Controls.Add(this.EraserButton);
            this.Controls.Add(this.PenButton);
            this.Controls.Add(this.ColourButton);
            this.Controls.Add(this.CanvasPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.Button ColourButton;
        private System.Windows.Forms.Button PenButton;
        private System.Windows.Forms.Button EraserButton;
        private System.Windows.Forms.Label ColourLabel;
    }
}

