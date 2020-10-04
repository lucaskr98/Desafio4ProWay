using Desafio4ProWay.Entidades;
using Desafio4ProWay.Services;
using System;
using System.Windows.Forms;

namespace Desafio4ProWay
{
    public partial class frmCadastroJogos : Form
    {

        private readonly frmListagemJogos _frmListagemJogos;
        public frmCadastroJogos()
        {
            InitializeComponent();
        }

        public frmCadastroJogos(frmListagemJogos frmListagemJogos)
        {
            InitializeComponent();
            _frmListagemJogos = frmListagemJogos;
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            try
            {


            JogoService service = new JogoService();

            int recordeminimo = service.ObterRecordeMinimo();
            int recordemaximo = service.ObterRecordeMaximo();
            int placarminimo = service.ObterPlacarMinimo();
            int placarmaximo = service.ObterPlacarMaximo();
            int placar = Convert.ToInt32(txtPlacar.Text);

            JogoBE novoJogo = new JogoBE(placar);
            novoJogo.QuebraRecordeMinimo = recordeminimo;
            novoJogo.QuebraRecordeMaximo = recordemaximo;
            if (placar < placarminimo || placarminimo == 0)
            {
                novoJogo.MinimoTemporada = placar;
                if (placarminimo != 0)
                {
                    novoJogo.QuebraRecordeMinimo++;
                }
            }
            else
            {
                novoJogo.MinimoTemporada = placarminimo;
            }

            if (placar > placarmaximo)
            {
                novoJogo.MaximoTemporada = placar;
                if (placarmaximo != 0)
                {
                    novoJogo.QuebraRecordeMaximo++;
                }
            }
            else
            {
                novoJogo.MaximoTemporada = placarmaximo;
            }

            service.CadastrarNovoJogo(novoJogo);
            _frmListagemJogos.CarregarListaJogos();
            this.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message,"Erro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
