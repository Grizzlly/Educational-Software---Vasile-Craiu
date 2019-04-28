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
    public partial class Sfarsitul_vietii : Form
    {
        public Sfarsitul_vietii()
        {
            InitializeComponent();
        }

        private void Sfarsitul_vietii_Load(object sender, EventArgs e)
        {
            Cuprins.CapParcurse[3] = true;
        }

        private void Sfarsitul_vietii_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.Yes && DialogResult != DialogResult.No && DialogResult != DialogResult.Abort)
            {
                DialogResult = DialogResult.Abort;
            }
        }
    }
}
