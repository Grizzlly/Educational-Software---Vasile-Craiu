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
        private readonly Bibliografie Bib = new Bibliografie();
        private readonly Anexe Anex = new Anexe();
        //private readonly JocSpanzuratoarea JocSp = new JocSpanzuratoarea();

        public static bool[] CapParcurse = new bool[] { false, false, false, false };

        public Cuprins()
        {
            InitializeComponent();
        }

        private void Cuprins_Load(object sender, EventArgs e)
        {
            LabelQuizBox.Enabled = false;
            //LabelJocuri.Enabled = false;
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

            LabelQuizCheck.Visible = false;
            LabelQuizCheck.Enabled = false;

            LabelQuizBox.Enabled = true;
            LabelJocuri.Enabled = true;
        }

        #region Cap1
        private void Cap1_Click(object sender, EventArgs e)
        {
            Hide();
            using (Primii_ani primii_Ani = new Primii_ani())
            {
                switch (primii_Ani.ShowDialog())
                {
                    case DialogResult.Abort:
                        Show();
                        break;

                    case DialogResult.Yes:
                        Cap2_Click(null, EventArgs.Empty);
                        break;
                }
            }
        }

        private void Cap1_MouseEnter(object sender, EventArgs e)
        {
            LabelCap1.Font = new Font(LabelCap1.Font.Name, 20, FontStyle.Bold);
        }

        private void Cap1_MouseLeave(object sender, EventArgs e)
        {
            LabelCap1.Font = new Font(LabelCap1.Font.Name, 14, FontStyle.Bold);
        }
        #endregion

        #region Cap2
        private void Cap2_Click(object sender, EventArgs e)
        {
            Hide();
            using (Scoala_militara_si_de_aviatie scoala = new Scoala_militara_si_de_aviatie())
            {
                switch (scoala.ShowDialog())
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
        }

        private void Cap2_MouseEnter(object sender, EventArgs e)
        {
            LabelCap2.Font = new Font(LabelCap2.Font.Name, 20, FontStyle.Bold);
        }

        private void Cap2_MouseLeave(object sender, EventArgs e)
        {
            LabelCap2.Font = new Font(LabelCap2.Font.Name, 14, FontStyle.Bold);
        }
        #endregion

        #region Cap3
        private void Cap3_Click(object sender, EventArgs e)
        {
            Hide();
            using (Nori_negrii_pe_cerul_Romaniei nori = new Nori_negrii_pe_cerul_Romaniei())
            {
                switch (nori.ShowDialog())
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
        }

        private void Cap3_MouseEnter(object sender, EventArgs e)
        {
            LabelCap3.Font = new Font(LabelCap3.Font.Name, 20, FontStyle.Bold);
        }

        private void Cap3_MouseLeave(object sender, EventArgs e)
        {
            LabelCap3.Font = new Font(LabelCap3.Font.Name, 14, FontStyle.Bold);
        }
        #endregion

        #region Cap4
        private void Cap4_Click(object sender, EventArgs e)
        {
            Hide();
            using (Sfarsitul_vietii sfarsitul = new Sfarsitul_vietii())
            {
                switch (sfarsitul.ShowDialog())
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
        }

        private void Cap4_MouseEnter(object sender, EventArgs e)
        {
            LabelCap4.Font = new Font(LabelCap4.Font.Name, 20, FontStyle.Bold);
        }

        private void Cap4_MouseLeave(object sender, EventArgs e)
        {
            LabelCap4.Font = new Font(LabelCap4.Font.Name, 14, FontStyle.Bold);
        }
        #endregion

        #region Quiz
        private void QuizBox_Click(object sender, EventArgs e)
        {
            Hide();
            using(Quiz quiz = new Quiz())
            {
                quiz.ShowDialog();
            }
            Show();
        }

        private void QuizBoz_MouseEnter(object sender, EventArgs e)
        {
            LabelQuizBox.Font = new Font(LabelQuizBox.Font.Name, 20, FontStyle.Bold);
        }

        private void QuizBox_MouseLeave(object sender, EventArgs e)
        {
            LabelQuizBox.Font = new Font(LabelQuizBox.Font.Name, 14, FontStyle.Bold);
        }
        #endregion

        #region Cap5
        private void Cap5_Click(object sender, EventArgs e)
        {
            Hide();
            using (Bibliografie bibliografie = new Bibliografie())
            {
                bibliografie.ShowDialog();
            }
            Bib.ShowDialog();
            Show();
        }

        private void Cap5_MouseEnter(object sender, EventArgs e)
        {
            LabelCap5.Font = new Font(LabelCap5.Font.Name, 20, FontStyle.Bold);
        }

        private void Cap5_MouseLeave(object sender, EventArgs e)
        {
            LabelCap5.Font = new Font(LabelCap5.Font.Name, 14, FontStyle.Bold);
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
            LabelCap6.Font = new Font(LabelCap6.Font.Name, 20, FontStyle.Bold);
        }

        private void Cap6_MouseLeave(object sender, EventArgs e)
        {
            LabelCap6.Font = new Font(LabelCap6.Font.Name, 14, FontStyle.Bold);
        }
        #endregion

        #region Jocuri

        private void LabelJocuri_Click(object sender, EventArgs e)
        {
            using (GameSelect GameSelector = new GameSelect())
            {
                Hide();
                if (GameSelector.ShowDialog() == DialogResult.OK)
                {
                    switch (GameSelector.SelectedJoc)
                    {
                        case GameSelect.Jocuri.Spanzuratoarea:
                            using (JocSpanzuratoarea JocSp = new JocSpanzuratoarea())
                            {
                                JocSp.ShowDialog();
                            }
                            break;

                        case GameSelect.Jocuri.Puzzle:
                            using (JocPuzzle JocP = new JocPuzzle())
                            {
                                JocP.ShowDialog();
                            }
                            break;

                        default: break;
                    }
                }
                Show();
            }
        }

        #endregion
    }
}
