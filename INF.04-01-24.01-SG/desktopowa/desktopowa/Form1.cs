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

namespace desktopowa
{
    public partial class Form1 : Form
    {
        public string kolor = "", numer = "000";
        public Form1()
        {
            InitializeComponent();
        }

        /*
        **********************************************
        nazwa funkcji: button1_Click
        opis funkcji: po wcisnieciu przycisku aplikacja wyswietli wiadomosc zawierajaca imie, nazwisko i kolor oczu podane w formularzu, badz informacje "wprowadz dane" jezeli nie beda kompletne.
        parametry: -
        zwracany typ i opis: nic nie zwraca
        autor: <numer zdającego>
        ***********************************************
        */
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                MessageBox.Show(textBox2.Text + " " + textBox3.Text + " kolor oczu " + kolor);
            }
            else
            {
                MessageBox.Show("Wprowadź dane");
            }
        }

        /*
**********************************************
nazwa funkcji: radioButton1_CheckedChanged
opis funkcji: pobiera kolor oczu zaznaczony przez uzytkownika
parametry: -
zwracany typ i opis: kolor - kolor oczu wybrany za pomoca radio button
autor: <numer zdającego>
***********************************************
*/
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            kolor = rb.Text;
        }

        /*
**********************************************
nazwa funkcji: Form1_Load
opis funkcji: zmienia wysokosc obrazow oraz automatucznie zaznacza pierwszy radio button
parametry: -
zwracany typ i opis: -
autor: <numer zdającego>
***********************************************
*/
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            radioButton1.Checked = true;
        }

        /*
    **********************************************
    nazwa funkcji:textBox1_Leave
    opis funkcji: po opuszczeniu pierwszego pola tekstowego zmienia zdjecia tak, aby zgadzaly sie z numerem podanym przez uzytkownika
    parametry: numer - wartosc pierwszego pola tekstowego
    zwracany typ i opis: -
    autor: <numer zdającego>
    ***********************************************
    */
        private void textBox1_Leave(object sender, EventArgs e)
        {
            numer = textBox1.Text;
            switch (numer)
            {
                case "000": pictureBox1.Image = Properties.Resources._000_zdjecie; pictureBox2.Image = Properties.Resources._000_odcisk; break;
                case "111": pictureBox1.Image = Properties.Resources._111_zdjecie; pictureBox2.Image = Properties.Resources._111_odcisk; break;
                case "333": pictureBox1.Image = Properties.Resources._333_zdjecie; pictureBox2.Image = Properties.Resources._333_odcisk; break;
                default: pictureBox1.Image = null; break;
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
