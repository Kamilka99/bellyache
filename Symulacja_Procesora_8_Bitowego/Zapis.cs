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
    public partial class Zapis : Form
    {
        public string[] rejestry = new string[255];
        public Zapis()
        {
            InitializeComponent();
            Inicjalizacja();

        }
        void Inicjalizacja()
        {
            int i = 0;
            foreach (string file in Directory.GetFiles(@"C:\Users\Lenovo\Desktop\wyniki\", "*.txt"))
            {
                System.IO.StreamReader fle = new System.IO.StreamReader(file);
                string line;
                line = fle.ReadLine();
                rejestry[i] = line;
                i++;
                fle.Close();
            }
            for (; i < 255; i++)
            {
                rejestry[i] = "";
            }
        }
        string BIN(int x)
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


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int zmienna;
            zmienna = Convert.ToInt32(input.Text);
            wynik.Text = Convert.ToString(BIN(zmienna));
            // System.IO.File.WriteAllText(@"C:\Users\Maciej\Desktop\asd.txt", wynik.Text);
            for (int i = 0; i < 255; i++)
            {
                if (rejestry[i] == "")
                {
                    rejestry[i] = wynik.Text;
                    test.Text = rejestry[i];
                    test2.Text = Convert.ToString(i);
                    System.IO.File.WriteAllText($@"C:\Users\Lenovo\Desktop\wyniki\{i}.txt", test.Text);


                    break;
                }
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}