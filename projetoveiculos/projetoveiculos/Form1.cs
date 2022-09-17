using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoveiculos
{
    public partial class frmhome : Form
    {
        public frmhome()
        {
            InitializeComponent();
        }

        private void btncadcarro_Click(object sender, EventArgs e)
        {
            frmcadcarro cadcarro = new frmcadcarro();
            this.Hide();
            cadcarro.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmhome_Load(object sender, EventArgs e)
        {

        }

        private void btncadcaminhao_Click(object sender, EventArgs e)
        {
            frmcadcaminhao caminhao = new frmcadcaminhao();
            this.Hide();
            caminhao.Show();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
