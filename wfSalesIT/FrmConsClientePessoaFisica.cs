﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfSalesIT
{
    public partial class FrmConsClientePessoaFisica : Form

        private DALClientePessoaFisica _dalClientePessoaFisica;
        private List<ClientePessoaFisicaca> _listaClientes;

        public FrmConsClientePessoaFisica()
        {
            InitializeComponent();
            _dalClientePessoaFisica= new DALClientePessoaFisica();
        }

    {
        public FrmConsClientePessoaFisica()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
