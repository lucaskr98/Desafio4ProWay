using Desafio4ProWay.Services;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Desafio4ProWay
{
    public partial class frmListagemJogos : Form
    {
        public frmListagemJogos()
        {
            Database x = new Database();
            x.CriarTabelasBancoDeDados();
            InitializeComponent();
            CarregarListaJogos();
        }

        public void CarregarListaJogos()
        {
            JogoService service = new JogoService();
            dgJogos.DataSource =  service.ObterJogosCadastrados();
        }

        private void btnAdicionarJogo_Click(object sender, EventArgs e)
        {
            frmCadastroJogos frm = new frmCadastroJogos(this);
            frm.Show();
        }

        private void frmListagemJogos_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            JogoService service = new JogoService();
            service.DeletarDados();
            CarregarListaJogos();
        }
    }
}
