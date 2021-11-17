using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kapkowa_praca_domowa___noob_
{
    internal class klocek
    {
        public int predkosckloca;
        public bool czyDobry;
        public PictureBox picturebox;
        public bool czyBonus;

        public klocek(int predkosckloca, bool czyDobry, PictureBox picturebox, bool czyBonus)
        {
            if (czyDobry)
            {
                picturebox.BackColor = Color.Green;
            }
            else
            {
                picturebox.BackColor = Color.Black;
            }
            if (czyBonus)
            {
                picturebox.BackColor = Color.Yellow;
            }
            this.predkosckloca = predkosckloca;
            this.czyDobry = czyDobry;
            this.picturebox = picturebox;
            this.czyBonus = czyBonus;
        }
    }


}
