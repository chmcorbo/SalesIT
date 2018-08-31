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
    public partial class FrmConsClientePessoaFisica : Form
    {
        private DALClientePessoaFisica _dalClientePessoaFisica;
        private List<ClientePessoaFisica> _listaClientes;
        private FrmCadClientePessoaFisica _frmCadClientePessoaFisica;

        public FrmConsClientePessoaFisica()
        {
            InitializeComponent();
            _dalClientePessoaFisica = new DALClientePessoaFisica();
            _frmCadClientePessoaFisica = new FrmCadClientePessoaFisica();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (cbfiltro.SelectedItem == null)
            {
                MessageBox.Show("Selecione o filtro", "Entrada Inválida");
            }
            else if (cbfiltro.SelectedIndex == 0) // Código
            {
                try
                {
                    ClientePessoaFisica _cliente = null;
                    _listaClientes = new List<ClientePessoaFisica>();
                    Int32 _codigo = Convert.ToInt32(txtconteudo.Text);
                    _cliente = _dalClientePessoaFisica.ObterPorCodigo(_codigo);
                    if (_cliente == null)
                    {
                        MessageBox.Show("Registro não encontrado");
                    }

                    _listaClientes.Add(_cliente);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("O codigo precisa conter números", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro durante a execução" + ex.Message, "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dtglista.DataSource = _listaClientes;
                }
            }
            else if (cbfiltro.SelectedIndex == 1) // Nome
            {
                String _nome = txtconteudo.Text.ToUpper();
                _listaClientes = _dalClientePessoaFisica.ListarPorNome(_nome);
                dtglista.DataSource = _listaClientes;
            }
            else if (cbfiltro.SelectedIndex == 2) //cpf
            {
                try
                {
                    string _cpf = txtconteudo.Text;
                    _listaClientes = _dalClientePessoaFisica.ObterPorCPF(_cpf);
                    dtglista.DataSource = _listaClientes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro durante a execução" + ex.Message, "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    dtglista.DataSource = _listaClientes;
                }

            }

        }

        private void dtglista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Linha: " + dtglista.Rows[dtglista.CurrentCell.RowIndex].Cells[dtglista.CurrentCell.ColumnIndex].Value);
        }

        private void FrmConsClientePessoaFisica_Load(object sender, EventArgs e)
        {
            cbfiltro.SelectedIndex = 1;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _frmCadClientePessoaFisica.SetCodigo(0);
            _frmCadClientePessoaFisica.SetStatus(0);
            _frmCadClientePessoaFisica.ShowDialog();
        }

        private void dtglista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int _codigo = Convert.ToInt32(dtglista.Rows[dtglista.CurrentCell.RowIndex].Cells[0].Value);

            if (dtglista.Rows[dtglista.CurrentCell.RowIndex].Cells[dtglista.CurrentCell.ColumnIndex].Value.ToString() == "Alterar")
            {
                _frmCadClientePessoaFisica.SetCodigo(_codigo);
                _frmCadClientePessoaFisica.SetStatus(1);
                _frmCadClientePessoaFisica.ShowDialog();
            }
            else if (dtglista.Rows[dtglista.CurrentCell.RowIndex].Cells[dtglista.CurrentCell.ColumnIndex].Value.ToString() == "Excluir")
            {
                if (MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _dalClientePessoaFisica.Excluir(_codigo);
                    btnbuscar_Click(sender, e);
                    MessageBox.Show("Cliente excluído com sucesso");

                }
            }
        }
    }
}