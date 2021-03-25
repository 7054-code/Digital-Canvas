using System;
using System.Windows.Forms;

namespace Digital_Canvas
{
    public partial class Form2 : Form
    {
        private int inputWidth;
        private int inputHeight;
        //constructor
        public Form2(Form main)
        {
            InitializeComponent();

            //set the position of the popup
            Top = main.Top + (main.Height / 2);
            Left = main.Left + (main.Width / 2);
        }

        //getters
        public int InputWidth => inputWidth;
        public int InputHeight => inputHeight;

        //'confirm' button
        private void button1_Click(object sender, EventArgs e)
        {
            inputWidth = int.Parse(textBox1.Text);
            inputHeight = int.Parse(textBox2.Text);
        }

        
    }
}
