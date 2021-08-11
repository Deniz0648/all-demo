using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Array türünde Çoklu Buton oluşturma ve İhtiyaca Göre Butonların Özelliklerini Değiştirme

        private void Form1_Load(object sender, EventArgs e)
        {
            //Butonların üstten ve soldan alacağı konumun ayarlanması için top ve left değişkenlerini oluşturduk.
            int top = 0;
            int left = 0;

            //Array Tipinde 8'e 8 Genişliğinde Buton Değişkeni Oluşturduk.
            Button[,] buttons = new Button[8, 8];

            //GetUpperBound oluşturulacak butonların satır sayısı belirlenir
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                //GetUpperBound oluşturulacak butonların Sutun sayısı belirlenir
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {

                    //Döngü her tekrarlandığında yeni genişliği ve yüksekliği 50 birim olan yeni bir buton değişkeni oluşturma.
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    //Eklenen her butonun üstten ve soldan alacaağı mesafe değişkenlerden alınır.
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    //Her buton oluşturulduğunda butonların soldan alacağı mesafe değerini belirleyen değişken 50 birim arttırılır.
                    left += 50;

                    //koşul deyimi kullanılarak eklenen butonların İndex sayılarının Toplamının 2'ye bölümünden kalan 0 ise Butonun arkaplan Resmi SİYAH olur.
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }

                    //Butonların İndex sayılarının Toplamının 2'ye bölümünden kalan 0 değilse butonun arka plan rengi BEYAZ olur.
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }

                    //This ifadesi Form uygulamasının kendisini ifade Eder.
                    //Özellikleri belirlenmiş Butonu Form'a ekleme
                    this.Controls.Add(buttons[i, j]);
                }

                //Her satırın oluşturulması tamamlandığında butonların oluşturulurken üstten alacağı mesafe 50 birim arttırılırken soladan alacağı mesafe sıfırlanır.
                top += 50;
                left = 0;
            }


        }
    }
}