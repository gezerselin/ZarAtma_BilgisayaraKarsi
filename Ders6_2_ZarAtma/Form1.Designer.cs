
namespace Ders6_2_ZarAtma
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
            this.components = new System.ComponentModel.Container();
            this.LabelOyuncu1Ad = new System.Windows.Forms.Label();
            this.birinciOyuncu = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxOyuncu1Ad = new System.Windows.Forms.TextBox();
            this.ButonAd1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelKazanan = new System.Windows.Forms.Label();
            this.labelOyuncu1Zar = new System.Windows.Forms.Label();
            this.labelOyuncu2Zar = new System.Windows.Forms.Label();
            this.textBoxBahisTutari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBahis = new System.Windows.Forms.Button();
            this.labelOyuncu1Bakiye = new System.Windows.Forms.Label();
            this.labelOyuncu2Bakiye = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOyuncu1Bakiye = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelBahisTutar = new System.Windows.Forms.Label();
            this.buttonTekrarOyna = new System.Windows.Forms.Button();
            this.LabelOyuncu2Ad = new System.Windows.Forms.Label();
            this.comboBoxSeviye = new System.Windows.Forms.ComboBox();
            this.labelSeviye = new System.Windows.Forms.Label();
            this.labelBakiyeYetersiz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelOyuncu1Ad
            // 
            this.LabelOyuncu1Ad.AutoSize = true;
            this.LabelOyuncu1Ad.Location = new System.Drawing.Point(49, 320);
            this.LabelOyuncu1Ad.Name = "LabelOyuncu1Ad";
            this.LabelOyuncu1Ad.Size = new System.Drawing.Size(36, 20);
            this.LabelOyuncu1Ad.TabIndex = 2;
            this.LabelOyuncu1Ad.Text = "isim";
            // 
            // birinciOyuncu
            // 
            this.birinciOyuncu.Enabled = false;
            this.birinciOyuncu.Location = new System.Drawing.Point(53, 354);
            this.birinciOyuncu.Name = "birinciOyuncu";
            this.birinciOyuncu.Size = new System.Drawing.Size(121, 41);
            this.birinciOyuncu.TabIndex = 3;
            this.birinciOyuncu.Text = "zar at";
            this.birinciOyuncu.UseVisualStyleBackColor = true;
            this.birinciOyuncu.Click += new System.EventHandler(this.birinciOyuncu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxOyuncu1Ad
            // 
            this.textBoxOyuncu1Ad.Location = new System.Drawing.Point(142, 137);
            this.textBoxOyuncu1Ad.Name = "textBoxOyuncu1Ad";
            this.textBoxOyuncu1Ad.Size = new System.Drawing.Size(100, 26);
            this.textBoxOyuncu1Ad.TabIndex = 6;
            // 
            // ButonAd1
            // 
            this.ButonAd1.Enabled = false;
            this.ButonAd1.Location = new System.Drawing.Point(495, 128);
            this.ButonAd1.Name = "ButonAd1";
            this.ButonAd1.Size = new System.Drawing.Size(85, 44);
            this.ButonAd1.TabIndex = 7;
            this.ButonAd1.Text = "Kaydet";
            this.ButonAd1.UseVisualStyleBackColor = true;
            this.ButonAd1.Click += new System.EventHandler(this.ButonAd1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "kazanan";
            // 
            // labelKazanan
            // 
            this.labelKazanan.AutoSize = true;
            this.labelKazanan.Location = new System.Drawing.Point(234, 507);
            this.labelKazanan.Name = "labelKazanan";
            this.labelKazanan.Size = new System.Drawing.Size(70, 20);
            this.labelKazanan.TabIndex = 11;
            this.labelKazanan.Text = "kazanan";
            // 
            // labelOyuncu1Zar
            // 
            this.labelOyuncu1Zar.Location = new System.Drawing.Point(83, 420);
            this.labelOyuncu1Zar.Name = "labelOyuncu1Zar";
            this.labelOyuncu1Zar.Size = new System.Drawing.Size(51, 20);
            this.labelOyuncu1Zar.TabIndex = 0;
            this.labelOyuncu1Zar.Text = "zar";
            // 
            // labelOyuncu2Zar
            // 
            this.labelOyuncu2Zar.AutoSize = true;
            this.labelOyuncu2Zar.Location = new System.Drawing.Point(405, 375);
            this.labelOyuncu2Zar.Name = "labelOyuncu2Zar";
            this.labelOyuncu2Zar.Size = new System.Drawing.Size(31, 20);
            this.labelOyuncu2Zar.TabIndex = 12;
            this.labelOyuncu2Zar.Text = "zar";
            // 
            // textBoxBahisTutari
            // 
            this.textBoxBahisTutari.Location = new System.Drawing.Point(121, 30);
            this.textBoxBahisTutari.Name = "textBoxBahisTutari";
            this.textBoxBahisTutari.Size = new System.Drawing.Size(100, 26);
            this.textBoxBahisTutari.TabIndex = 13;
            this.textBoxBahisTutari.TextChanged += new System.EventHandler(this.textBoxBahisTutari_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bahis girin";
            // 
            // buttonBahis
            // 
            this.buttonBahis.Enabled = false;
            this.buttonBahis.Location = new System.Drawing.Point(238, 25);
            this.buttonBahis.Name = "buttonBahis";
            this.buttonBahis.Size = new System.Drawing.Size(91, 31);
            this.buttonBahis.TabIndex = 15;
            this.buttonBahis.Text = "Tamam";
            this.buttonBahis.UseVisualStyleBackColor = true;
            this.buttonBahis.Click += new System.EventHandler(this.buttonBahis_Click);
            // 
            // labelOyuncu1Bakiye
            // 
            this.labelOyuncu1Bakiye.AutoSize = true;
            this.labelOyuncu1Bakiye.Location = new System.Drawing.Point(126, 320);
            this.labelOyuncu1Bakiye.Name = "labelOyuncu1Bakiye";
            this.labelOyuncu1Bakiye.Size = new System.Drawing.Size(54, 20);
            this.labelOyuncu1Bakiye.TabIndex = 16;
            this.labelOyuncu1Bakiye.Text = "bakiye";
            // 
            // labelOyuncu2Bakiye
            // 
            this.labelOyuncu2Bakiye.AutoSize = true;
            this.labelOyuncu2Bakiye.Location = new System.Drawing.Point(435, 320);
            this.labelOyuncu2Bakiye.Name = "labelOyuncu2Bakiye";
            this.labelOyuncu2Bakiye.Size = new System.Drawing.Size(54, 20);
            this.labelOyuncu2Bakiye.TabIndex = 17;
            this.labelOyuncu2Bakiye.Text = "bakiye";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Bakiye girin";
            // 
            // textBoxOyuncu1Bakiye
            // 
            this.textBoxOyuncu1Bakiye.Location = new System.Drawing.Point(373, 140);
            this.textBoxOyuncu1Bakiye.Name = "textBoxOyuncu1Bakiye";
            this.textBoxOyuncu1Bakiye.Size = new System.Drawing.Size(100, 26);
            this.textBoxOyuncu1Bakiye.TabIndex = 18;
            this.textBoxOyuncu1Bakiye.TextChanged += new System.EventHandler(this.textBoxOyuncu1Bakiye_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "İsim girin";
            // 
            // labelBahisTutar
            // 
            this.labelBahisTutar.AutoSize = true;
            this.labelBahisTutar.Location = new System.Drawing.Point(126, 74);
            this.labelBahisTutar.Name = "labelBahisTutar";
            this.labelBahisTutar.Size = new System.Drawing.Size(93, 20);
            this.labelBahisTutar.TabIndex = 24;
            this.labelBahisTutar.Text = "Bahis Tutarı";
            // 
            // buttonTekrarOyna
            // 
            this.buttonTekrarOyna.Enabled = false;
            this.buttonTekrarOyna.Location = new System.Drawing.Point(439, 441);
            this.buttonTekrarOyna.Name = "buttonTekrarOyna";
            this.buttonTekrarOyna.Size = new System.Drawing.Size(171, 86);
            this.buttonTekrarOyna.TabIndex = 25;
            this.buttonTekrarOyna.Text = "TEKRAR OYNA";
            this.buttonTekrarOyna.UseVisualStyleBackColor = true;
            this.buttonTekrarOyna.Click += new System.EventHandler(this.buttonTekrarOyna_Click);
            // 
            // LabelOyuncu2Ad
            // 
            this.LabelOyuncu2Ad.AutoSize = true;
            this.LabelOyuncu2Ad.Location = new System.Drawing.Point(359, 320);
            this.LabelOyuncu2Ad.Name = "LabelOyuncu2Ad";
            this.LabelOyuncu2Ad.Size = new System.Drawing.Size(36, 20);
            this.LabelOyuncu2Ad.TabIndex = 4;
            this.LabelOyuncu2Ad.Text = "isim";
            // 
            // comboBoxSeviye
            // 
            this.comboBoxSeviye.FormattingEnabled = true;
            this.comboBoxSeviye.Items.AddRange(new object[] {
            "zor",
            "orta"});
            this.comboBoxSeviye.Location = new System.Drawing.Point(130, 227);
            this.comboBoxSeviye.Name = "comboBoxSeviye";
            this.comboBoxSeviye.Size = new System.Drawing.Size(226, 28);
            this.comboBoxSeviye.TabIndex = 26;
            this.comboBoxSeviye.Text = "Zorluk seviyesi seçiniz";
            this.comboBoxSeviye.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeviye_SelectedIndexChanged);
            // 
            // labelSeviye
            // 
            this.labelSeviye.AutoSize = true;
            this.labelSeviye.Location = new System.Drawing.Point(33, 230);
            this.labelSeviye.Name = "labelSeviye";
            this.labelSeviye.Size = new System.Drawing.Size(55, 20);
            this.labelSeviye.TabIndex = 27;
            this.labelSeviye.Text = "Seviye";
            // 
            // labelBakiyeYetersiz
            // 
            this.labelBakiyeYetersiz.AutoSize = true;
            this.labelBakiyeYetersiz.Location = new System.Drawing.Point(386, 182);
            this.labelBakiyeYetersiz.Name = "labelBakiyeYetersiz";
            this.labelBakiyeYetersiz.Size = new System.Drawing.Size(0, 20);
            this.labelBakiyeYetersiz.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 556);
            this.Controls.Add(this.labelBakiyeYetersiz);
            this.Controls.Add(this.labelSeviye);
            this.Controls.Add(this.comboBoxSeviye);
            this.Controls.Add(this.buttonTekrarOyna);
            this.Controls.Add(this.labelBahisTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOyuncu1Bakiye);
            this.Controls.Add(this.labelOyuncu2Bakiye);
            this.Controls.Add(this.labelOyuncu1Bakiye);
            this.Controls.Add(this.buttonBahis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBahisTutari);
            this.Controls.Add(this.labelOyuncu2Zar);
            this.Controls.Add(this.labelOyuncu1Zar);
            this.Controls.Add(this.labelKazanan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButonAd1);
            this.Controls.Add(this.textBoxOyuncu1Ad);
            this.Controls.Add(this.LabelOyuncu2Ad);
            this.Controls.Add(this.birinciOyuncu);
            this.Controls.Add(this.LabelOyuncu1Ad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelOyuncu1Ad;
        private System.Windows.Forms.Button birinciOyuncu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxOyuncu1Ad;
        private System.Windows.Forms.Button ButonAd1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelKazanan;
        private System.Windows.Forms.Label labelOyuncu1Zar;
        private System.Windows.Forms.Label labelOyuncu2Zar;
        private System.Windows.Forms.TextBox textBoxBahisTutari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBahis;
        private System.Windows.Forms.Label labelOyuncu1Bakiye;
        private System.Windows.Forms.Label labelOyuncu2Bakiye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOyuncu1Bakiye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelBahisTutar;
        private System.Windows.Forms.Button buttonTekrarOyna;
        private System.Windows.Forms.Label LabelOyuncu2Ad;
        private System.Windows.Forms.ComboBox comboBoxSeviye;
        private System.Windows.Forms.Label labelSeviye;
        private System.Windows.Forms.Label labelBakiyeYetersiz;
    }
}

