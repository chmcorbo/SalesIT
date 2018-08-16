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


namespace wfSalesIT
{
    public partial class FrmCadClientePessoaJuridica : Form
    {
        private byte _status;
        private int _codigo;
        private DALClientePessoaJuridica _dalClientePessoaJuridica;
        /* 0 - novo, 1 - Alterar */

        public FrmCadClientePessoaJuridica()
        {
            InitializeComponent();
            _dalClientePessoaJuridica = new DALClientePessoaJuridica();
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
                txtCodigo.Text = _dalClientePessoaJuridica.ProximoCodigo().ToString();
            }
            else if (_status == 1)
                lbStatus.Text = "Alterando";

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void lbStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
