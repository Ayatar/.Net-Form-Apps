using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace KlasorIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("C:\\Users\\elcik\\Desktop\\kayraYeni");
            MessageBox.Show("Klasör Oluştu...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete("C:\\Users\\elcik\\Desktop\\kayraYeni");
                MessageBox.Show("Klasör Silindi...");
            }
            catch (Exception exxx)
            {

                MessageBox.Show("Klasör Silinirken bir hata oluştu \n" +exxx.Message.ToString());
            }
            
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete("C:\\Users\\elcik\\Desktop\\kayraYeni", true);
                MessageBox.Show("Klasör Silindi...");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("C:\\Users\\elcik\\Desktop\\kayraYeni"))
            {
                MessageBox.Show("Burada belirlenen dizinden klasör var.");
            }
            else
            {
                MessageBox.Show("Belirlenen dizinde klasör yok.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime kozamani = Directory.GetCreationTime("C:\\windows");
            this.Text=kozamani.ToString();
            // This form başlığına yazı yazdırmak için kullanılıyor...
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Directory.Move("C:\\Users\\elcik\\Desktop\\kayraYeni", "C:\\karaYeni"); isimi taşınırken değişebilir değişmeyedebilir.

            Directory.Move("C:\\Users\\elcik\\Desktop\\kayraYeni", "C:\\kayraYeni");
            MessageBox.Show("Klasör taşındı.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            File.Create("C:\\Users\\elcik\\Desktop\\kayraYeniDosya.txt"); // uzantı vermen lazım !!!
            MessageBox.Show("Dosya oluşturuldu.");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            File.Delete("C:\\Users\\elcik\\Desktop\\kayraYeniDosya.txt");
            MessageBox.Show("Dosya silindi.");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            File.Copy("C:\\Users\\elcik\\Desktop\\kayraYeniDosya.txt", "C:\\kayraYeniDosya.txt");
            MessageBox.Show("Dosya kopyalandı.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (File.Exists("C:\\Users\\elcik\\Desktop\\kayraYeniDosya.txt"))
            {
                MessageBox.Show("Böyle bir dosya var.");
            }
            else 
            {
                MessageBox.Show("Böyle bir dosya yok!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            File.Move("C:\\Users\\elcik\\Desktop\\kayraYeniDosya.txt", "C:\\Users\\kayraYeniDosya.txt");
            MessageBox.Show("Dosya Taşındı.");
        }
    }
}
// BURDAN BİR ŞEY SİLİNCE HATA VERMESİNİNİ SORUNU DESİGNER KISMINDA SİLİNMEMESİ ORDAN DA SİLİNMESİ LAZIM