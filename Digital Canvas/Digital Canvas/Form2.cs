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
        public Form2(ref Panel canvaspanel)
        {
            refpanel = canvaspanel;
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            refpanel.Height = int.Parse(textBox2.Text);
            refpanel.Width = int.Parse(textBox1.Text);
        }
    }
}
