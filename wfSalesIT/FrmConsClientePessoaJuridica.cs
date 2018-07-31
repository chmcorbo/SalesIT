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
    public partial class FrmConsClientePessoaJuridica : Form
    {
        public FrmConsClientePessoaJuridica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String x, y;
            x = "BCC";
            y = x;
            y = "Claro";
            label1.Text = x;
            label2.Text = y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Config _configX = new Config();
            Config _configY = _configX;

            _configX.Nome = "BCC";
            // _configY = _configX;
            _configY.Nome = "Claro";

            _configX.Nome = "Net";
            label1.Text = _configX.Nome;
            label2.Text = _configY.Nome;

        }
    }
}
