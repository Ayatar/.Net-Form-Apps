using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recursiveFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int faktoriyel(int s)
        {
            if (s>1)
            {
                return s * faktoriyel(s-1);
            }
            else
            {
                return 1;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = faktoriyel(Convert.ToInt32(textBox1.Text)).ToString();
        }
    }
}
