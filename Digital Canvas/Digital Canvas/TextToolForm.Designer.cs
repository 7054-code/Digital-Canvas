
namespace Digital_Canvas
{
    partial class TextToolForm
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
            this.components = new System.ComponentModel.Container();
            this.PreviewRichTextBox = new System.Windows.Forms.RichTextBox();
            this.FontLabel = new System.Windows.Forms.Label();
            this.FontSizeLabel = new System.Windows.Forms.Label();
            this.ColourLabel = new System.Windows.Forms.Label();
            this.TextPreviewLabel = new System.Windows.Forms.Label();
            this.FontFamilyComboBox = new System.Windows.Forms.ComboBox();
            this.FontSizeComboBox = new System.Windows.Forms.ComboBox();
            this.ColourButton = new System.Windows.Forms.Button();
            this.BoldButton = new System.Windows.Forms.Button();
            this.ItalicsButton = new System.Windows.Forms.Button();
            this.UnderlineFontButton = new System.Windows.Forms.Button();
            this.StrikethroughFontButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // PreviewRichTextBox
            // 
            this.PreviewRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PreviewRichTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewRichTextBox.Location = new System.Drawing.Point(21, 85);
            this.PreviewRichTextBox.Name = "PreviewRichTextBox";
            this.PreviewRichTextBox.Size = new System.Drawing.Size(558, 170);
            this.PreviewRichTextBox.TabIndex = 2;
            this.PreviewRichTextBox.Text = "";
            // 
            // FontLabel
            // 
            this.FontLabel.AutoSize = true;
            this.FontLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.FontLabel.Location = new System.Drawing.Point(18, 28);
            this.FontLabel.Name = "FontLabel";
            this.FontLabel.Size = new System.Drawing.Size(28, 13);
            this.FontLabel.TabIndex = 3;
            this.FontLabel.Text = "Font";
            // 
            // FontSizeLabel
            // 
            this.FontSizeLabel.AutoSize = true;
            this.FontSizeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.FontSizeLabel.Location = new System.Drawing.Point(206, 29);
            this.FontSizeLabel.Name = "FontSizeLabel";
            this.FontSizeLabel.Size = new System.Drawing.Size(51, 13);
            this.FontSizeLabel.TabIndex = 4;
            this.FontSizeLabel.Text = "Font Size";
            // 
            // ColourLabel
            // 
            this.ColourLabel.AutoSize = true;
            this.ColourLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ColourLabel.Location = new System.Drawing.Point(458, 29);
            this.ColourLabel.Name = "ColourLabel";
            this.ColourLabel.Size = new System.Drawing.Size(37, 13);
            this.ColourLabel.TabIndex = 5;
            this.ColourLabel.Text = "Colour";
            // 
            // TextPreviewLabel
            // 
            this.TextPreviewLabel.AutoSize = true;
            this.TextPreviewLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TextPreviewLabel.Location = new System.Drawing.Point(18, 60);
            this.TextPreviewLabel.Name = "TextPreviewLabel";
            this.TextPreviewLabel.Size = new System.Drawing.Size(69, 13);
            this.TextPreviewLabel.TabIndex = 6;
            this.TextPreviewLabel.Text = "Text Preview";
            // 
            // FontFamilyComboBox
            // 
            this.FontFamilyComboBox.FormattingEnabled = true;
            this.FontFamilyComboBox.Location = new System.Drawing.Point(52, 25);
            this.FontFamilyComboBox.Name = "FontFamilyComboBox";
            this.FontFamilyComboBox.Size = new System.Drawing.Size(121, 21);
            this.FontFamilyComboBox.TabIndex = 7;
            this.FontFamilyComboBox.Text = "Arial";
            this.FontFamilyComboBox.SelectedValueChanged += new System.EventHandler(this.FontFamilyComboBox_SelectedValueChanged);
            // 
            // FontSizeComboBox
            // 
            this.FontSizeComboBox.DisplayMember = "11";
            this.FontSizeComboBox.FormattingEnabled = true;
            this.FontSizeComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.FontSizeComboBox.Location = new System.Drawing.Point(263, 26);
            this.FontSizeComboBox.Name = "FontSizeComboBox";
            this.FontSizeComboBox.Size = new System.Drawing.Size(50, 21);
            this.FontSizeComboBox.TabIndex = 8;
            this.FontSizeComboBox.Text = "11";
            this.FontSizeComboBox.SelectedValueChanged += new System.EventHandler(this.FontSizeComboBox_SelectedValueChanged);
            // 
            // ColourButton
            // 
            this.ColourButton.Location = new System.Drawing.Point(501, 25);
            this.ColourButton.Name = "ColourButton";
            this.ColourButton.Size = new System.Drawing.Size(75, 23);
            this.ColourButton.TabIndex = 9;
            this.ColourButton.UseVisualStyleBackColor = true;
            this.ColourButton.Click += new System.EventHandler(this.ColourButton_Click);
            // 
            // BoldButton
            // 
            this.BoldButton.BackColor = System.Drawing.Color.Transparent;
            this.BoldButton.FlatAppearance.BorderSize = 0;
            this.BoldButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoldButton.ForeColor = System.Drawing.SystemColors.Control;
            this.BoldButton.Location = new System.Drawing.Point(334, 26);
            this.BoldButton.Name = "BoldButton";
            this.BoldButton.Size = new System.Drawing.Size(21, 21);
            this.BoldButton.TabIndex = 17;
            this.BoldButton.Text = "B";
            this.toolTip1.SetToolTip(this.BoldButton, "Bold");
            this.BoldButton.UseVisualStyleBackColor = false;
            this.BoldButton.Click += new System.EventHandler(this.BoldButton_Click);
            // 
            // ItalicsButton
            // 
            this.ItalicsButton.BackColor = System.Drawing.Color.Transparent;
            this.ItalicsButton.FlatAppearance.BorderSize = 0;
            this.ItalicsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ItalicsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItalicsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ItalicsButton.Location = new System.Drawing.Point(360, 26);
            this.ItalicsButton.Name = "ItalicsButton";
            this.ItalicsButton.Size = new System.Drawing.Size(21, 21);
            this.ItalicsButton.TabIndex = 18;
            this.ItalicsButton.Text = "I";
            this.toolTip1.SetToolTip(this.ItalicsButton, "Italics");
            this.ItalicsButton.UseVisualStyleBackColor = false;
            this.ItalicsButton.Click += new System.EventHandler(this.ItalicsButton_Click);
            // 
            // UnderlineFontButton
            // 
            this.UnderlineFontButton.BackColor = System.Drawing.Color.Transparent;
            this.UnderlineFontButton.FlatAppearance.BorderSize = 0;
            this.UnderlineFontButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UnderlineFontButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnderlineFontButton.ForeColor = System.Drawing.SystemColors.Control;
            this.UnderlineFontButton.Location = new System.Drawing.Point(386, 26);
            this.UnderlineFontButton.Name = "UnderlineFontButton";
            this.UnderlineFontButton.Size = new System.Drawing.Size(21, 21);
            this.UnderlineFontButton.TabIndex = 19;
            this.UnderlineFontButton.Text = "U";
            this.toolTip1.SetToolTip(this.UnderlineFontButton, "Underline");
            this.UnderlineFontButton.UseVisualStyleBackColor = false;
            this.UnderlineFontButton.Click += new System.EventHandler(this.UnderlineFontButton_Click);
            // 
            // StrikethroughFontButton
            // 
            this.StrikethroughFontButton.BackColor = System.Drawing.Color.Transparent;
            this.StrikethroughFontButton.FlatAppearance.BorderSize = 0;
            this.StrikethroughFontButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StrikethroughFontButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrikethroughFontButton.ForeColor = System.Drawing.SystemColors.Control;
            this.StrikethroughFontButton.Location = new System.Drawing.Point(413, 26);
            this.StrikethroughFontButton.Name = "StrikethroughFontButton";
            this.StrikethroughFontButton.Size = new System.Drawing.Size(27, 21);
            this.StrikethroughFontButton.TabIndex = 20;
            this.StrikethroughFontButton.Text = "ab";
            this.toolTip1.SetToolTip(this.StrikethroughFontButton, "Strikethrough");
            this.StrikethroughFontButton.UseVisualStyleBackColor = false;
            this.StrikethroughFontButton.Click += new System.EventHandler(this.StrikethroughFontButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConfirmButton.Location = new System.Drawing.Point(198, 264);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(87, 23);
            this.ConfirmButton.TabIndex = 21;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CloseButton.Location = new System.Drawing.Point(307, 265);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(87, 23);
            this.CloseButton.TabIndex = 22;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TextToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.StrikethroughFontButton);
            this.Controls.Add(this.UnderlineFontButton);
            this.Controls.Add(this.ItalicsButton);
            this.Controls.Add(this.BoldButton);
            this.Controls.Add(this.ColourButton);
            this.Controls.Add(this.FontSizeComboBox);
            this.Controls.Add(this.FontFamilyComboBox);
            this.Controls.Add(this.TextPreviewLabel);
            this.Controls.Add(this.ColourLabel);
            this.Controls.Add(this.FontSizeLabel);
            this.Controls.Add(this.FontLabel);
            this.Controls.Add(this.PreviewRichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TextToolForm";
            this.Text = "Text Editor";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox PreviewRichTextBox;
        private System.Windows.Forms.Label FontLabel;
        private System.Windows.Forms.Label FontSizeLabel;
        private System.Windows.Forms.Label ColourLabel;
        private System.Windows.Forms.Label TextPreviewLabel;
        private System.Windows.Forms.ComboBox FontFamilyComboBox;
        private System.Windows.Forms.ComboBox FontSizeComboBox;
        private System.Windows.Forms.Button ColourButton;
        private System.Windows.Forms.Button BoldButton;
        private System.Windows.Forms.Button ItalicsButton;
        private System.Windows.Forms.Button UnderlineFontButton;
        private System.Windows.Forms.Button StrikethroughFontButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}