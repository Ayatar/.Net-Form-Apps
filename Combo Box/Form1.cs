using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combo_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Gaziantep");
            comboBox1.Items.Add("Antalya");
            comboBox1.Items.Add("Ankara");
            comboBox1.Items.Add("Bitlis");
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            string secilenSehir = comboBox1.SelectedItem.ToString();
            lblSonuc.Text = $"{secilenSehir} şehrini seçiniz";
        }
    }
}
