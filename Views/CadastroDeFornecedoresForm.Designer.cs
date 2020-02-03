namespace ListagemDeFornecedores.Views
{
    partial class CadastroDeFornecedoresForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBtnPF = new System.Windows.Forms.RadioButton();
            this.rBtnPJ = new System.Windows.Forms.RadioButton();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelecionar);
            this.groupBox1.Controls.Add(this.txtEmpresa);
            this.groupBox1.Controls.Add(this.txtCpf);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblUF);
            this.groupBox1.Controls.Add(this.lblCpfCnpj);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblEmpresa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Fornecedor";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(278, 38);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 20);
            this.btnSelecionar.TabIndex = 13;
            this.btnSelecionar.Text = "Selecionar...";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Enabled = false;
            this.txtEmpresa.Location = new System.Drawing.Point(99, 38);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.ReadOnly = true;
            this.txtEmpresa.Size = new System.Drawing.Size(160, 20);
            this.txtEmpresa.TabIndex = 12;
            this.txtEmpresa.Text = "Selecione a empresa";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(99, 237);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(254, 20);
            this.txtCpf.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(99, 279);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(254, 20);
            this.textBox3.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(99, 187);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(254, 20);
            this.txtNome.TabIndex = 6;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(6, 282);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(35, 13);
            this.lblUF.TabIndex = 5;
            this.lblUF.Text = "label3";
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(6, 240);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(27, 13);
            this.lblCpfCnpj.TabIndex = 4;
            this.lblCpfCnpj.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 194);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBtnPF);
            this.groupBox2.Controls.Add(this.rBtnPJ);
            this.groupBox2.Location = new System.Drawing.Point(26, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 69);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Pessoa";
            // 
            // rBtnPF
            // 
            this.rBtnPF.AutoSize = true;
            this.rBtnPF.Checked = true;
            this.rBtnPF.Location = new System.Drawing.Point(187, 40);
            this.rBtnPF.Name = "rBtnPF";
            this.rBtnPF.Size = new System.Drawing.Size(90, 17);
            this.rBtnPF.TabIndex = 1;
            this.rBtnPF.TabStop = true;
            this.rBtnPF.Text = "Pessoa Fisica";
            this.rBtnPF.UseVisualStyleBackColor = true;
            this.rBtnPF.CheckedChanged += new System.EventHandler(this.rBtnPF_CheckedChanged);
            // 
            // rBtnPJ
            // 
            this.rBtnPJ.AutoSize = true;
            this.rBtnPJ.Location = new System.Drawing.Point(30, 40);
            this.rBtnPJ.Name = "rBtnPJ";
            this.rBtnPJ.Size = new System.Drawing.Size(99, 17);
            this.rBtnPJ.TabIndex = 0;
            this.rBtnPJ.Text = "Pessoa Juridica";
            this.rBtnPJ.UseVisualStyleBackColor = true;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(35, 41);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Empresa";
            // 
            // CadastroDeFornecedoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastroDeFornecedoresForm";
            this.Text = "Cadastro De Fornecedores";
            this.Load += new System.EventHandler(this.CadastroDeFornecedoresForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBtnPF;
        private System.Windows.Forms.RadioButton rBtnPJ;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Button btnSelecionar;
    }
}