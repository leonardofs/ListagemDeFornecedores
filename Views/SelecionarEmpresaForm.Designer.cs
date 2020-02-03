namespace ListagemDeFornecedores.Views
{
    partial class SelecionarEmpresaForm
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
            this.lblVisualizar = new System.Windows.Forms.Label();
            this.btnSelecionarEmpressas = new System.Windows.Forms.Button();
            this.listViewEmpresas = new System.Windows.Forms.ListView();
            this.clnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnCNPJ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnUF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVisualizar
            // 
            this.lblVisualizar.AutoSize = true;
            this.lblVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizar.Location = new System.Drawing.Point(152, 32);
            this.lblVisualizar.Name = "lblVisualizar";
            this.lblVisualizar.Size = new System.Drawing.Size(148, 20);
            this.lblVisualizar.TabIndex = 26;
            this.lblVisualizar.Text = "Todas as empresas";
            this.lblVisualizar.UseWaitCursor = true;
            // 
            // btnSelecionarEmpressas
            // 
            this.btnSelecionarEmpressas.Location = new System.Drawing.Point(375, 386);
            this.btnSelecionarEmpressas.Name = "btnSelecionarEmpressas";
            this.btnSelecionarEmpressas.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarEmpressas.TabIndex = 25;
            this.btnSelecionarEmpressas.Text = "Selecionar";
            this.btnSelecionarEmpressas.UseVisualStyleBackColor = true;
            this.btnSelecionarEmpressas.Click += new System.EventHandler(this.btnSelecionarEmpressas_Click);
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
            this.listViewEmpresas.Location = new System.Drawing.Point(24, 55);
            this.listViewEmpresas.MultiSelect = false;
            this.listViewEmpresas.Name = "listViewEmpresas";
            this.listViewEmpresas.Size = new System.Drawing.Size(426, 325);
            this.listViewEmpresas.TabIndex = 24;
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
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(282, 386);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // SelecionarEmpresaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 419);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblVisualizar);
            this.Controls.Add(this.btnSelecionarEmpressas);
            this.Controls.Add(this.listViewEmpresas);
            this.Name = "SelecionarEmpresaForm";
            this.Text = "SelecionarEmpresaForm";
            this.Load += new System.EventHandler(this.SelecionarEmpresaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisualizar;
        private System.Windows.Forms.Button btnSelecionarEmpressas;
        private System.Windows.Forms.ListView listViewEmpresas;
        private System.Windows.Forms.ColumnHeader clnID;
        private System.Windows.Forms.ColumnHeader clnNome;
        private System.Windows.Forms.ColumnHeader clnCNPJ;
        private System.Windows.Forms.ColumnHeader clnUF;
        private System.Windows.Forms.Button btnCancelar;
    }
}