using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clSalesIT.Model;
using clSalesIT.DAL;


namespace wfSalesIT
{
    public partial class FrmCadClientePessoaJuridica : Form
    {
        private byte _status;
        private int _codigo;
        private ClientePessoaJuridica _clientePessoaJuridica;
        private DALClientePessoaJuridica _dalClientePessoaJuridica;
        /* 0 - novo, 1 - Alterar */

        public FrmCadClientePessoaJuridica()
        {
            InitializeComponent();
            _dalClientePessoaJuridica = new DALClientePessoaJuridica();
        }

        public FrmCadClientePessoaJuridica(DALClientePessoaJuridica pDalClientePessoaJuridica)
        {
            InitializeComponent();
            _dalClientePessoaJuridica = pDalClientePessoaJuridica;
        }

        public void SetStatus(byte pStatus)
        {
            _status = pStatus; 
        }

        public void SetCodigo(int pCodigo)
        {
            _codigo = pCodigo;
        }

        private void FrmCadClientePessoaJuridica_Load(object sender, EventArgs e)
        {
            if (_status == 0)
            {
                lbStatus.Text = "Incluindo";
                _clientePessoaJuridica = new ClientePessoaJuridica();
                LimparComponentes();
                txtCodigo.Text = _dalClientePessoaJuridica.ProximoCodigo().ToString();
            }
            else if (_status == 1)
            {
                lbStatus.Text = "Alterando";
                _clientePessoaJuridica = _dalClientePessoaJuridica.ObterPorCodigo(_codigo);
                TransferirParaComponentes();
            }
        }

        private Boolean ValidarDados()
        {
            Boolean _dadosvalidos = false;
            DateTime _dataContratoSocial = DateTime.Now.Date;
            try
            {
                _dataContratoSocial = Convert.ToDateTime(txtDataContratoSocial.Text);
            }
            catch
            {
                MessageBox.Show("A data do contrato social é inválida", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return _dadosvalidos;
            }

            if (txtNome.Text==String.Empty)
            {
                MessageBox.Show("Nome do cliente não informado", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return _dadosvalidos;
            }

            if (txtCNPJ.Text == String.Empty)
            {
                MessageBox.Show("CNPJ do cliente não informado", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return _dadosvalidos;
            }

            if (_dataContratoSocial>=DateTime.Now.Date)
            {
                MessageBox.Show("A data do contrato social não pode ser maior que a data atual", 
                    "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return _dadosvalidos;
            }
            _dadosvalidos = true;
            return _dadosvalidos;
        }



        private void TransferirParaObjeto()
        {   
            _clientePessoaJuridica.Codigo = Convert.ToInt32(txtCodigo.Text);
            _clientePessoaJuridica.Nome = txtNome.Text;
            _clientePessoaJuridica.Endereco = txtEndereco.Text;
            _clientePessoaJuridica.Bairro = txtBairro.Text;
            _clientePessoaJuridica.Cidade = txtCidade.Text;
            _clientePessoaJuridica.Estado = txtEstado.Text;
            _clientePessoaJuridica.CNPJ = txtCNPJ.Text;
            _clientePessoaJuridica.InscricaoEstadual = txtIncricaoEstadual.Text;
            _clientePessoaJuridica.DataContratoSocial = Convert.ToDateTime(txtDataContratoSocial.Text);
            _clientePessoaJuridica.DataCadastro = DateTime.Now.Date;
        }

        private void TransferirParaComponentes()
        {
            txtCodigo.Text = _clientePessoaJuridica.Codigo.ToString();
            txtNome.Text = _clientePessoaJuridica.Nome;
            txtEndereco.Text = _clientePessoaJuridica.Endereco;
            txtBairro.Text = _clientePessoaJuridica.Bairro;
            txtCidade.Text = _clientePessoaJuridica.Cidade;
            txtEstado.Text = _clientePessoaJuridica.Estado;
            txtCNPJ.Text = _clientePessoaJuridica.CNPJ;
            txtIncricaoEstadual.Text = _clientePessoaJuridica.InscricaoEstadual;
            txtDataContratoSocial.Text = _clientePessoaJuridica.DataContratoSocial.ToString();
            txtDataCadastro.Text = _clientePessoaJuridica.DataCadastro.ToString();
        }

        private void LimparComponentes()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtCNPJ.Clear();
            txtIncricaoEstadual.Clear();
            txtDataContratoSocial.Clear();
            txtDataCadastro.Clear(); 
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_status==0)
            {
                if (ValidarDados())
                {
                    TransferirParaObjeto();
                    _dalClientePessoaJuridica.Incluir(_clientePessoaJuridica);
                    btnFechar_Click(sender, e);
                }
            }
            else if (_status==1)
            {
                if (ValidarDados())
                {
                    TransferirParaObjeto();
                    _dalClientePessoaJuridica.Alterar(_clientePessoaJuridica);
                    btnFechar_Click(sender, e);
                }
            }
        }

        private void lbStatus_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadClientePessoaJuridica_Shown(object sender, EventArgs e)
        {

        }
    }
}
