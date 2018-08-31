using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace wfAcessoDB
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection _oracleConnection = new OracleConnection(@"Data Source=desenv01;User ID=fooadm;Password=fooadm;");
            OracleCommand _oracleCommand = new OracleCommand();
            OracleDataAdapter _oracleDataApdater;
            OracleDataReader _oracleDataReader;

            _oracleCommand.Connection = _oracleConnection;
            _oracleCommand.CommandText = "select * from tb_cliente";
            _oracleDataReader = _oracleCommand.ExecuteReader();

            try
            {
                
                _oracleConnection.Open();
                MessageBox.Show("Conexão realizada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro durante a conexão com o banco de dados. "+ex.Message);
            }
            finally
            {
                _oracleConnection.Close();
            }

        }
    }
}
