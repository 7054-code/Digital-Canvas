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
    public partial class TextToolForm : Form
    {
        private bool textBold = false;
        private bool textItalics = false;
        private bool textUnderline = false;
        private bool textStrikethrough = false;

        public TextToolForm(Form main)
        {
            InitializeComponent();
            ColourButton.BackColor = Color.Black;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                FontFamilyComboBox.Items.Add(font.Name.ToString());
            }
        }

        public Color TextColour
        {
            get { return ColourButton.BackColor; }
        }

        public string TextInput
        {
            get { return PreviewRichTextBox.Text; }
        }

        public string TextFont
        {
            get { return FontFamilyComboBox.Text; }
        }

        public float TextSize
        {
            get { return int.Parse(FontSizeComboBox.Text); }
        }

        public bool TextBold
        {
            get { return textBold; }
        }

        public bool TextItalics
        {
            get { return textItalics; }
        }

        public bool TextUnderline
        {
            get { return textUnderline; }
        }

        public bool TextStrikethrough
        {
            get { return textStrikethrough; }
        }

        private void ColourButton_Click(object sender, EventArgs e)
        {
            using (var diag = new ColorDialog())
                if (diag.ShowDialog() == DialogResult.OK)
                {
                    ColourButton.BackColor = diag.Color;
                }
            fontChange();
        }

        private void BoldButton_Click(object sender, EventArgs e)
        {
            if (textBold == true)
            {
                textBold = false;
            }
            else
            {
                textBold = true;
            }
            fontChange();
        }

        private void ItalicsButton_Click(object sender, EventArgs e)
        {
            if (textItalics == true)
            {
                textItalics = false;
            }
            else
            {
                textItalics = true;
            }
            fontChange();
        }

        private void UnderlineFontButton_Click(object sender, EventArgs e)
        {
            if (textUnderline == true)
            {
                textUnderline = false;
            }
            else
            {
                textUnderline = true;
            }
            fontChange();
        }

        private void StrikethroughFontButton_Click(object sender, EventArgs e)
        {
            if (textStrikethrough == true)
            {
                textStrikethrough = false;
            }
            else
            {
                textStrikethrough = true;
            }
            fontChange();
        }

        private void FontFamilyComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            fontChange();
        }

        private void FontSizeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            fontChange();
        }

        private void fontChange()
        {
            string textFontFamily = FontFamilyComboBox.Text;
            float textSize = float.Parse(FontSizeComboBox.Text);

            Font textFont = new Font(textFontFamily, textSize);
            FontStyle fontStyle = FontStyle.Regular;

            if (textBold == true)
            {

                fontStyle = (fontStyle | FontStyle.Bold);
            }
            else
            {
                fontStyle = (fontStyle & ~FontStyle.Bold);
            }

            if (textItalics == true)
            {
                fontStyle = (fontStyle | FontStyle.Italic);
            }
            else
            {
                fontStyle = (fontStyle & ~FontStyle.Italic);
            }

            if (textUnderline == true)
            {
                fontStyle = (textFont.Style | FontStyle.Underline);
            }
            else
            {
                fontStyle = (fontStyle & ~FontStyle.Underline);
            }

            if (textStrikethrough == true)
            {
                fontStyle = (fontStyle | FontStyle.Strikeout);
            }
            else
            {
                fontStyle = (fontStyle & ~FontStyle.Strikeout);
            }

            if (textBold == true & textItalics == false & textUnderline == true & textStrikethrough == false)
            {
                fontStyle = (textFont.Style | FontStyle.Bold | FontStyle.Underline);
            }
            else if (textBold == true & textItalics == true & textUnderline == true  & textStrikethrough == false)
            {
                fontStyle = (textFont.Style | FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
            }
            else if (textBold == true & textItalics == true & textUnderline == true & textStrikethrough == true)
            {
                fontStyle = (textFont.Style | FontStyle.Bold | FontStyle.Underline | FontStyle.Italic | FontStyle.Strikeout);
            }
            else if (textBold == true & textItalics == false & textUnderline == true & textStrikethrough == true)
            {
                fontStyle = (textFont.Style | FontStyle.Bold | FontStyle.Underline | FontStyle.Strikeout);
            }
            else if (textBold == false & textItalics == true & textUnderline == true & textStrikethrough == false)
            {
                fontStyle = (textFont.Style | FontStyle.Italic | FontStyle.Underline);
            }
            else if (textBold == false & textItalics == true & textUnderline == true & textStrikethrough == true)
            {
                fontStyle = (textFont.Style | FontStyle.Underline | FontStyle.Italic | FontStyle.Strikeout);
            }
            else if (textBold == true & textItalics == true & textUnderline == true & textStrikethrough == false)
            {
                fontStyle = (textFont.Style | FontStyle.Italic | FontStyle.Underline | FontStyle.Bold);
            }
            else if (textBold == true & textItalics == true & textUnderline == true &  textStrikethrough == true)
            {
                fontStyle = (textFont.Style | FontStyle.Bold | FontStyle.Underline | FontStyle.Italic | FontStyle.Strikeout);
            }

            PreviewRichTextBox.SelectAll();
            PreviewRichTextBox.SelectionFont = new Font(textFont, fontStyle);
            PreviewRichTextBox.SelectionColor = ColourButton.BackColor;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            PreviewRichTextBox.Text = "";
        }
    }
}
