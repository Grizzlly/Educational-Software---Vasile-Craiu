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

        #region Spanzuratoarea
        private void LabelSpanzuratoare_Click(object sender, EventArgs e)
        {
            SelectedJoc = Jocuri.Spanzuratoarea;
            CloseDialog(DialogResult.OK);
        }

        private void LabelSpanzuratoare_MouseEnter(object sender, EventArgs e)
        {
            labelSpanzuratoare.Font = new Font(labelSpanzuratoare.Font.Name, 16, labelSpanzuratoare.Font.Style);
        }

        private void LabelSpanzuratoare_MouseLeave(object sender, EventArgs e)
        {
            labelSpanzuratoare.Font = new Font(labelSpanzuratoare.Font.Name, 14, labelSpanzuratoare.Font.Style);
        }
        #endregion

        #region Puzzle
        private void LabelPuzzle_Click(object sender, EventArgs e)
        {
            SelectedJoc = Jocuri.Puzzle;
            CloseDialog(DialogResult.OK);
        }

        private void LabelPuzzle_MouseEnter(object sender, EventArgs e)
        {
            labelPuzzle.Font = new Font(labelPuzzle.Font.Name, 16, labelPuzzle.Font.Style);
        }

        private void LabelPuzzle_MouseLeave(object sender, EventArgs e)
        {
            labelPuzzle.Font = new Font(labelPuzzle.Font.Name, 14, labelPuzzle.Font.Style);
        }
        #endregion
    }
}
