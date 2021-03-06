﻿namespace ListagemDeFornecedores.Views
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
            this.btnSelecionarPJ = new System.Windows.Forms.Button();
            this.txtPJ = new System.Windows.Forms.TextBox();
            this.lblPJ = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelarFornecedor = new System.Windows.Forms.Button();
            this.btnSalvarFornecedor = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblIdadeUF = new System.Windows.Forms.Label();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBtnPF = new System.Windows.Forms.RadioButton();
            this.rBtnPJ = new System.Windows.Forms.RadioButton();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSelecionarEmpressas = new System.Windows.Forms.Button();
            this.listViewEmpresas = new System.Windows.Forms.ListView();
            this.clnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnCNPJ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnUF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gBoxEmpresa = new System.Windows.Forms.GroupBox();
            this.datePickerNasc = new System.Windows.Forms.DateTimePicker();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gBoxEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cboUF);
            this.groupBox1.Controls.Add(this.datePickerNasc);
            this.groupBox1.Controls.Add(this.btnSelecionarPJ);
            this.groupBox1.Controls.Add(this.txtPJ);
            this.groupBox1.Controls.Add(this.lblPJ);
            this.groupBox1.Controls.Add(this.btnSelecionar);
            this.groupBox1.Controls.Add(this.txtEmpresa);
            this.groupBox1.Controls.Add(this.txtCpf);
            this.groupBox1.Controls.Add(this.btnCancelarFornecedor);
            this.groupBox1.Controls.Add(this.btnSalvarFornecedor);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblIdadeUF);
            this.groupBox1.Controls.Add(this.lblCpfCnpj);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblEmpresa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Fornecedor";
            // 
            // btnSelecionarPJ
            // 
            this.btnSelecionarPJ.BackColor = System.Drawing.Color.LightBlue;
            this.btnSelecionarPJ.Location = new System.Drawing.Point(262, 172);
            this.btnSelecionarPJ.Name = "btnSelecionarPJ";
            this.btnSelecionarPJ.Size = new System.Drawing.Size(75, 20);
            this.btnSelecionarPJ.TabIndex = 16;
            this.btnSelecionarPJ.Text = "Selecionar...";
            this.btnSelecionarPJ.UseVisualStyleBackColor = false;
            this.btnSelecionarPJ.Visible = false;
            this.btnSelecionarPJ.Click += new System.EventHandler(this.btnSelecionarPJ_Click);
            // 
            // txtPJ
            // 
            this.txtPJ.Enabled = false;
            this.txtPJ.Location = new System.Drawing.Point(88, 172);
            this.txtPJ.Name = "txtPJ";
            this.txtPJ.ReadOnly = true;
            this.txtPJ.Size = new System.Drawing.Size(168, 20);
            this.txtPJ.TabIndex = 15;
            this.txtPJ.Text = "Selecione a empresa fornecedora";
            this.txtPJ.Visible = false;
            // 
            // lblPJ
            // 
            this.lblPJ.AutoSize = true;
            this.lblPJ.Location = new System.Drawing.Point(6, 175);
            this.lblPJ.Name = "lblPJ";
            this.lblPJ.Size = new System.Drawing.Size(76, 13);
            this.lblPJ.TabIndex = 14;
            this.lblPJ.Text = "Fornecedor PJ";
            this.lblPJ.Visible = false;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.LightBlue;
            this.btnSelecionar.Location = new System.Drawing.Point(262, 41);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 20);
            this.btnSelecionar.TabIndex = 13;
            this.btnSelecionar.Text = "Selecionar...";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Enabled = false;
            this.txtEmpresa.Location = new System.Drawing.Point(60, 38);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.ReadOnly = true;
            this.txtEmpresa.Size = new System.Drawing.Size(185, 20);
            this.txtEmpresa.TabIndex = 12;
            this.txtEmpresa.Text = "Selecione a empresa";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(99, 254);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(238, 20);
            this.txtCpf.TabIndex = 11;
            // 
            // btnCancelarFornecedor
            // 
            this.btnCancelarFornecedor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelarFornecedor.Location = new System.Drawing.Point(170, 372);
            this.btnCancelarFornecedor.Name = "btnCancelarFornecedor";
            this.btnCancelarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarFornecedor.TabIndex = 8;
            this.btnCancelarFornecedor.Text = "Cancelar";
            this.btnCancelarFornecedor.UseVisualStyleBackColor = false;
            this.btnCancelarFornecedor.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalvarFornecedor
            // 
            this.btnSalvarFornecedor.BackColor = System.Drawing.Color.LightBlue;
            this.btnSalvarFornecedor.Location = new System.Drawing.Point(262, 372);
            this.btnSalvarFornecedor.Name = "btnSalvarFornecedor";
            this.btnSalvarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarFornecedor.TabIndex = 7;
            this.btnSalvarFornecedor.Text = "Salvar";
            this.btnSalvarFornecedor.UseVisualStyleBackColor = false;
            this.btnSalvarFornecedor.Click += new System.EventHandler(this.btnSalvarFornecedor_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(99, 215);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(238, 20);
            this.txtNome.TabIndex = 6;
            // 
            // lblIdadeUF
            // 
            this.lblIdadeUF.AutoSize = true;
            this.lblIdadeUF.Location = new System.Drawing.Point(6, 299);
            this.lblIdadeUF.Name = "lblIdadeUF";
            this.lblIdadeUF.Size = new System.Drawing.Size(104, 13);
            this.lblIdadeUF.TabIndex = 5;
            this.lblIdadeUF.Text = "Data de Nascimento";
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(6, 257);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(27, 13);
            this.lblCpfCnpj.TabIndex = 4;
            this.lblCpfCnpj.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 222);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBtnPF);
            this.groupBox2.Controls.Add(this.rBtnPJ);
            this.groupBox2.Location = new System.Drawing.Point(9, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 69);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Pessoa";
            // 
            // rBtnPF
            // 
            this.rBtnPF.AutoSize = true;
            this.rBtnPF.Checked = true;
            this.rBtnPF.Location = new System.Drawing.Point(198, 40);
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
            this.lblEmpresa.Location = new System.Drawing.Point(6, 41);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Empresa";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(222, 363);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSelecionarEmpressas
            // 
            this.btnSelecionarEmpressas.BackColor = System.Drawing.Color.LightBlue;
            this.btnSelecionarEmpressas.Location = new System.Drawing.Point(314, 363);
            this.btnSelecionarEmpressas.Name = "btnSelecionarEmpressas";
            this.btnSelecionarEmpressas.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarEmpressas.TabIndex = 29;
            this.btnSelecionarEmpressas.Text = "Selecionar";
            this.btnSelecionarEmpressas.UseVisualStyleBackColor = false;
            this.btnSelecionarEmpressas.Click += new System.EventHandler(this.btnSelecionarEmpressas_Click);
            // 
            // listViewEmpresas
            // 
            this.listViewEmpresas.BackColor = System.Drawing.Color.PaleTurquoise;
            this.listViewEmpresas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnID,
            this.clnNome,
            this.clnCNPJ,
            this.clnUF});
            this.listViewEmpresas.FullRowSelect = true;
            this.listViewEmpresas.HideSelection = false;
            this.listViewEmpresas.Location = new System.Drawing.Point(0, 19);
            this.listViewEmpresas.MultiSelect = false;
            this.listViewEmpresas.Name = "listViewEmpresas";
            this.listViewEmpresas.Size = new System.Drawing.Size(395, 338);
            this.listViewEmpresas.TabIndex = 28;
            this.listViewEmpresas.UseCompatibleStateImageBehavior = false;
            this.listViewEmpresas.View = System.Windows.Forms.View.Details;
            // 
            // clnID
            // 
            this.clnID.Text = "ID";
            this.clnID.Width = 30;
            // 
            // clnNome
            // 
            this.clnNome.Text = "Razão Social";
            this.clnNome.Width = 213;
            // 
            // clnCNPJ
            // 
            this.clnCNPJ.Text = "CNPJ";
            this.clnCNPJ.Width = 110;
            // 
            // clnUF
            // 
            this.clnUF.Text = "UF";
            this.clnUF.Width = 30;
            // 
            // gBoxEmpresa
            // 
            this.gBoxEmpresa.BackColor = System.Drawing.Color.White;
            this.gBoxEmpresa.Controls.Add(this.listViewEmpresas);
            this.gBoxEmpresa.Controls.Add(this.btnCancelar);
            this.gBoxEmpresa.Controls.Add(this.btnSelecionarEmpressas);
            this.gBoxEmpresa.Location = new System.Drawing.Point(393, 21);
            this.gBoxEmpresa.Name = "gBoxEmpresa";
            this.gBoxEmpresa.Size = new System.Drawing.Size(395, 397);
            this.gBoxEmpresa.TabIndex = 32;
            this.gBoxEmpresa.TabStop = false;
            this.gBoxEmpresa.Text = "Selecionar empresa";
            this.gBoxEmpresa.Visible = false;
            // 
            // datePickerNasc
            // 
            this.datePickerNasc.Location = new System.Drawing.Point(137, 293);
            this.datePickerNasc.MaxDate = new System.DateTime(2020, 2, 4, 0, 0, 0, 0);
            this.datePickerNasc.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datePickerNasc.Name = "datePickerNasc";
            this.datePickerNasc.Size = new System.Drawing.Size(200, 20);
            this.datePickerNasc.TabIndex = 18;
            this.datePickerNasc.Value = new System.DateTime(2020, 2, 4, 0, 0, 0, 0);
            // 
            // cboUF
            // 
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(137, 293);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(121, 21);
            this.cboUF.TabIndex = 19;
            this.cboUF.Visible = false;
            // 
            // CadastroDeFornecedoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBoxEmpresa);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastroDeFornecedoresForm";
            this.Text = "Cadastro De Fornecedores";
            this.Load += new System.EventHandler(this.CadastroDeFornecedoresForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gBoxEmpresa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBtnPJ;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblIdadeUF;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCancelarFornecedor;
        private System.Windows.Forms.Button btnSalvarFornecedor;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSelecionarEmpressas;
        private System.Windows.Forms.ListView listViewEmpresas;
        private System.Windows.Forms.ColumnHeader clnID;
        private System.Windows.Forms.ColumnHeader clnNome;
        private System.Windows.Forms.ColumnHeader clnCNPJ;
        private System.Windows.Forms.ColumnHeader clnUF;
        private System.Windows.Forms.RadioButton rBtnPF;
        private System.Windows.Forms.GroupBox gBoxEmpresa;
        private System.Windows.Forms.Button btnSelecionarPJ;
        private System.Windows.Forms.TextBox txtPJ;
        private System.Windows.Forms.Label lblPJ;
        private System.Windows.Forms.DateTimePicker datePickerNasc;
        private System.Windows.Forms.ComboBox cboUF;
    }
}