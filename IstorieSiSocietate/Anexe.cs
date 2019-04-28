using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace IstorieSiSocietate
{
    public partial class Anexe : Form
    {

        private Image[] Imagini = Directory.GetFiles("Imagini").Select(file => Image.FromFile(file)).ToArray();
        private string[] ImgPath = Directory.GetFiles("Imagini");

        private int MainCounter = 0;
        private int NrImag = Directory.GetFiles("Imagini").Length-1;

        public Anexe()
        {
            InitializeComponent();
        }

        private void Anexe_Load(object sender, EventArgs e)
        {
            MainPicBox.Image = Imagini[0];
            NextPicBox.Image = Imagini[1];

            PrevBtn.Enabled = false;

            Debug.Print(NrImag.ToString());
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            if(MainCounter > 0)
            {
                MainCounter--;

                if(MainCounter != 0)
                {
                    LastPicBox.Image = Imagini[MainCounter - 1];
                }
                else
                {
                    PrevBtn.Enabled = false;
                    LastPicBox.Image = null;
                }
                MainPicBox.Image = Imagini[MainCounter];
                NextPicBox.Image = Imagini[MainCounter + 1];

                NextBtn.Enabled = true;
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (MainCounter < NrImag)
            {

                MainCounter++;

                LastPicBox.Image = Imagini[MainCounter-1];
                MainPicBox.Image = Imagini[MainCounter];
                if (MainCounter != NrImag)
                {
                    NextPicBox.Image = Imagini[MainCounter + 1];
                }
                else
                {
                    NextBtn.Enabled = false;
                    NextPicBox.Image = null;
                }

                PrevBtn.Enabled = true;
            }
        }

        private void MainPicBox_DoubleClick(object sender, EventArgs e)
        {
            Process.Start(ImgPath[MainCounter]);
        }
    }
}
