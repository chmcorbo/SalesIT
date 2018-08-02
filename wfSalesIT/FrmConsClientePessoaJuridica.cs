using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clSalesIT.DAL;
using clSalesIT.Model;

namespace wfSalesIT
{
    public partial class FrmConsClientePessoaJuridica : Form
    {
        private DALClientePessoaJuridica _dalClientePessoaFisica;
        private List<ClientePessoaJuridica> _listaClientes;


        public FrmConsClientePessoaJuridica()
        {
            InitializeComponent();
            _dalClientePessoaFisica = new DALClientePessoaJuridica();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbTipoFiltro.SelectedItem==null)
            {
                MessageBox.Show("Informe o tipo de filtro desejado.", "Entrada inválida", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbTipoFiltro.SelectedItem.ToString()=="Nome")
            {
                String _nome = txtConteudo.Text;
                _listaClientes = _dalClientePessoaFisica.ListarPorNome(_nome);
                dtgLista.DataSource = _listaClientes;
            }
            else if (cbTipoFiltro.SelectedItem.ToString() == "Código")
            {
                try
                {
                    Int32 _codigo = Convert.ToInt32(txtConteudo.Text);
                    _listaClientes = new List<ClientePessoaJuridica>();
                    _listaClientes.Add(_dalClientePessoaFisica.ObterPorCodigo(_codigo));
                    dtgLista.DataSource = _listaClientes;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("O código precisa conter números.", "Entrada inválida",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro durante a execução da consulta. "+ex.Message, "Entrada inválida",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (cbTipoFiltro.SelectedItem.ToString() == "CNPJ")
            {
                String _cnpj = txtConteudo.Text;
                _listaClientes = new List<ClientePessoaJuridica>();
                _listaClientes.Add(_dalClientePessoaFisica.ObterPorCNPJ(_cnpj));
                dtgLista.DataSource = _listaClientes;
            }
        }
    }
}
