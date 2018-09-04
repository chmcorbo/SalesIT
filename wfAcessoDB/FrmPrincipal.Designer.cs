namespace wfAcessoDB
{
    partial class FrmPrincipal
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
            this.btnTesteConexao = new System.Windows.Forms.Button();
            this.btnConsultarFuncionario = new System.Windows.Forms.Button();
            this.btnConsultarDependente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTesteConexao
            // 
            this.btnTesteConexao.Location = new System.Drawing.Point(106, 50);
            this.btnTesteConexao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTesteConexao.Name = "btnTesteConexao";
            this.btnTesteConexao.Size = new System.Drawing.Size(164, 19);
            this.btnTesteConexao.TabIndex = 0;
            this.btnTesteConexao.Text = "Teste de conexão";
            this.btnTesteConexao.UseVisualStyleBackColor = true;
            this.btnTesteConexao.Click += new System.EventHandler(this.btnTesteConexao_Click);
            // 
            // btnConsultarFuncionario
            // 
            this.btnConsultarFuncionario.Location = new System.Drawing.Point(106, 73);
            this.btnConsultarFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultarFuncionario.Name = "btnConsultarFuncionario";
            this.btnConsultarFuncionario.Size = new System.Drawing.Size(164, 19);
            this.btnConsultarFuncionario.TabIndex = 1;
            this.btnConsultarFuncionario.Text = "Consultar Funcionário";
            this.btnConsultarFuncionario.UseVisualStyleBackColor = true;
            this.btnConsultarFuncionario.Click += new System.EventHandler(this.btnConsultarFuncionario_Click);
            // 
            // btnConsultarDependente
            // 
            this.btnConsultarDependente.Location = new System.Drawing.Point(106, 96);
            this.btnConsultarDependente.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarDependente.Name = "btnConsultarDependente";
            this.btnConsultarDependente.Size = new System.Drawing.Size(164, 19);
            this.btnConsultarDependente.TabIndex = 1;
            this.btnConsultarDependente.Text = "Consultar Dependente";
            this.btnConsultarDependente.UseVisualStyleBackColor = true;
            this.btnConsultarDependente.Click += new System.EventHandler(this.btnConsultarDependente_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 169);
            this.Controls.Add(this.btnConsultarDependente);
            this.Controls.Add(this.btnConsultarFuncionario);
            this.Controls.Add(this.btnTesteConexao);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTesteConexao;
        private System.Windows.Forms.Button btnConsultarFuncionario;
        private System.Windows.Forms.Button btnConsultarDependente;
    }
}