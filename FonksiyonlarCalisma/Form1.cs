using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FonksiyonlarCalisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = null; 

            try
            {
                baglanti = new SqlConnection(@"Data Source=NITRO\MSSQLSERVER02;Initial Catalog=Sqldersi;Integrated Security=True;");
                baglanti.Open();

                SqlCommand sqlkomutu = new SqlCommand("SELECT ogrenci_id, ogrenci_adi, not1, not2 FROM tbl_Ogrenci", baglanti) ;
                SqlDataReader sqlDR = sqlkomutu.ExecuteReader();

                while (sqlDR.Read())
                {
                    string id = sqlDR[0].ToString();
                    string ogrenciAdi = sqlDR[1].ToString();
                    int not1 = Convert.ToInt32(sqlDR[2]) ;
                    int not2 = Convert.ToInt32(sqlDR[3]) ;
                    int Ortalama = (not1 + not2)/2;
                    string sonuc = null;
                    if (Ortalama >= 50)
                    {
                        sonuc = "Geçti";
                    }
                    else
                    {
                        sonuc = "Kaldı";
                    }

                    richTextBox1.Text = richTextBox1.Text + id + "  "+ ogrenciAdi + "  :Not1 : " + not1 + "  :Not2: " + not2 +    "Ortalama:  " + Ortalama +"  "+ sonuc + " \n" ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Query Sırasında Hata Oluştu" + ex.ToString());
                
            }
            finally 
            {
                if (baglanti != null)
                baglanti.Close();       
            }   
        }
    }
}
