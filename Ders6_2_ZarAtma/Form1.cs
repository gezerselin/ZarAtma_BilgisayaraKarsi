using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders6_2_ZarAtma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * bu oyunda iki oyuncu vardır
             * her oyuncunun bir zarı vardır
             * oyuncular zar atar
             * zarlar karşılaştırılır
             * büyük atan kazanır
             * 
             * nesneler
             *  - oyun
             *   -oyuncu
             *   -zar
             */

        }

        Oyun zarOyunu = new Oyun();
        private void ButonAd1_Click(object sender, EventArgs e)
        {
            string oyuncuAdi = textBoxOyuncu1Ad.Text;
            int BirinciOyuncuBakiye = Convert.ToInt32(textBoxOyuncu1Bakiye.Text);
            zarOyunu.BirinciOyuncu = new Oyuncu(oyuncuAdi, BirinciOyuncuBakiye);
            zarOyunu.BirinciOyuncu.OyuncununZari=new Zar();
            LabelOyuncu1Ad.Text = zarOyunu.BirinciOyuncu.Ad;
            labelOyuncu1Bakiye.Text = Convert.ToString(zarOyunu.BirinciOyuncu.Bakiye);
            if (zarOyunu.Bahistutari <= zarOyunu.BirinciOyuncu.Bakiye/2 )
            {
                comboBoxSeviye.Items.Add("kolay");


            }
            else 
            {
                comboBoxSeviye.Items.Remove("kolay");

            }
            

        }


        private void birinciOyuncu_Click(object sender, EventArgs e)
        {
            zarOyunu.IlkOyuncuZarAt();
            labelOyuncu1Zar.Text = zarOyunu.BirinciOyuncu.OyuncununZari.Deger.ToString();
            System.Threading.Thread.Sleep(100);
            zarOyunu.IkinciOyuncuZarAt();
            labelOyuncu2Zar.Text = zarOyunu.İkinciOyuncu.OyuncununZari.Deger.ToString();
            Oyuncu EliKazananOyuncu = zarOyunu.Karsilastir();
            labelOyuncu1Bakiye.Text = Convert.ToString(zarOyunu.BirinciOyuncu.Bakiye);
            labelOyuncu2Bakiye.Text = Convert.ToString(zarOyunu.İkinciOyuncu.Bakiye);


            if (zarOyunu.BirinciOyuncu.Bakiye >=zarOyunu.Bahistutari && zarOyunu.İkinciOyuncu.Bakiye >=zarOyunu.Bahistutari)
            {
                if (EliKazananOyuncu != null)
                {
                    labelKazanan.Text = $"{EliKazananOyuncu.Ad},{EliKazananOyuncu.OyuncununZari.Deger} atarak bu eli kazandı";
                }
                else
                {
                    labelKazanan.Text = "berabere";
                }
            }
            else
            {
                Oyuncu KazananOyunucu = zarOyunu.kazananBul();
                labelKazanan.Text = $"!!!!{KazananOyunucu.Ad} oyunu kazandı!!!";
                birinciOyuncu.Enabled = false;
                buttonTekrarOyna.Enabled = true;
            }
        }

        

        private void buttonBahis_Click(object sender, EventArgs e)
        {
           
            string bahis = textBoxBahisTutari.Text;
            zarOyunu.Bahistutari = Convert.ToInt32(bahis);
            labelBahisTutar.Text = $"Bahis tutarı {zarOyunu.Bahistutari} olarak ayarlandı";
            
   
        }

        private void buttonTekrarOyna_Click(object sender, EventArgs e)
        {
            buttonTekrarOyna.Enabled = false;
            birinciOyuncu.Enabled = true;
            textBoxBahisTutari.Text= null;
            textBoxOyuncu1Ad.Text = null;
            textBoxOyuncu1Bakiye.Text = null;
            labelBahisTutar.Text = null;
            labelKazanan.Text= null;
            labelOyuncu1Bakiye.Text = null;
            labelOyuncu2Bakiye.Text=null;
            labelOyuncu1Zar.Text = null;
            labelOyuncu2Zar.Text = null;
            LabelOyuncu1Ad.Text = null;
            LabelOyuncu2Ad.Text = null;
            labelKazanan.Text = null;
            buttonBahis.Enabled = false;
            ButonAd1.Enabled = false;
            labelBakiyeYetersiz.Text = null;
            birinciOyuncu.Enabled = false;
            comboBoxSeviye.Text = "Zorluk seviyesi seçiniz";
            
        }

        private void comboBoxSeviye_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ikinciOyuncuBakiye;

            if (comboBoxSeviye.Text == "kolay")
            {
                 ikinciOyuncuBakiye = zarOyunu.BirinciOyuncu.Bakiye / 2;
            }
            else if(comboBoxSeviye.Text == "orta")
            {
                 ikinciOyuncuBakiye = zarOyunu.BirinciOyuncu.Bakiye ;
            }
            else
            {
                ikinciOyuncuBakiye = zarOyunu.BirinciOyuncu.Bakiye*2;
            }

            birinciOyuncu.Enabled = true;
            string İkinciOyuncuAdi = "Bilgisayar";
            zarOyunu.İkinciOyuncu = new Oyuncu(İkinciOyuncuAdi, ikinciOyuncuBakiye);
            zarOyunu.İkinciOyuncu.OyuncununZari = new Zar();
            LabelOyuncu2Ad.Text = zarOyunu.İkinciOyuncu.Ad;
            labelOyuncu2Bakiye.Text = Convert.ToString(zarOyunu.İkinciOyuncu.Bakiye);
        }

        private void textBoxOyuncu1Bakiye_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxOyuncu1Bakiye.Text) < zarOyunu.Bahistutari)
                {
                    labelBakiyeYetersiz.Text = $"bakiyeniz bahis tutarından büyük olmalıdır";
                    ButonAd1.Enabled = false;
                }
                else
                {
                    ButonAd1.Enabled = true;
                    labelBakiyeYetersiz.Text = "";
                }
            }
            catch (Exception)
            {

                labelBakiyeYetersiz.Text = "bakiye tutarı bir sayı olmalıdır!";
            }
        }

        private void textBoxBahisTutari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(textBoxBahisTutari.Text);
                buttonBahis.Enabled = true;
                labelBahisTutar.Text = "";
            }
            catch
            {
                buttonBahis.Enabled = false;
                labelBahisTutar.Text = "Bahis tutarı bir sayı olmalıdır!!!";
            }
           

        }
    }
}
