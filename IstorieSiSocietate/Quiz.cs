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
    public partial class Quiz : Form
    {
        private readonly RadioButton[] Raspunsuri = new RadioButton[6];

        public Quiz()
        {
            InitializeComponent();
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            Raspunsuri[0] = R12;
            Raspunsuri[1] = R23;
            Raspunsuri[2] = R31;
            Raspunsuri[3] = R41;
            Raspunsuri[4] = R54;
            Raspunsuri[5] = r61;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            double punctaj = 0;

            foreach(RadioButton rb in Raspunsuri)
            {
                if (rb.Checked)
                {
                    punctaj += 1.5;
                }
            }

            MessageBox.Show($"Ai obținut {punctaj+1} din 10!", "Rezultat");
        }
    }
}
