using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IstorieSiSocietate
{
    public partial class Nori_negrii_pe_cerul_Romaniei : Form
    {
        public Nori_negrii_pe_cerul_Romaniei()
        {
            InitializeComponent();
        }

        private void Nori_negrii_pe_cerul_Romaniei_Load(object sender, EventArgs e)
        {
            Cuprins.CapParcurse[2] = true;
        }

        private void Nori_negrii_pe_cerul_Romaniei_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.Yes && DialogResult != DialogResult.No && DialogResult != DialogResult.Abort)
            {
                DialogResult = DialogResult.Abort;
            }
        }
    }
}
