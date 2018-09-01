using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace wfAcessoDB
{
    public partial class FrmConsultarFuncionario : Form
    {
        private MySqlConnection _mySQLConnection = new MySqlConnection("server=localhost;database=salesit;uid=root;pwd=Nqbx2017#");

        public FrmConsultarFuncionario()
        {
            InitializeComponent();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                _mySQLConnection.Open();
                MySqlCommand _mySQLCommand = new MySqlCommand("SELECT MATRICULA, NOME FROM TB_FUNCIONARIO WHERE CODIGO=" + txtcodigo.Text, _mySQLConnection);
                MySqlDataReader _mysqlDataReader = _mySQLCommand.ExecuteReader();

                _mysqlDataReader.Read();
                if (_mysqlDataReader.HasRows)
                {
                    txtMatricula.Text = _mysqlDataReader.GetString("MATRICULA");
                    txtNome.Text = _mysqlDataReader.GetString("NOME");
                }
                else
                {
                    txtMatricula.Clear();
                    txtNome.Clear();
                    MessageBox.Show("Não foi possível encontrar o código digitado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível executar a consulta. " + ex.Message);

            }
            finally
            {
                _mySQLConnection.Close();
            }
            
        }
    }
}
