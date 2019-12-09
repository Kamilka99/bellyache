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
    public partial class Obliczanie : Form
    {
        public Obliczanie()
        {
            InitializeComponent();
            var zap = new Zapis();
            
            for(int i=0; i<255;i++)
            {
                lista1.Items.Add(zap.rejestry[i]);
                lista2.Items.Add(zap.rejestry[i]);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    //    private void Doda_Click(object sender, EventArgs e)
    //    {
    //        long bn1, bn2;

    //        int i = 0, r = 0;
    //        int []sum = new int [8];
          
    //        while (bn1 != 0 || bn2 != 0)
    //        {
    //            sum[i++] = (int)((bn1 % 10 + bn2 % 10 + r) % 2);
    //            r = (int)((bn1 % 10 + bn2 % 10 + r) / 2);
    //            bn1 = bn1 / 10;
    //            bn2 = bn2 / 10;
    //        }
    //        if (r != 0)
    //        {
    //            sum[i++] = r;
    //        }
    //        --i;
    //        while (i >= 0)
    //        {
    //            return (sum[i--]);
    //        }
            
    //    }

    //}
}
}
