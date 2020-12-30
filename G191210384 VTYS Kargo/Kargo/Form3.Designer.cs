namespace Kargo
{
    partial class Form3
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
            this.kargoData2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.geriDon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gonderitakipidTxt = new System.Windows.Forms.TextBox();
            this.gonderisorgulaBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kargoData2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kargoData2
            // 
            this.kargoData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kargoData2.Location = new System.Drawing.Point(12, 109);
            this.kargoData2.Name = "kargoData2";
            this.kargoData2.Size = new System.Drawing.Size(427, 356);
            this.kargoData2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gönderi Takip";
            // 
            // geriDon
            // 
            this.geriDon.Location = new System.Drawing.Point(298, 480);
            this.geriDon.Name = "geriDon";
            this.geriDon.Size = new System.Drawing.Size(141, 57);
            this.geriDon.TabIndex = 2;
            this.geriDon.Text = "Geri Dön";
            this.geriDon.UseVisualStyleBackColor = true;
            this.geriDon.Click += new System.EventHandler(this.geriDon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gönderi Numaranızı Giriniz";
            // 
            // gonderitakipidTxt
            // 
            this.gonderitakipidTxt.Location = new System.Drawing.Point(19, 69);
            this.gonderitakipidTxt.Name = "gonderitakipidTxt";
            this.gonderitakipidTxt.Size = new System.Drawing.Size(127, 20);
            this.gonderitakipidTxt.TabIndex = 4;
            // 
            // gonderisorgulaBtn
            // 
            this.gonderisorgulaBtn.Location = new System.Drawing.Point(166, 69);
            this.gonderisorgulaBtn.Name = "gonderisorgulaBtn";
            this.gonderisorgulaBtn.Size = new System.Drawing.Size(75, 20);
            this.gonderisorgulaBtn.TabIndex = 5;
            this.gonderisorgulaBtn.Text = "Sorgula";
            this.gonderisorgulaBtn.UseVisualStyleBackColor = true;
            this.gonderisorgulaBtn.Click += new System.EventHandler(this.gonderisorgulaBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Kargo.Properties.Resources.box;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(298, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 90);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 549);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gonderisorgulaBtn);
            this.Controls.Add(this.gonderitakipidTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.geriDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kargoData2);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.kargoData2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kargoData2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button geriDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gonderitakipidTxt;
        private System.Windows.Forms.Button gonderisorgulaBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}