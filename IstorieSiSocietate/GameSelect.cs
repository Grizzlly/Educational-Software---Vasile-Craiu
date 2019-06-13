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
    public partial class GameSelect : Form
    {
        public enum Jocuri { Spanzuratoarea, Puzzle };
        public Jocuri SelectedJoc { get; set; }
        public GameSelect()
        {
            InitializeComponent();
        }

        private void CloseDialog(DialogResult dr) => DialogResult = dr;

        private void LabelSpanzuratoare_Click(object sender, EventArgs e)
        {
            SelectedJoc = Jocuri.Spanzuratoarea;
            CloseDialog(DialogResult.OK);
        }

        private void LabelPuzzle_Click(object sender, EventArgs e)
        {
            SelectedJoc = Jocuri.Puzzle;
            CloseDialog(DialogResult.OK);
        }
    }
}
