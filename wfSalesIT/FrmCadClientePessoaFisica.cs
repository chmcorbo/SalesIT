using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clSalesIT.DAL;
using clSalesIT.Model;

namespace wfSalesIT
{
    public partial class FrmCadClientePessoaFisica : Form
    {
        private int _status;
        private int _codigo;
        private ClientePessoaFisica _clientePessoaFisica;
        private DALClientePessoaFisica _dalClientePessoaFisica;


        public FrmCadClientePessoaFisica()
        {
            InitializeComponent();
            _dalClientePessoaFisica = new DALClientePessoaFisica();

        }

        public FrmCadClientePessoaFisica(DALClientePessoaFisica pDalClientePessoaFisica)
        {
            InitializeComponent();
            _dalClientePessoaFisica = pDalClientePessoaFisica;
        }

        public void SetStatus(int pStatus)
        {
            _status = pStatus;
        }

        public void SetCodigo(int pCodigo)
        {
            _codigo = pCodigo;
        }
        private Boolean ValidarDados()
        {
            Boolean _dadosvalidos = false;
            DateTime _datacadastro = DateTime.Now.Date;
            try
            {
                _datacadastro = Convert.ToDateTime(lbDataCadastro.Text);
            }
            catch
            {
                MessageBox.Show("A data do contrato cadastro é inválida", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return _dadosvalidos;
            }

            if (lblNome.Text == String.Empty)
            {
                MessageBox.Show("Nome do cliente não informado", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return _dadosvalidos;
            }

            if (lbCPF.Text == String.Empty)
            {
                MessageBox.Show("CPF do cliente não informado", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return _dadosvalidos;
            }

            if (_datacadastro >= DateTime.Now.Date)
            {
                MessageBox.Show("A data do cadastro não pode ser maior que a data atual",
                    "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return _dadosvalidos;
            }
            _dadosvalidos = true;
            return _dadosvalidos;
        }

        private void TransferirParaObjeto()
        {
            _clientePessoaFisica.Codigo = Convert.ToInt32(lblCodigo.Text);
            _clientePessoaFisica.Nome = lblNome.Text;
            _clientePessoaFisica.Data_Nascimento = Convert.ToDateTime(txtDatadeNascimento.Text);
            _clientePessoaFisica.Endereco = lbEndereco.Text;
            _clientePessoaFisica.Bairro = lbBairro.Text;
            _clientePessoaFisica.Cidade = lbCidade.Text;
            _clientePessoaFisica.Estado = lbEstado.Text;
            _clientePessoaFisica.CPF = lbCPF.Text;
            _clientePessoaFisica.DataCadastro = DateTime.Now.Date;
        }

        private void TransferirdoObejtoParaComponentes()
        {
            txtCodigo.Text = Convert.ToString(_clientePessoaFisica.Codigo);
            txtNome.Text = _clientePessoaFisica.Nome;
            txtDatadeNascimento.Text = Convert.ToString(_clientePessoaFisica.Data_Nascimento);
            txtEndereco.Text = _clientePessoaFisica.Endereco;
            txtBairro.Text = _clientePessoaFisica.Bairro;
            txtCidade.Text = _clientePessoaFisica.Cidade;
            txtEstado.Text = _clientePessoaFisica.Estado;
            txtCPF.Text = _clientePessoaFisica.CPF;
            txtDataCadastro.Text = Convert.ToString(_clientePessoaFisica.DataCadastro);
        }

        private void LimparComponentes()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtDatadeNascimento.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtCPF.Clear();
            txtDataCadastro.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_status == 0)
            {
                if (ValidarDados())
                {
                    TransferirParaObjeto();
                    _dalClientePessoaFisica.Incluir(_clientePessoaFisica);
                    btnFechar_Click(sender, e);
                }
            }
            else if (_status == 1)
            {
                if (ValidarDados())
                {
                    TransferirParaObjeto();
                    _dalClientePessoaFisica.Alterar(_clientePessoaFisica);
                    btnFechar_Click(sender, e);
                }
            }
        }

        private void FrmCadClientePessoaFisica_Load(object sender, EventArgs e)
        {
            if (_status == 0)
            {
                lbStatus.Text = "Incluindo";
                _clientePessoaFisica = new ClientePessoaFisica();
                LimparComponentes();
                txtCodigo.Text = _dalClientePessoaFisica.ProximoCodigo().ToString();
                txtDataCadastro.Text = DateTime.Now.Date.ToString("dd/mm/yyyy");            
            }
            else if (_status == 1)
            {
                lbStatus.Text = "Alterando";
                _clientePessoaFisica = _dalClientePessoaFisica.ObterPorCodigo(_codigo);
                TransferirdoObejtoParaComponentes();

            }

        }
    }
}
