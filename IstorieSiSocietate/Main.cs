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
    public partial class Main : Form
    {

        private Cuprins CuprinsForm = new Cuprins();

        public Main()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            Hide();
            CuprinsForm.ShowDialog();
            Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
