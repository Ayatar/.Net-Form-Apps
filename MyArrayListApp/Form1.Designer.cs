namespace MyArrayListApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnElemanSayisi = new System.Windows.Forms.Button();
            this.btnListeDuz = new System.Windows.Forms.Button();
            this.btnListeTers = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.btnArrayList = new System.Windows.Forms.Button();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.txtSil = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 40);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(188, 36);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnElemanSayisi
            // 
            this.btnElemanSayisi.Location = new System.Drawing.Point(12, 94);
            this.btnElemanSayisi.Name = "btnElemanSayisi";
            this.btnElemanSayisi.Size = new System.Drawing.Size(188, 36);
            this.btnElemanSayisi.TabIndex = 1;
            this.btnElemanSayisi.Text = "Eleman Sayısı";
            this.btnElemanSayisi.UseVisualStyleBackColor = true;
            this.btnElemanSayisi.Click += new System.EventHandler(this.btnElemanSayisi_Click);
            // 
            // btnListeDuz
            // 
            this.btnListeDuz.Location = new System.Drawing.Point(12, 149);
            this.btnListeDuz.Name = "btnListeDuz";
            this.btnListeDuz.Size = new System.Drawing.Size(188, 36);
            this.btnListeDuz.TabIndex = 2;
            this.btnListeDuz.Text = "Liste Sırala";
            this.btnListeDuz.UseVisualStyleBackColor = true;
            this.btnListeDuz.Click += new System.EventHandler(this.btnListeDuz_Click);
            // 
            // btnListeTers
            // 
            this.btnListeTers.Location = new System.Drawing.Point(12, 191);
            this.btnListeTers.Name = "btnListeTers";
            this.btnListeTers.Size = new System.Drawing.Size(188, 36);
            this.btnListeTers.TabIndex = 3;
            this.btnListeTers.Text = "Liste Tersle";
            this.btnListeTers.UseVisualStyleBackColor = true;
            this.btnListeTers.Click += new System.EventHandler(this.btnListeTers_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(12, 287);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(188, 36);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(12, 370);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(188, 36);
            this.btnIndex.TabIndex = 5;
            this.btnIndex.Text = "Index Bul";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // btnArrayList
            // 
            this.btnArrayList.Location = new System.Drawing.Point(220, 40);
            this.btnArrayList.Name = "btnArrayList";
            this.btnArrayList.Size = new System.Drawing.Size(188, 36);
            this.btnArrayList.TabIndex = 6;
            this.btnArrayList.Text = "Array List Göster";
            this.btnArrayList.UseVisualStyleBackColor = true;
            this.btnArrayList.Click += new System.EventHandler(this.btnArrayList_Click);
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(12, 12);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(188, 22);
            this.txtEkle.TabIndex = 7;
            // 
            // txtSil
            // 
            this.txtSil.Location = new System.Drawing.Point(12, 259);
            this.txtSil.Name = "txtSil";
            this.txtSil.Size = new System.Drawing.Size(188, 22);
            this.txtSil.TabIndex = 8;
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(12, 342);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(188, 22);
            this.txtIndex.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(209, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(239, 308);
            this.listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 418);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.txtSil);
            this.Controls.Add(this.txtEkle);
            this.Controls.Add(this.btnArrayList);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnListeTers);
            this.Controls.Add(this.btnListeDuz);
            this.Controls.Add(this.btnElemanSayisi);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnElemanSayisi;
        private System.Windows.Forms.Button btnListeDuz;
        private System.Windows.Forms.Button btnListeTers;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Button btnArrayList;
        private System.Windows.Forms.TextBox txtEkle;
        private System.Windows.Forms.TextBox txtSil;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.ListBox listBox1;
    }
}

