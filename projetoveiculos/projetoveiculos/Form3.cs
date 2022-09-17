using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace projetoveiculos
{
    public partial class frmcadcaminhao : Form
    {
        Caminhao caminhao;
        public frmcadcaminhao()
        {
            InitializeComponent();
        }

        private void btncad_Click(object sender, EventArgs e)
        {
            caminhao = new Caminhao(txtmodelo.Text,
                            (Convert.ToInt32(txtquilometragem.Text)),
                            (Convert.ToDouble(txtpreco.Text)),
                            txtmarca.Text,
                            txtdescricao.Text,
                            txtplaca.Text,
                            txtporte.Text,
                            txtplataforma.Text,
                            (Convert.ToInt32(txtnumderodas.Text)));
            txtmodelo.Clear();
            txtquilometragem.Clear();
            txtpreco.Clear();
            txtmarca.Clear();
            txtdescricao.Clear();
            txtplaca.Clear();
            txtporte.Clear();
            txtplataforma.Clear();
            txtnumderodas.Clear();

            MessageBox.Show("Cadastro efetuado com sucesso!");
        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(caminhao.ImprimeDados());
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmhome home = new frmhome();
            this.Hide();
            home.Show();
        }

        private void txtquilometragem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtdescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtmodelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
