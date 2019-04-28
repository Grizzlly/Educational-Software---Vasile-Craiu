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
    public partial class Cuprins : Form
    {

        Primii_ani Ani = new Primii_ani();
        Scoala_militara_si_de_aviatie Scl = new Scoala_militara_si_de_aviatie();
        Nori_negrii_pe_cerul_Romaniei Nori = new Nori_negrii_pe_cerul_Romaniei();
        Sfarsitul_vietii Sfarsitul = new Sfarsitul_vietii();
        Quiz Qui = new Quiz();
        Bibliografie Bib = new Bibliografie();
        Anexe Anex = new Anexe();

        public static bool[] CapParcurse = new bool[] { false, false, false, false };

        public Cuprins()
        {
            InitializeComponent();
        }

        private void Cuprins_Load(object sender, EventArgs e)
        {
            QuizBox.Enabled = false;
        }

        private void Cuprins_VisibleChanged(object sender, EventArgs e)
        {
            for (int i = 1; i < 4; i++)
            {
                if (CapParcurse[i] != CapParcurse[i - 1] || CapParcurse[i] == false)
                {
                    return;
                }
            }

            QuizCheck.Visible = false;
            QuizCheck.Enabled = false;

            QuizBox.Enabled = true;
        }

        #region Cap1
        private void Cap1_Click(object sender, EventArgs e)
        {
            Hide();
            switch(Ani.ShowDialog())
            {
                case DialogResult.Abort:
                    Show();
                    break;

                case DialogResult.Yes:
                    Cap2_Click(null, EventArgs.Empty);
                    break;
            }
        }

        private void Cap1_MouseEnter(object sender, EventArgs e)
        {
            Cap1.Font = new Font(Cap1.Font.Name, 20, FontStyle.Bold);
        }

        private void Cap1_MouseLeave(object sender, EventArgs e)
        {
            Cap1.Font = new Font(Cap1.Font.Name, 14, FontStyle.Bold);
        }
        #endregion

        #region Cap2
        private void Cap2_Click(object sender, EventArgs e)
        {
            Hide();
            switch (Scl.ShowDialog())
            {
                case DialogResult.Abort:
                    Show();
                    break;

                case DialogResult.No:
                    Cap1_Click(null, EventArgs.Empty);
                    break;

                case DialogResult.Yes:
                    Cap3_Click(null, EventArgs.Empty);
                    break;
            }
        }

        private void Cap2_MouseEnter(object sender, EventArgs e)
        {
            Cap2.Font = new Font(Cap2.Font.Name, 20, FontStyle.Bold);
        }

        private void Cap2_MouseLeave(object sender, EventArgs e)
        {
            Cap2.Font = new Font(Cap2.Font.Name, 14, FontStyle.Bold);
        }
        #endregion

        #region Cap3
        private void Cap3_Click(object sender, EventArgs e)
        {
            Hide();
            switch (Nori.ShowDialog())
            {
                case DialogResult.Abort:
                    Show();
                    break;

                case DialogResult.No:
                    Cap2_Click(null, EventArgs.Empty);
                    break;

                case DialogResult.Yes:
                    Cap4_Click(null, EventArgs.Empty);
                    break;
            }
        }

        private void Cap3_MouseEnter(object sender, EventArgs e)
        {
            Cap3.Font = new Font(Cap3.Font.Name, 20, FontStyle.Bold);
        }

        private void Cap3_MouseLeave(object sender, EventArgs e)
        {
            Cap3.Font = new Font(Cap3.Font.Name, 14, FontStyle.Bold);
        }
        #endregion

        #region Cap4
        private void Cap4_Click(object sender, EventArgs e)
        {
            Hide();
            switch (Sfarsitul.ShowDialog())
            {
                case DialogResult.Abort:
                    Show();
                    break;

                case DialogResult.No:
                    Cap3_Click(null, EventArgs.Empty);
                    break;

                case DialogResult.Yes:
                    Cap5_Click(null, EventArgs.Empty);
                    break;
            }
        }

        private void Cap4_MouseEnter(object sender, EventArgs e)
        {
            Cap4.Font = new Font(Cap4.Font.Name, 20, FontStyle.Bold);
        }

        private void Cap4_MouseLeave(object sender, EventArgs e)
        {
            Cap4.Font = new Font(Cap4.Font.Name, 14, FontStyle.Bold);
        }
        #endregion

        #region Quiz
        private void QuizBox_Click(object sender, EventArgs e)
        {
            Hide();
            Qui.ShowDialog();
            Show();
        }

        private void QuizBoz_MouseEnter(object sender, EventArgs e)
        {
            QuizBox.Font = new Font(QuizBox.Font.Name, 20, FontStyle.Bold);
        }

        private void QuizBox_MouseLeave(object sender, EventArgs e)
        {
            QuizBox.Font = new Font(QuizBox.Font.Name, 14, FontStyle.Bold);
        }
        #endregion

        #region Cap5
        private void Cap5_Click(object sender, EventArgs e)
        {
            Hide();
            Bib.ShowDialog();
            Show();
        }

        private void Cap5_MouseEnter(object sender, EventArgs e)
        {
            Cap5.Font = new Font(Cap5.Font.Name, 20, FontStyle.Bold);
        }

        private void Cap5_MouseLeave(object sender, EventArgs e)
        {
            Cap5.Font = new Font(Cap5.Font.Name, 14, FontStyle.Bold);
        }
        #endregion

        #region Cap6
        private void Cap6_Click(object sender, EventArgs e)
        {
            Hide();
            Anex.ShowDialog();
            Show();
        }

        private void Cap6_MouseEnter(object sender, EventArgs e)
        {
            Cap6.Font = new Font(Cap6.Font.Name, 20, FontStyle.Bold);
        }

        private void Cap6_MouseLeave(object sender, EventArgs e)
        {
            Cap6.Font = new Font(Cap6.Font.Name, 14, FontStyle.Bold);
        }
        #endregion

    }
}
