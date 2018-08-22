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
        private DALClientePessoaJuridica _dalClientePessoaJuridica;
        private List<ClientePessoaJuridica> _listaClientes;
        private FrmCadClientePessoaJuridica frmCadClientePessoaJuridica;

        public FrmConsClientePessoaJuridica()
        {
            InitializeComponent();
            _dalClientePessoaJuridica = new DALClientePessoaJuridica();
            frmCadClientePessoaJuridica = new FrmCadClientePessoaJuridica(_dalClientePessoaJuridica);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbTipoFiltro.SelectedItem == null)
            {
                MessageBox.Show("Informe o tipo de filtro desejado.", "Entrada inválida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbTipoFiltro.SelectedItem.ToString() == "Nome")
            {
                String _nome = txtConteudo.Text;
                _listaClientes = _dalClientePessoaJuridica.ListarPorNome(_nome);
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
                    _cliente = _dalClientePessoaJuridica.ObterPorCodigo(_codigo);
                    // Se não retornar nenhum cliente, então eu vou lançar uma exceção para interceptar no catch.
                    if (_cliente == null)
                    {
                        MessageBox.Show("Não possível encontrar nenhum registro");
                    }

                    _listaClientes.Add(_cliente);

                }
                catch (FormatException ex)
                {
                    MessageBox.Show("O código precisa conter números.", "Entrada inválida",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (cbTipoFiltro.SelectedItem.ToString() == "CNPJ")
            {
                try
                {
                    // Varíavel a usada para tratamento de erro para proteger contra o erro do usuário informar um código inválido.
                    String _cnpj = txtConteudo.Text;
                    // Executando a consulta.
                    _listaClientes = _dalClientePessoaJuridica.ObterPorCNPJ(_cnpj);
                    dtgLista.DataSource = _listaClientes;
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
            // Põe o foco do curso na caixa de texto "conteúdo"
            this.ActiveControl = txtConteudo;
            // Seleciona por padrão o tipo de filtro "nome"
            cbTipoFiltro.SelectedIndex = 0;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadClientePessoaJuridica.SetCodigo(0);
            frmCadClientePessoaJuridica.SetStatus(0);
            frmCadClientePessoaJuridica.ShowDialog();
        }

        private void dtgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int _codigo = Convert.ToInt32(dtgLista.Rows[dtgLista.CurrentCell.RowIndex].Cells[0].Value);

            if (dtgLista.Rows[dtgLista.CurrentCell.RowIndex].Cells[dtgLista.CurrentCell.ColumnIndex].Value.ToString() == "Alterar")
            {
                frmCadClientePessoaJuridica.SetStatus(1);// Status de alteração;
                frmCadClientePessoaJuridica.SetCodigo(_codigo);
                frmCadClientePessoaJuridica.ShowDialog();
            }
            else if (dtgLista.Rows[dtgLista.CurrentCell.RowIndex].Cells[dtgLista.CurrentCell.ColumnIndex].Value.ToString() == "Excluir")
            {
                if (MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _dalClientePessoaJuridica.Excluir(_codigo);
                    btnBuscar_Click(sender, e);
                    MessageBox.Show("Cliente excluído com sucesso");
                }
            }
        }
    }
}
