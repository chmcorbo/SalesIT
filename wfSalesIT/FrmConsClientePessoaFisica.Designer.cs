namespace wfSalesIT
{
    partial class FrmConsClientePessoaFisica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbfiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtconteudo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dtglista = new System.Windows.Forms.DataGridView();
            this.clientePessoaFisicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnfechar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtglista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientePessoaFisicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbfiltro
            // 
            this.cbfiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfiltro.FormattingEnabled = true;
            this.cbfiltro.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "CPF"});
            this.cbfiltro.Location = new System.Drawing.Point(12, 25);
            this.cbfiltro.Name = "cbfiltro";
            this.cbfiltro.Size = new System.Drawing.Size(121, 21);
            this.cbfiltro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro";
            // 
            // txtconteudo
            // 
            this.txtconteudo.BackColor = System.Drawing.Color.White;
            this.txtconteudo.Location = new System.Drawing.Point(139, 27);
            this.txtconteudo.Name = "txtconteudo";
            this.txtconteudo.Size = new System.Drawing.Size(278, 20);
            this.txtconteudo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Conteúdo";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(540, 27);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 4;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dtglista
            // 
            this.dtglista.AllowUserToAddRows = false;
            this.dtglista.AllowUserToDeleteRows = false;
            this.dtglista.AutoGenerateColumns = false;
            this.dtglista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.Alterar,
            this.Excluir});
            this.dtglista.DataSource = this.clientePessoaFisicaBindingSource;
            this.dtglista.Location = new System.Drawing.Point(15, 53);
            this.dtglista.Name = "dtglista";
            this.dtglista.ReadOnly = true;
            this.dtglista.Size = new System.Drawing.Size(686, 304);
            this.dtglista.TabIndex = 6;
            this.dtglista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglista_CellClick);
            this.dtglista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglista_CellContentClick);
            // 
            // clientePessoaFisicaBindingSource
            // 
            this.clientePessoaFisicaBindingSource.DataSource = typeof(clSalesIT.Model.ClientePessoaFisica);
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(626, 373);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(75, 23);
            this.btnfechar.TabIndex = 7;
            this.btnfechar.Text = "fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(621, 27);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Alterar
            // 
            this.Alterar.HeaderText = "";
            this.Alterar.Name = "Alterar";
            this.Alterar.ReadOnly = true;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseColumnTextForButtonValue = true;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseColumnTextForButtonValue = true;
            // 
            // FrmConsClientePessoaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 408);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.dtglista);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtconteudo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbfiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsClientePessoaFisica";
            this.Text = "Consulta Cliente Pessoa Fisica";
            this.Load += new System.EventHandler(this.FrmConsClientePessoaFisica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientePessoaFisicaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbfiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtconteudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView dtglista;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.BindingSource clientePessoaFisicaBindingSource;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Alterar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
    }
}