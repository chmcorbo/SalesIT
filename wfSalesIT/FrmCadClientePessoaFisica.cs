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
    public partial class FrmCadClientePessoaFisica : Form
    {
        private int _status;
        private int _codigo;
        private DALClientePessoaFisica _dalClientePessoaFisica;

        public FrmCadClientePessoaFisica()
        {
            InitializeComponent();
            DALClientePessoaFisica _dalClientePessoaFisica;

        }

        public void SetStatus(int pStatus)
        {
            _status = pStatus;
        }

        public void SetCodigo(int pCodigo)
        {
            _codigo = pCodigo;
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadClientePessoaFisica_Load(object sender, EventArgs e)
        {
            if (_status == 0)
                lbStatus.Text = "Incluindo";
            else if (_status == 1)
                lbStatus.Text = "Alterando";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
