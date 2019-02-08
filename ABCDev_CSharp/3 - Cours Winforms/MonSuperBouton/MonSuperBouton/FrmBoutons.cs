using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonSuperBouton
{
    public partial class FrmBoutons : Form
    {
        public FrmBoutons()
        {
            InitializeComponent();
        }

        private void FrmBoutons_Load(object sender, EventArgs e)
        {

        }

        private void btnSuperBouton_Click(object sender, EventArgs e)
        {
            Button monBouton2 = sender as Button;

            if (monBouton2 != null)
            {
                monBouton2.Text = "Bonjour !";
            }

            btnCible.Visible = true;

            btnCible.Height = btnSuperBouton.Height;
            btnCible.Width = btnSuperBouton.Width;

            btnCible.Location = new Point((this.Width - btnCible.Width - 30), btnCible.Location.Y);
            timerCible.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnCible.Location = new Point(btnCible.Location.X, btnCible.Location.Y + 10);
        }
    }
}
