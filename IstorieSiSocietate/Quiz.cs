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
        private RadioButton[] Raspunsuri = new RadioButton[5];

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
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            uint punctaj = 0;

            foreach(RadioButton rb in Raspunsuri)
            {
                if (rb.Checked) punctaj+=2;
            }

            MessageBox.Show($"Ai obtinut {punctaj} din 10!", "Rezultat");
        }
    }
}
