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
    public partial class FrmConsDependenteFuncionario : Form
    {
        private MySqlConnection _mySqlConnecion = new MySqlConnection("server=rjo-bcc-c2a-h14;database=salesit;uid=salesit_adm;pwd=salesit_adm");
        public FrmConsDependenteFuncionario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand _mySQLCommand = new MySqlCommand("SELECT NOME,DATA_NASCIMENTO,GRAUPARENTESCO FROM TB_FUNCIONARIO_DEPENDENTES " +
                    "WHERE CODIGO_FUNCIONARIO=" + txtCodigoFuncionario.Text + " AND CODIGO = " + txtCodigoDependente.Text, _mySqlConnecion);
                _mySqlConnecion.Open();
                MySqlDataReader _datareader = _mySQLCommand.ExecuteReader();
                _datareader.Read();
                if (_datareader.HasRows)
                {
                    lbNome.Text = _datareader.GetString("NOME");
                    lbDataNascimento.Text = _datareader.GetDateTime("DATA_NASCIMENTO").ToString("dd/MM/yyyy");
                    lbGrauParentesco.Text = _datareader.GetString("GRAUPARENTESCO");
                }
                else
                {
                    lbNome.Text = String.Empty;
                    lbDataNascimento.Text = String.Empty;
                    lbGrauParentesco.Text = String.Empty;
                    MessageBox.Show("Não foi possível encontrar o dependente informado","Entrada inválida");
                }
            }
            finally
            {
                _mySqlConnecion.Close();
            }
        }
    }
}
