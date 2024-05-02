using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İlkFormUygulamam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = true;
            this.MaximizeBox = true;
            this.ControlBox = true;
            this.Text = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
        }
    }
}
