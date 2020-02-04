namespace ListagemDeFornecedores.Views
{
    partial class CadastroDeEmpresaForm
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cboUf = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.tabctrlEmpresa = new System.Windows.Forms.TabControl();
            this.tabNovaEmpresa = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabEditEmpresa = new System.Windows.Forms.TabPage();
            this.pnlEdit = new System.Windows.Forms.GroupBox();
            this.btnEditSalvar = new System.Windows.Forms.Button();
            this.lblEditUf = new System.Windows.Forms.Label();
            this.btnApagarEmpresa = new System.Windows.Forms.Button();
            this.lblEditNome = new System.Windows.Forms.Label();
            this.txtEditCnpj = new System.Windows.Forms.MaskedTextBox();
            this.cboEditUF = new System.Windows.Forms.ComboBox();
            this.txtEditNome = new System.Windows.Forms.TextBox();
            this.lblEditCnpj = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.listViewEmpresas = new System.Windows.Forms.ListView();
            this.clnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnCNPJ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnUF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabctrlEmpresa.SuspendLayout();
            this.tabNovaEmpresa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabEditEmpresa.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(24, 90);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(70, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Razão Social";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(24, 125);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(34, 13);
            this.lblCnpj.TabIndex = 2;
            this.lblCnpj.Text = "CNPJ";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(24, 160);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(21, 13);
            this.lblUf.TabIndex = 3;
            this.lblUf.Text = "UF";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(100, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(174, 20);
            this.txtNome.TabIndex = 4;
            // 
            // cboUf
            // 
            this.cboUf.FormattingEnabled = true;
            this.cboUf.Location = new System.Drawing.Point(100, 157);
            this.cboUf.Name = "cboUf";
            this.cboUf.Size = new System.Drawing.Size(174, 21);
            this.cboUf.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightBlue;
            this.btnSalvar.Location = new System.Drawing.Point(229, 285);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(100, 122);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(174, 20);
            this.txtCnpj.TabIndex = 8;
            this.txtCnpj.Enter += new System.EventHandler(this.txtCnpj_Enter);
            // 
            // tabctrlEmpresa
            // 
            this.tabctrlEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabctrlEmpresa.Controls.Add(this.tabNovaEmpresa);
            this.tabctrlEmpresa.Controls.Add(this.tabEditEmpresa);
            this.tabctrlEmpresa.Location = new System.Drawing.Point(1, -1);
            this.tabctrlEmpresa.Name = "tabctrlEmpresa";
            this.tabctrlEmpresa.SelectedIndex = 0;
            this.tabctrlEmpresa.Size = new System.Drawing.Size(799, 449);
            this.tabctrlEmpresa.TabIndex = 9;
            this.tabctrlEmpresa.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabctrlEmpresa_Selected);
            // 
            // tabNovaEmpresa
            // 
            this.tabNovaEmpresa.BackColor = System.Drawing.Color.Azure;
            this.tabNovaEmpresa.Controls.Add(this.groupBox1);
            this.tabNovaEmpresa.Location = new System.Drawing.Point(4, 22);
            this.tabNovaEmpresa.Name = "tabNovaEmpresa";
            this.tabNovaEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabNovaEmpresa.Size = new System.Drawing.Size(791, 423);
            this.tabNovaEmpresa.TabIndex = 0;
            this.tabNovaEmpresa.Text = "Novo Registro";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtCnpj);
            this.groupBox1.Controls.Add(this.cboUf);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblUf);
            this.groupBox1.Controls.Add(this.lblCnpj);
            this.groupBox1.Location = new System.Drawing.Point(21, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 347);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar empresa";
            // 
            // tabEditEmpresa
            // 
            this.tabEditEmpresa.BackColor = System.Drawing.Color.Azure;
            this.tabEditEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabEditEmpresa.Controls.Add(this.pnlEdit);
            this.tabEditEmpresa.Controls.Add(this.lblAviso);
            this.tabEditEmpresa.Controls.Add(this.listViewEmpresas);
            this.tabEditEmpresa.Location = new System.Drawing.Point(4, 22);
            this.tabEditEmpresa.Name = "tabEditEmpresa";
            this.tabEditEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditEmpresa.Size = new System.Drawing.Size(791, 423);
            this.tabEditEmpresa.TabIndex = 1;
            this.tabEditEmpresa.Text = "Editar Registros";
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.White;
            this.pnlEdit.Controls.Add(this.btnEditSalvar);
            this.pnlEdit.Controls.Add(this.lblEditUf);
            this.pnlEdit.Controls.Add(this.btnApagarEmpresa);
            this.pnlEdit.Controls.Add(this.lblEditNome);
            this.pnlEdit.Controls.Add(this.txtEditCnpj);
            this.pnlEdit.Controls.Add(this.cboEditUF);
            this.pnlEdit.Controls.Add(this.txtEditNome);
            this.pnlEdit.Controls.Add(this.lblEditCnpj);
            this.pnlEdit.Enabled = false;
            this.pnlEdit.Location = new System.Drawing.Point(455, 42);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(320, 325);
            this.pnlEdit.TabIndex = 27;
            this.pnlEdit.TabStop = false;
            this.pnlEdit.Text = "Editar empresa";
            // 
            // btnEditSalvar
            // 
            this.btnEditSalvar.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditSalvar.Location = new System.Drawing.Point(217, 262);
            this.btnEditSalvar.Name = "btnEditSalvar";
            this.btnEditSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnEditSalvar.TabIndex = 15;
            this.btnEditSalvar.Text = "Salvar";
            this.btnEditSalvar.UseVisualStyleBackColor = false;
            this.btnEditSalvar.Click += new System.EventHandler(this.btnEditSalvar_Click);
            // 
            // lblEditUf
            // 
            this.lblEditUf.AutoSize = true;
            this.lblEditUf.Location = new System.Drawing.Point(24, 161);
            this.lblEditUf.Name = "lblEditUf";
            this.lblEditUf.Size = new System.Drawing.Size(21, 13);
            this.lblEditUf.TabIndex = 12;
            this.lblEditUf.Text = "UF";
            // 
            // btnApagarEmpresa
            // 
            this.btnApagarEmpresa.BackColor = System.Drawing.Color.Tomato;
            this.btnApagarEmpresa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnApagarEmpresa.Location = new System.Drawing.Point(49, 262);
            this.btnApagarEmpresa.Name = "btnApagarEmpresa";
            this.btnApagarEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btnApagarEmpresa.TabIndex = 17;
            this.btnApagarEmpresa.Text = "Deletar";
            this.btnApagarEmpresa.UseVisualStyleBackColor = false;
            this.btnApagarEmpresa.Click += new System.EventHandler(this.btnApagarEmpresa_Click);
            // 
            // lblEditNome
            // 
            this.lblEditNome.AutoSize = true;
            this.lblEditNome.Location = new System.Drawing.Point(24, 89);
            this.lblEditNome.Name = "lblEditNome";
            this.lblEditNome.Size = new System.Drawing.Size(70, 13);
            this.lblEditNome.TabIndex = 10;
            this.lblEditNome.Text = "Razão Social";
            // 
            // txtEditCnpj
            // 
            this.txtEditCnpj.Location = new System.Drawing.Point(100, 122);
            this.txtEditCnpj.Name = "txtEditCnpj";
            this.txtEditCnpj.Size = new System.Drawing.Size(174, 20);
            this.txtEditCnpj.TabIndex = 24;
            // 
            // cboEditUF
            // 
            this.cboEditUF.FormattingEnabled = true;
            this.cboEditUF.Location = new System.Drawing.Point(100, 158);
            this.cboEditUF.Name = "cboEditUF";
            this.cboEditUF.Size = new System.Drawing.Size(174, 21);
            this.cboEditUF.TabIndex = 14;
            // 
            // txtEditNome
            // 
            this.txtEditNome.Location = new System.Drawing.Point(100, 86);
            this.txtEditNome.Name = "txtEditNome";
            this.txtEditNome.Size = new System.Drawing.Size(174, 20);
            this.txtEditNome.TabIndex = 13;
            // 
            // lblEditCnpj
            // 
            this.lblEditCnpj.AutoSize = true;
            this.lblEditCnpj.Location = new System.Drawing.Point(24, 125);
            this.lblEditCnpj.Name = "lblEditCnpj";
            this.lblEditCnpj.Size = new System.Drawing.Size(34, 13);
            this.lblEditCnpj.TabIndex = 11;
            this.lblEditCnpj.Text = "CNPJ";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAviso.Location = new System.Drawing.Point(95, 13);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(266, 17);
            this.lblAviso.TabIndex = 26;
            this.lblAviso.Text = "Selecione uma empresa para editar";
            // 
            // listViewEmpresas
            // 
            this.listViewEmpresas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnID,
            this.clnNome,
            this.clnCNPJ,
            this.clnUF});
            this.listViewEmpresas.FullRowSelect = true;
            this.listViewEmpresas.HideSelection = false;
            this.listViewEmpresas.Location = new System.Drawing.Point(22, 42);
            this.listViewEmpresas.MultiSelect = false;
            this.listViewEmpresas.Name = "listViewEmpresas";
            this.listViewEmpresas.Size = new System.Drawing.Size(426, 325);
            this.listViewEmpresas.TabIndex = 18;
            this.listViewEmpresas.UseCompatibleStateImageBehavior = false;
            this.listViewEmpresas.View = System.Windows.Forms.View.Details;
            this.listViewEmpresas.SelectedIndexChanged += new System.EventHandler(this.listViewEmpresas_SelectedIndexChanged);
            // 
            // clnID
            // 
            this.clnID.Text = "ID";
            this.clnID.Width = 30;
            // 
            // clnNome
            // 
            this.clnNome.Text = "Razão Social";
            this.clnNome.Width = 230;
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
            // CadastroDeEmpresaForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabctrlEmpresa);
            this.Name = "CadastroDeEmpresaForm";
            this.Text = "Cadastro de Empresa";
            this.tabctrlEmpresa.ResumeLayout(false);
            this.tabNovaEmpresa.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabEditEmpresa.ResumeLayout(false);
            this.tabEditEmpresa.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cboUf;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.TabControl tabctrlEmpresa;
        private System.Windows.Forms.TabPage tabNovaEmpresa;
        private System.Windows.Forms.TabPage tabEditEmpresa;
        private System.Windows.Forms.Button btnEditSalvar;
        private System.Windows.Forms.Label lblEditNome;
        private System.Windows.Forms.ComboBox cboEditUF;
        private System.Windows.Forms.Label lblEditCnpj;
        private System.Windows.Forms.TextBox txtEditNome;
        private System.Windows.Forms.Label lblEditUf;
        private System.Windows.Forms.Button btnApagarEmpresa;
        private System.Windows.Forms.ListView listViewEmpresas;
        private System.Windows.Forms.ColumnHeader clnNome;
        private System.Windows.Forms.ColumnHeader clnCNPJ;
        private System.Windows.Forms.ColumnHeader clnUF;
        private System.Windows.Forms.ColumnHeader clnID;
        private System.Windows.Forms.MaskedTextBox txtEditCnpj;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.GroupBox pnlEdit;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}