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

namespace ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 frm2;

                if (Convert.ToInt16(textBox1.Text) < 100)
                {

                    MessageBox.Show("Girdiğiniz değer 100'den küçk", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if(Convert.ToInt16(textBox1.Text) > 1500)
                {

                    MessageBox.Show("Girdiğiniz değer 1500'den büyük", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
                    frm2 = new Form2();
                    frm2.ShowDialog();
                    frm2.Owner = this;

                    int[] hesaplama1 = new int[5];
                hesaplama1[0] = 5;
                hesaplama1[1] = 5;
                hesaplama1[2] = 10;
                hesaplama1[3] = 10;
                hesaplama1[4] = 20;
                    for (int i = 0; i < hesaplama1.Length; i++)
                    {
 
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
