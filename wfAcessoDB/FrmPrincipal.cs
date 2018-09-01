using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfAcessoDB
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTesteConexao_Click(object sender, EventArgs e)
        {
            FrmMySQL _frmMySQL = new FrmMySQL();
            _frmMySQL.ShowDialog();
        }

        private void btnConsultarFuncionario_Click(object sender, EventArgs e)
        {
            FrmConsultarFuncionario _frmConsultarFuncionario = new FrmConsultarFuncionario();
            _frmConsultarFuncionario.ShowDialog();

        }
    }
}
