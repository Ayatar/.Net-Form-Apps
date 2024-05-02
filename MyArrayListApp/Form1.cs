using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyArrayListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList arrayList = new ArrayList();
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
           arrayList.Add(Convert.ToInt32(txtEkle.Text));
           MessageBox.Show(txtEkle.Text +" Diziye eklendi...");
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach ( int i in arrayList)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void btnElemanSayisi_Click(object sender, EventArgs e)
        {
            string uzunluk = arrayList.Count.ToString();
            MessageBox.Show(uzunluk + " Eleman Var...");
        }

        private void btnListeDuz_Click(object sender, EventArgs e)
        {
            arrayList.Sort();
            MessageBox.Show("Liste Sıralandı...");
        }

        private void btnListeTers_Click(object sender, EventArgs e)
        {
            arrayList.Reverse();
            MessageBox.Show( "Liste Terslendi...");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            arrayList.Remove(Convert.ToInt32(txtSil.Text));
            MessageBox.Show(txtSil.Text + " Silindi...");
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            arrayList.IndexOf(Convert.ToInt32(txtIndex.Text));
            MessageBox.Show(arrayList.IndexOf(Convert.ToInt32(txtIndex.Text)).ToString());
        }
    }
}
