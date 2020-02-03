using ListagemDeFornecedores.Contexto;
using ListagemDeFornecedores.Entidades;
using ListagemDeFornecedores.Utils.Enums;
using Sirb.Documents.BR.Enumeration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;



namespace ListagemDeFornecedores.Views
{
    public partial class CadastroDeFornecedoresForm : Form
    {
        
        Empresa empresa = null;
        Empresa empresaFornecedora = null;
        
        List<Empresa> empresas = null;
        List<Empresa> empresasFornecedoras = null;

        private Fornecedor fornecedor = null;

        public CadastroDeFornecedoresForm()
        {
            InitializeComponent();
            PreencheTxtEmpresa();
        }

        public CadastroDeFornecedoresForm(Empresa _empresa)
        {
            InitializeComponent();
            PreencheTxtEmpresa(_empresa);
        }

        public CadastroDeFornecedoresForm(Empresa _empresa, Fornecedor _fornecedor)
        {
            InitializeComponent();
            empresa = _empresa;
            fornecedor = _fornecedor;
        }

        private void CadastroDeFornecedoresForm_Load(object sender, EventArgs e)
        {
            txtCpf.Mask = Sirb.Documents.BR.Validation.CPF.PlaceMask("00000000000");
        }

 

        //todo refatorar para DAO


        private void rBtnPF_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnPJ.Checked)
            {
                lblNome.Text = "Razão Social";
                lblCpfCnpj.Text = "CNPJ";
                txtCpf.Mask = Sirb.Documents.BR.Validation.CNPJ.PlaceMask("00000000000000");

                lblPJ.Visible = true;
                txtPJ.Visible = true;
                txtNome.Enabled = false;
                txtNome.ReadOnly = true;
                txtCpf.Enabled = false;
                txtCpf.ReadOnly = true;
                btnSelecionarPJ.Visible = true;

            }
            else
            {
                lblNome.Text = "Nome";
                lblCpfCnpj.Text = "CPF";
                txtCpf.Mask = Sirb.Documents.BR.Validation.CPF.PlaceMask("00000000000");
                lblPJ.Visible = false;
                txtPJ.Visible = false;
                txtNome.Enabled = true;
                txtNome.ReadOnly = false;
                txtCpf.Enabled = true;
                txtCpf.ReadOnly = false;
                btnSelecionarPJ.Visible =false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            gBoxEmpresa.Visible = true;

            empresas = CarregarEmpresas();

            foreach (Empresa emp in empresas)
            {
                listViewEmpresas.Items.Add(
                    new ListViewItem(
                        new string[] {
                            emp.EmpresaId.ToString(),
                            emp.Nome,
                            emp.CNPJ,
                            emp.UF
                        }));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            listViewEmpresas.DataBindings.Clear();
            gBoxEmpresa.Visible = false;
        }


        #region Metodos de acesso a dados

      
        public void PreencheTxtEmpresa()
        {
            PreencheTxtEmpresa(null);

        }

        public void PreencheTxtEmpresa(Empresa _emp)
        {
            if (_emp != null) {
                txtEmpresa.Text = _emp.Nome;
                empresa = _emp;

            }

        }

        public List<Empresa> CarregarEmpresas()
        {

            using (var db = new FornecedorContext())
            {
                return db.Empresas.Select(x => x).ToList();
                // return  await db.Empresas.Select(x => x).ToListAsync();
            }

        }
        #endregion

        private void btnSelecionarEmpressas_Click(object sender, EventArgs e)
        {
            if (listViewEmpresas.SelectedItems.Count >= 1)
            {

                bool selecaoDeEmpresaFornecedora = (gBoxEmpresa.Text == "Selecione empresa fornecedora");

                //todo erros aqui
                string itemSelecionadoId = listViewEmpresas.SelectedItems[0].SubItems[0].Text;

                if (selecaoDeEmpresaFornecedora)
                {

                    empresaFornecedora = empresasFornecedoras.Find(emp => emp.EmpresaId == int.Parse(itemSelecionadoId));

                    txtPJ.Text = empresaFornecedora.Nome;
                    txtNome.Text = empresaFornecedora.Nome;
                    txtCpf.Text = empresaFornecedora.CNPJ;

                    //todo receber UF 
                }
                else
                {  
                    empresa = empresas.Find(emp => emp.EmpresaId == int.Parse(itemSelecionadoId));
                    PreencheTxtEmpresa(empresa);
                }

                //todo não está limpando
                listViewEmpresas.DataBindings.Clear();
                gBoxEmpresa.Visible = false;
            }
        }

        private void btnSelecionarPJ_Click(object sender, EventArgs e)
        {

            gBoxEmpresa.Visible = true;

            gBoxEmpresa.Text = "Selecione empresa fornecedora";

             empresasFornecedoras = CarregarEmpresas();

            foreach (Empresa emp in empresasFornecedoras)
            {
                listViewEmpresas.Items.Add(
                    new ListViewItem(
                        new string[] {
                            emp.EmpresaId.ToString(),
                            emp.Nome,
                            emp.CNPJ,
                            emp.UF
                        }));
            }

        }
    }

}


