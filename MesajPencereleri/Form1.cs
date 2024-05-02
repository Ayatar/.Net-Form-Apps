using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesajPencereleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesaj içeriği");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesaj içeriği", "Uyarı");
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İçerik", "Başlık", MessageBoxButtons.YesNoCancel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İçerik", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesaj içeriği", "Uyarı",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Error,MessageBoxDefaultButton.Button3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult btnMesaj = MessageBox.Show("Mesaj içeriği",
                "Uyarı", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
            if (btnMesaj==DialogResult.Yes)
            {
                this.Text = "YES'E BASTIN";
            }
            else if(btnMesaj==DialogResult.No)
            {
                this.Text = "NO'YA BASTIN";
            }
            else if(btnMesaj==DialogResult.Cancel)
            {
                this.Text = "CENCEL'A BASTIN";
            }
            else
            {
                this.Text = "HİÇ BİR ŞEYE BASMADIN";
            }
        }
    }
}
