using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wfSalesIT
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsClientePessoaJuridica _frmConsClientePessoaJuridica = new FrmConsClientePessoaJuridica();
            _frmConsClientePessoaJuridica.ShowDialog();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que quer sair da aplicação?","Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
                e.Cancel = true;
        }

        private void clientePessoalJurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsClientePessoaJuridica _frmConsClientePessoaJuridica = new FrmConsClientePessoaJuridica();
            _frmConsClientePessoaJuridica.ShowDialog();
        }
             
    }
}
