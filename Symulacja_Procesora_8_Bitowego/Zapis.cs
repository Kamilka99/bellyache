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
        //FileStream fs = new FileStream("dane.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        string binarna;
        public Zapis()
        {
            InitializeComponent();
        }
        string BIN(int x)
        {
            string binarna= "";
            int i = 0;
            int[] tab = new int [8];

            while (x != 0)
            {
                tab[i++] = x % 2;
                x /= 2;
            }

            for (int j = i - 1; j >= 0; j--)
                binarna =binarna+ tab[j];
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
            FileStream fs = new FileStream("dane.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            int zmienna;
            zmienna = Convert.ToInt32(input.Text);
            fs.WriteByte(Convert.ToByte("asd"));
            wynik.Text = Convert.ToString(BIN(zmienna));
            for (int i = 0; i<255;i++)
            {
                if (rejestry[i]=="00000000")
                {
                    rejestry[i] = wynik.Text;
                    Console.WriteLine(wynik.Text + " " + i);
                    test.Text = rejestry[i];
                    test2.Text = Convert.ToString(i);
                    break;
                }
            }
            fs.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
