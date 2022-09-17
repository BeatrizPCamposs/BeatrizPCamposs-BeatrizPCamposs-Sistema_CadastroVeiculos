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
    public partial class frmcadcarro : Form
    {
        Carro carro;
        public frmcadcarro()
        {
            InitializeComponent();
        }

        private void btncad_Click(object sender, EventArgs e)
        {
            carro = new Carro(txtmodelo.Text,
                              (Convert.ToInt32(txtquilometragem.Text)),
                              (Convert.ToDouble(txtpreco.Text)),
                              txtmarca.Text,
                              txtdescricao.Text,
                              txtplaca.Text,
                              (Convert.ToInt32(txtqtdpassageiros.Text)),
                              (Convert.ToInt32(txtnumportas.Text)),
                              (Convert.ToInt32(txtcapportamalas.Text)),
                              txtcarroceria.Text);
            txtmodelo.Clear();
            txtquilometragem.Clear();
            txtpreco.Clear();
            txtmarca.Clear();
            txtdescricao.Clear();
            txtplaca.Clear();
            txtqtdpassageiros.Clear();
            txtnumportas.Clear();
            txtcapportamalas.Clear();
            txtcarroceria.Clear();

            MessageBox.Show("Cadastro efetuado com sucesso!");
        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(carro.ImprimeDados());
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmhome home = new frmhome();
            this.Hide();
            home.Show();
        }

        private void frmcadcarro_Load(object sender, EventArgs e)
        {

        }
    }
}
