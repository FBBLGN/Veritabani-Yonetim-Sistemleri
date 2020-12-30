namespace Kargo
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ygirisBtn = new System.Windows.Forms.Button();
            this.ysifreTxt = new System.Windows.Forms.TextBox();
            this.ymailTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gidTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gkayitBtn = new System.Windows.Forms.Button();
            this.gadTxt = new System.Windows.Forms.TextBox();
            this.gadresTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gsoyadTxt = new System.Windows.Forms.TextBox();
            this.gmailTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gtelTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uyeolBtn = new System.Windows.Forms.Button();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.adresTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.telTxt = new System.Windows.Forms.TextBox();
            this.GonderiLabel = new System.Windows.Forms.Label();
            this.Sorgula = new System.Windows.Forms.Button();
            this.GonderiTakipPic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GonderiTakipPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(307, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.ygirisBtn);
            this.tabPage1.Controls.Add(this.ysifreTxt);
            this.tabPage1.Controls.Add(this.ymailTxt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(299, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Yönetici Girişi";
            // 
            // ygirisBtn
            // 
            this.ygirisBtn.Location = new System.Drawing.Point(182, 258);
            this.ygirisBtn.Name = "ygirisBtn";
            this.ygirisBtn.Size = new System.Drawing.Size(88, 33);
            this.ygirisBtn.TabIndex = 4;
            this.ygirisBtn.Text = "Giriş";
            this.ygirisBtn.UseVisualStyleBackColor = true;
            this.ygirisBtn.Click += new System.EventHandler(this.ygirisBtn_Click);
            // 
            // ysifreTxt
            // 
            this.ysifreTxt.Location = new System.Drawing.Point(30, 208);
            this.ysifreTxt.Name = "ysifreTxt";
            this.ysifreTxt.Size = new System.Drawing.Size(100, 20);
            this.ysifreTxt.TabIndex = 3;
            // 
            // ymailTxt
            // 
            this.ymailTxt.Location = new System.Drawing.Point(30, 149);
            this.ymailTxt.Name = "ymailTxt";
            this.ymailTxt.Size = new System.Drawing.Size(100, 20);
            this.ymailTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(299, 321);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gönderici-Alıcı Kayıt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.gidTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.gkayitBtn);
            this.groupBox2.Controls.Add(this.gadTxt);
            this.groupBox2.Controls.Add(this.gadresTxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.gsoyadTxt);
            this.groupBox2.Controls.Add(this.gmailTxt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.gtelTxt);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 295);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gönderen";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "ID";
            // 
            // gidTxt
            // 
            this.gidTxt.Location = new System.Drawing.Point(53, 33);
            this.gidTxt.Name = "gidTxt";
            this.gidTxt.Size = new System.Drawing.Size(75, 20);
            this.gidTxt.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad";
            // 
            // gkayitBtn
            // 
            this.gkayitBtn.Location = new System.Drawing.Point(53, 213);
            this.gkayitBtn.Name = "gkayitBtn";
            this.gkayitBtn.Size = new System.Drawing.Size(66, 27);
            this.gkayitBtn.TabIndex = 12;
            this.gkayitBtn.Text = "Gönderen Kayit";
            this.gkayitBtn.UseVisualStyleBackColor = true;
            this.gkayitBtn.Click += new System.EventHandler(this.gkayitBtn_Click);
            // 
            // gadTxt
            // 
            this.gadTxt.Location = new System.Drawing.Point(53, 59);
            this.gadTxt.Name = "gadTxt";
            this.gadTxt.Size = new System.Drawing.Size(75, 20);
            this.gadTxt.TabIndex = 1;
            // 
            // gadresTxt
            // 
            this.gadresTxt.Location = new System.Drawing.Point(53, 163);
            this.gadresTxt.Multiline = true;
            this.gadresTxt.Name = "gadresTxt";
            this.gadresTxt.Size = new System.Drawing.Size(75, 26);
            this.gadresTxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Soyad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Adres";
            // 
            // gsoyadTxt
            // 
            this.gsoyadTxt.Location = new System.Drawing.Point(53, 85);
            this.gsoyadTxt.Name = "gsoyadTxt";
            this.gsoyadTxt.Size = new System.Drawing.Size(75, 20);
            this.gsoyadTxt.TabIndex = 3;
            // 
            // gmailTxt
            // 
            this.gmailTxt.Location = new System.Drawing.Point(53, 137);
            this.gmailTxt.Name = "gmailTxt";
            this.gmailTxt.Size = new System.Drawing.Size(75, 20);
            this.gmailTxt.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Telefon";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Mail";
            // 
            // gtelTxt
            // 
            this.gtelTxt.Location = new System.Drawing.Point(53, 111);
            this.gtelTxt.Name = "gtelTxt";
            this.gtelTxt.Size = new System.Drawing.Size(75, 20);
            this.gtelTxt.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.idTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.uyeolBtn);
            this.groupBox1.Controls.Add(this.adTxt);
            this.groupBox1.Controls.Add(this.adresTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.soyadTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.telTxt);
            this.groupBox1.Location = new System.Drawing.Point(159, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 295);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alıcı";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-3, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "ID";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(44, 33);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(75, 20);
            this.idTxt.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ad";
            // 
            // uyeolBtn
            // 
            this.uyeolBtn.Location = new System.Drawing.Point(53, 213);
            this.uyeolBtn.Name = "uyeolBtn";
            this.uyeolBtn.Size = new System.Drawing.Size(66, 27);
            this.uyeolBtn.TabIndex = 12;
            this.uyeolBtn.Text = "Alıcı";
            this.uyeolBtn.UseVisualStyleBackColor = true;
            this.uyeolBtn.Click += new System.EventHandler(this.uyeolBtn_Click);
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(44, 59);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(75, 20);
            this.adTxt.TabIndex = 1;
            // 
            // adresTxt
            // 
            this.adresTxt.Location = new System.Drawing.Point(44, 141);
            this.adresTxt.Multiline = true;
            this.adresTxt.Name = "adresTxt";
            this.adresTxt.Size = new System.Drawing.Size(75, 26);
            this.adresTxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Soyad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-3, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Adres";
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(44, 85);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(75, 20);
            this.soyadTxt.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-3, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Telefon";
            // 
            // telTxt
            // 
            this.telTxt.Location = new System.Drawing.Point(44, 111);
            this.telTxt.Name = "telTxt";
            this.telTxt.Size = new System.Drawing.Size(75, 20);
            this.telTxt.TabIndex = 5;
            // 
            // GonderiLabel
            // 
            this.GonderiLabel.AutoSize = true;
            this.GonderiLabel.Location = new System.Drawing.Point(134, 378);
            this.GonderiLabel.Name = "GonderiLabel";
            this.GonderiLabel.Size = new System.Drawing.Size(113, 13);
            this.GonderiLabel.TabIndex = 2;
            this.GonderiLabel.Text = "Gönderinizi Takip Edin";
            // 
            // Sorgula
            // 
            this.Sorgula.Location = new System.Drawing.Point(137, 406);
            this.Sorgula.Name = "Sorgula";
            this.Sorgula.Size = new System.Drawing.Size(120, 32);
            this.Sorgula.TabIndex = 4;
            this.Sorgula.Text = "Sorgula";
            this.Sorgula.UseVisualStyleBackColor = true;
            this.Sorgula.Click += new System.EventHandler(this.Sorgula_Click);
            // 
            // GonderiTakipPic
            // 
            this.GonderiTakipPic.BackgroundImage = global::Kargo.Properties.Resources.box;
            this.GonderiTakipPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GonderiTakipPic.Location = new System.Drawing.Point(17, 366);
            this.GonderiTakipPic.Name = "GonderiTakipPic";
            this.GonderiTakipPic.Size = new System.Drawing.Size(95, 72);
            this.GonderiTakipPic.TabIndex = 1;
            this.GonderiTakipPic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Kargo.Properties.Resources.fast;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(30, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 96);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(332, 450);
            this.Controls.Add(this.Sorgula);
            this.Controls.Add(this.GonderiLabel);
            this.Controls.Add(this.GonderiTakipPic);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GonderiTakipPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox GonderiTakipPic;
        private System.Windows.Forms.Label GonderiLabel;
        private System.Windows.Forms.Button Sorgula;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ygirisBtn;
        private System.Windows.Forms.TextBox ysifreTxt;
        private System.Windows.Forms.TextBox ymailTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uyeolBtn;
        private System.Windows.Forms.TextBox adresTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox telTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox soyadTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gkayitBtn;
        private System.Windows.Forms.TextBox gadTxt;
        private System.Windows.Forms.TextBox gadresTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox gsoyadTxt;
        private System.Windows.Forms.TextBox gmailTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox gtelTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox gidTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox idTxt;
    }
}

