using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Canvas
{
    public partial class InstructionManualForm : Form
    {
        public InstructionManualForm(Form main)
        {
            InitializeComponent();
            TextReader reader = new StreamReader(@Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Resources\Instruction Manual.txt")));
            helpRichTextBox.Text = reader.ReadToEnd();
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {

        }
    }
}
