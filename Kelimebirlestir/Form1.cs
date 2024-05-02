using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelimebirlestir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        new Form ff2 = Form2();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string Birlestir(string s1, string s2)
        {
            //string sonuc = s1 + s2;
            //return sonuc;
            return s1 + s2;
        
        }
        public void btnBirlestir_Click(object sender, EventArgs e)
        {
            this.Text = Birlestir(textBox1.Text, textBox2.Text);
        }

        public void button2_Click(object sender, EventArgs e)
        {
            this.Text=string.Concat(textBox1.Text, textBox2.Text);
        }
    }
}
