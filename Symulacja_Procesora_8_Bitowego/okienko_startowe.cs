using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symulacja_Procesora_8_Bitowego
{
    public partial class Symulacja : Form
    {
        private Czytanie czyt = new Czytanie();
        public Symulacja()                          // już było, nie ruszać
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)     //to też
        {

        }

        private void button1_Click(object sender, EventArgs e)      //kliknięcie przycisku
        {
            var cal = new Calosc();                         //Tworze zmienną, dzięki której otworze nowe okienko
            cal.ShowDialog();                               //Otwieram okienko cal, czyli calosc
        }

        private void button2_Click(object sender, EventArgs e)      //kliknięcie przycisku
        {
            var czyt = new Czytanie();                      //Tworze zmienną, dzięki której otworze nowe okienko
            czyt.ShowDialog();                               //Otwieram okienko Czytanie, czyli czytanie z rejestru
        }

        private void button3_Click(object sender, EventArgs e)      //kliknięcie przycisku
        {
            var obl = new Obliczanie();                     //Tworze zmienną, dzięki której otworze nowe okienko
            obl.ShowDialog();                               //Otwieram okienko Czytanie, czyli czytanie z rejestru
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var zap = new Zapis();                          //Tworze zmienną, dzięki której otworze nowe okienko
            zap.ShowDialog();                               //Otwieram okienko Czytanie, czyli czytanie z rejestru
        }
    }
}
