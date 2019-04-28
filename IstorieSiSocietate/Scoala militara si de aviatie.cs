using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IstorieSiSocietate
{
    public partial class Scoala_militara_si_de_aviatie : Form
    {
        public Scoala_militara_si_de_aviatie()
        {
            InitializeComponent();
        }

        private void Scoala_militara_si_de_aviatie_Load(object sender, EventArgs e)
        {
            Cuprins.CapParcurse[1] = true;
        }

        private void Scoala_militara_si_de_aviatie_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.Yes && DialogResult != DialogResult.No && DialogResult != DialogResult.Abort)
            {
                DialogResult = DialogResult.Abort;
            }
        }
    }
}
