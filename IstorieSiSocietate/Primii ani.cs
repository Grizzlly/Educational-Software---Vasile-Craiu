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
    public partial class Primii_ani : Form
    {
        public Primii_ani()
        {
            InitializeComponent();
        }

        private void Primii_ani_Load(object sender, EventArgs e)
        {
            Cuprins.CapParcurse[0] = true;
        }

        private void Primii_ani_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.Yes && DialogResult != DialogResult.No && DialogResult != DialogResult.Abort)
            {
                DialogResult = DialogResult.Abort;
            }
        }
    }
}
