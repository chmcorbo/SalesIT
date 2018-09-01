using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace wfAcessoDB
{
    public partial class FrmMySQL : Form
    {
        private MySqlConnection _mySQLConnection = new MySqlConnection("server=localhost;database=salesit;uid=root;pwd=Nqbx2017#");

        public FrmMySQL()
        {
            InitializeComponent();
        }

        private void btnMySQL_Click(object sender, EventArgs e)
        {
            

            try
            {
                _mySQLConnection.Open();
                MessageBox.Show("Conexão realizada com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados. " +Environment.NewLine+ex.Message);
            }
            finally
            {
                _mySQLConnection.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _mySQLConnection.Open();
                DataSet ds = new DataSet();
                
              
                MySqlCommand _mySQLCommand = new MySqlCommand("select * from tb_funcionario", _mySQLConnection);

                MySqlDataAdapter _mysqlDataAdapter = new MySqlDataAdapter(_mySQLCommand);


                _mysqlDataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar a consulta no banco de dados. " + ex.Message);
            }
            finally
            {
                _mySQLConnection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _mySQLConnection.Close();
        }
    }
}
