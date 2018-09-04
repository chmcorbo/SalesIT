namespace wfAcessoDB
{
    partial class FrmConsDependenteFuncionario
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.txtCodigoDependente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.lbGrauParentesco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(384, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodigoFuncionario
            // 
            this.txtCodigoFuncionario.Location = new System.Drawing.Point(128, 24);
            this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            this.txtCodigoFuncionario.Size = new System.Drawing.Size(60, 20);
            this.txtCodigoFuncionario.TabIndex = 1;
            // 
            // txtCodigoDependente
            // 
            this.txtCodigoDependente.Location = new System.Drawing.Point(315, 23);
            this.txtCodigoDependente.Name = "txtCodigoDependente";
            this.txtCodigoDependente.Size = new System.Drawing.Size(54, 20);
            this.txtCodigoDependente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código do Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código do dependente";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(15, 70);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(43, 13);
            this.lbNome.TabIndex = 4;
            this.lbNome.Text = "lbNome";
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Location = new System.Drawing.Point(15, 95);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(94, 13);
            this.lbDataNascimento.TabIndex = 4;
            this.lbDataNascimento.Text = "lbDataNascimento";
            // 
            // lbGrauParentesco
            // 
            this.lbGrauParentesco.AutoSize = true;
            this.lbGrauParentesco.Location = new System.Drawing.Point(15, 119);
            this.lbGrauParentesco.Name = "lbGrauParentesco";
            this.lbGrauParentesco.Size = new System.Drawing.Size(92, 13);
            this.lbGrauParentesco.TabIndex = 4;
            this.lbGrauParentesco.Text = "lbGrauParentesco";
            this.lbGrauParentesco.Click += new System.EventHandler(this.label3_Click);
            // 
            // FrmConsDependenteFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 261);
            this.Controls.Add(this.lbGrauParentesco);
            this.Controls.Add(this.lbDataNascimento);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoDependente);
            this.Controls.Add(this.txtCodigoFuncionario);
            this.Controls.Add(this.btnBuscar);
            this.Name = "FrmConsDependenteFuncionario";
            this.Text = "FrmConsDependenteFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigoFuncionario;
        private System.Windows.Forms.TextBox txtCodigoDependente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.Label lbGrauParentesco;
    }
}