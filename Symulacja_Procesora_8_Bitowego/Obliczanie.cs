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

namespace Symulacja_Procesora_8_Bitowego
{
    public partial class Obliczanie : Form
    {
        public Obliczanie()
        {
            InitializeComponent();
            var zap = new Zapis();

            for (int i = 0; i < 255; i++)
            {
                lista1.Items.Add(zap.rejestry[i]);
                lista2.Items.Add(zap.rejestry[i]);
            }
        }

        string BinNaDec(String liczba)
        { // konwersja z bin na dec
            int dlugosc, dec, b;
            dlugosc = liczba.Length - 1;
            dec = liczba[0] - 48;
            for (int i = 1; i < dlugosc + 1; i++)
            {
                b = liczba[i] - 48;
                dec = dec * 2 + b;
            }
            
            return Convert.ToString(dec);
        }

        string DecNaBin(int x)
        {
            string binarna = "";
            int i = 0;
            int[] tab = new int[8];

            while (x != 0)
            {
                tab[i++] = x % 2;
                x /= 2;
            }

            for (int j = i - 1; j >= 0; j--)
                binarna += tab[j];
            while (binarna.Length < 8)
                binarna = 0 + binarna;
            return binarna;
        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            liczba1.Text = lista1.Text;

        }

        private void Obliczanie_Load(object sender, EventArgs e)
        {
            lista1.Items.AddRange(System.IO.File.ReadAllLines(@"C:\Users\Lenovo\Desktop\wyniki\0.txt"));
            lista2.Items.AddRange(System.IO.File.ReadAllLines(@"C:\Users\Lenovo\Desktop\wyniki\0.txt"));

        }



        private void Liczba1_Click(object sender, EventArgs e)
        {

        }

        private void Lista2_SelectedIndexChanged(object sender, EventArgs e)
        {
            liczba2.Text = lista2.Text;
        }



        private void Doda_Click_1(object sender, EventArgs e)
        {
            Dec1.Text = BinNaDec(liczba1.Text);
            Dec2.Text = BinNaDec(liczba2.Text);
            int zmienna1 = Convert.ToInt32(Dec1.Text), zmienna2 = Convert.ToInt32(Dec2.Text);
            WynDec.Text = Convert.ToString(zmienna1 + zmienna2);

            long bn1 = Convert.ToInt64(liczba1.Text), bn2 = Convert.ToInt64(liczba2.Text);
            long[] wyniczek = new long[8];
            string zmienna = "";
            for (int p = 0; p <= 7; p++)
            { wyniczek[p] = 0; }

            int i = 0, r = 0;
            int[] sum = new int[8];

            while (bn1 != 0 || bn2 != 0)
            {
                sum[i++] = (int)((bn1 % 10 + bn2 % 10 + r) % 2);
                r = (int)((bn1 % 10 + bn2 % 10 + r) / 2);
                bn1 = bn1 / 10;
                bn2 = bn2 / 10;
            }
            if (r != 0)
            {
                sum[i++] = r;
            }
            --i;
            while (i >= 0)
            {
                wyniczek[i] = sum[i--];

            }
            for (int t = 7; t >= 0; t--)
            { zmienna = zmienna + Convert.ToString(wyniczek[t]); }
            wynik.Text = zmienna;
        }

        private void Odejm_Click(object sender, EventArgs e)
        {
            Dec1.Text = BinNaDec(liczba1.Text);
            Dec2.Text = BinNaDec(liczba2.Text);
            int zmienna1 = Convert.ToInt32(Dec1.Text), zmienna2 = Convert.ToInt32(Dec2.Text);
            WynDec.Text = Convert.ToString(zmienna1-zmienna2);

            long bn1 = Convert.ToInt64(liczba1.Text), bn2 = Convert.ToInt64(liczba2.Text);
                long[] wyniczek = new long[8];
                string zmienna = "";
                for (int p = 0; p <= 7; p++)
                { wyniczek[p] = 0; }

                int[] sum = new int[8];
                int i = 0;
                while (bn1 != 0 || bn2 != 0)
                {
                    if ((bn1 % 10 == 0 && bn2 % 10 == 0) || (bn1 % 10 == 1 && bn2 % 10 == 1))
                    {
                        sum[i++] = 0;
                        bn1 = bn1 / 10;
                        bn2 = bn2 / 10;
                    }
                    else if (bn1 % 10 == 1 && bn2 % 10 == 0)
                    {
                        sum[i++] = 1;
                        bn1 = bn1 / 10;
                        bn2 = bn2 / 10;
                    }
                    else if (bn1 % 10 == 0 && bn2 % 10 == 1)
                    {
                        sum[i++] = 1;
                        while (((bn1 / 10)) % 10 != 1)
                        {
                            bn1 = bn1 / 10;
                            bn2 = bn2 / 10;
                            sum[i++] = 0;
                        }
                        bn1 = (bn1 / 10) - 1;
                        bn2 = bn2 / 10;

                    }
                }

                --i;

                while (i >= 0)
                {
                    wyniczek[i] = sum[i--];

                }
                for (int t = 7; t >= 0; t--)
                { zmienna = zmienna + Convert.ToString(wyniczek[t]); }

                wynik.Text = zmienna;
            
        }

        private void Mnoz_Click(object sender, EventArgs e)
        {
            Dec1.Text = BinNaDec(liczba1.Text);
            Dec2.Text = BinNaDec(liczba2.Text);
            int zmienna1 = Convert.ToInt32(Dec1.Text), zmienna2 = Convert.ToInt32(Dec2.Text), wyn;
            wyn = zmienna1 * zmienna2;
            WynDec.Text = Convert.ToString(wyn);
            wynik.Text =DecNaBin(wyn);

        }

        private void Dziel_Click(object sender, EventArgs e)
        {
            Dec1.Text = BinNaDec(liczba1.Text);
            Dec2.Text = BinNaDec(liczba2.Text);
            int zmienna1 = Convert.ToInt32(Dec1.Text), zmienna2 = Convert.ToInt32(Dec2.Text), wyn;
            wyn = zmienna1 / zmienna2;
            WynDec.Text = Convert.ToString(wyn);
            wynik.Text = DecNaBin(wyn);
        }
    }
}


