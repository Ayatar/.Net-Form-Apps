using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Globallocalscope
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

        private void btnLocal_Click(object sender, EventArgs e)
        {
            int MyNumber = 19;
            textBox1.Text = MyNumber.ToString();
        }
        private void btnGlobal_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(MyGlobal123.MyNumber);
        }


    }
    public static class MyGlobal123
    {

        public static int MyNumber = 19;

       
    }

}
