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
using wfSalesIT.Excepcoes;

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
                    // Variável de objeto que eu vou usar para obter o objeto a partir do código informado pelo usuário.
                    ClientePessoaJuridica _cliente = null;
                    // Lista de genérica que eu vou usar para o DataGridView precisa para exibir na tela.
                    _listaClientes = new List<ClientePessoaJuridica>();
                    // Varíavel a usada para tratamento de erro para proteger contra o erro do usuário informar um código inválido.
                    Int32 _codigo = Convert.ToInt32(txtConteudo.Text);
                    // Executando a consulta.
                    _cliente = _dalClientePessoaFisica.ObterPorCodigo(_codigo);
                    // Se não retornar nenhum cliente, então eu vou lançar uma exceção para interceptar no catch.
                    if (_cliente == null)
                        throw new ExClienteNaoEncontrado("Não foi possível encontrar nenhum cliente com o código informado.");
                    _listaClientes.Add(_cliente);

                }
                catch (FormatException ex)
                {
                    MessageBox.Show("O código precisa conter números.", "Entrada inválida",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ExClienteNaoEncontrado ex)
                {
                    _listaClientes.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro durante a execução da consulta. "+ex.Message, "Entrada inválida",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dtgLista.DataSource = _listaClientes; 
                }
            }
            else if (cbTipoFiltro.SelectedItem.ToString() == "CNPJ")
            {
                try
                {
                    // Varíavel a usada para tratamento de erro para proteger contra o erro do usuário informar um código inválido.
                    String _cnpj = txtConteudo.Text;
                    // Executando a consulta.
                    _listaClientes = _dalClientePessoaFisica.ObterPorCNPJ(_cnpj);
                    dtgLista.DataSource = _listaClientes;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("O código precisa conter números.", "Entrada inválida",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ExClienteNaoEncontrado ex)
                {
                    _listaClientes.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro durante a execução da consulta. " + ex.Message, "Entrada inválida",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dtgLista.DataSource = _listaClientes;
                }
            }
        }

        private void FrmConsClientePessoaJuridica_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtConteudo;
            cbTipoFiltro.SelectedIndex = 0;
            txtConteudo.Focus();
        }
    }
}
