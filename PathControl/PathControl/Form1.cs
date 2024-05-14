using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathControl
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog folderDialog = new FolderBrowserDialog();
        FileDialog fileDialog = new OpenFileDialog();
        

        public Form1()
        {
            InitializeComponent();
            

        }

        
        

        private void Form1_Load(object sender, EventArgs e)
        {
          string yol = folderDialog.SelectedPath;
            string[] types = { ".txt", ".docx", ".pdf", ".xlsx", ".pptx" };
            foreach (var item in types)
            {
                comboBox1.Items.Add(item);
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            

            folderDialog.ShowDialog();
            textBox1.Text = folderDialog.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string _path = folderDialog.SelectedPath;
            if (pathControl() == true)
            {
                
                

                File.Create(_path + "\\" + textBox2.Text + comboBox1.SelectedItem);
                MessageBox.Show("Dosya Oluşturuldu");

            }
            else
            {
                MessageBox.Show("Dosya Oluştrurulamadı");
            }
            
        }

        private  bool pathControl()
        {

            if (File.Exists(folderDialog.SelectedPath + "\\" + textBox2.Text + comboBox1.SelectedItem) == true)
            {
                return false;
            }
            else 
            { 
                return true;
            }
            
             
        }
    }
}
