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
        private Fornecedor fornecedor = null;
        
        List<Empresa> empresas = null;


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

        private void rBtnPF_CheckedChanged(object sender, EventArgs e)
        {
            if (!rBtnPF.Checked)
            {
                lblNome.Text = "Razão Social";
                lblCpfCnpj.Text = "CNPJ";
                txtCpf.Mask = Sirb.Documents.BR.Validation.CNPJ.PlaceMask("00000000000000");

            }
            else
            {
                lblNome.Text = "Nome";
                lblCpfCnpj.Text = "CPF";
                txtCpf.Mask = Sirb.Documents.BR.Validation.CPF.PlaceMask("00000000000");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            SelecionarEmpresaForm form = new SelecionarEmpresaForm(emp => empresa = emp);
            form.Show();
            

            erro 

            //todo arrumar callback com delegate.

            txtEmpresa.Text = empresa.Nome;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

    #endregion



}


