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
using System.Runtime.InteropServices.ComTypes;
using System.Diagnostics;

namespace CacheSilmeSon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void button1_Click(object sender, EventArgs e)
        {

           string tempPath = System.IO.Path.GetTempPath();

           
           string[] fileList = Directory.GetFiles(tempPath);
           foreach (string file in fileList)
           {
               try
               {
                    File.Delete(file);
               }
               catch (Exception exception)
               {
                   Console.WriteLine(exception);
               }
           }
           string[] directoryList = Directory.GetDirectories(tempPath);
           foreach (string directory in directoryList)
           {
               try
               {
                    Directory.Delete(directory, true);
               }
               catch (Exception ioException)
               {
                   Console.WriteLine(ioException);
               }
           }

           MessageBox.Show("Temp folder cleared.", "Success",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }

}
