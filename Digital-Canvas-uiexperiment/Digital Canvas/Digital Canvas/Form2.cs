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
    public partial class Form2 : Form
    {
        Panel refpanel;
        public Form2(ref Panel canvaspanel, Form main)
        {
            refpanel = canvaspanel;
            InitializeComponent();

            //set the position of the popup
            this.Top = main.Top + (main.Height / 2);
            this.Left = main.Left + (main.Width / 2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            refpanel.Height = int.Parse(textBox2.Text);
            refpanel.Width = int.Parse(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
