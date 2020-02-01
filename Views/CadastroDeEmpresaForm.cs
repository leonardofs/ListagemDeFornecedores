using ListagemDeFornecedores.Contexto;
using ListagemDeFornecedores.Entidades;
using ListagemDeFornecedores.Utils.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sirb.Documents.BR.Validation;


namespace ListagemDeFornecedores.Views
{
    public partial class CadastroDeEmpresaForm : Form
    {
        public CadastroDeEmpresaForm()
        {
            InitializeComponent();
        }

        private void CadastroDeEmpresaForm_Load(object sender, EventArgs e)
        {
            cboUf.DataSource = Enum.GetValues(typeof(Sirb.Documents.BR.Enumeration.State));
            // txtCnpj.Mask = "00,000,000/0000-00";
            txtCnpj.Mask = CNPJ.PlaceMask("00.000.000/0000-00");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {


            //validação com o Sirb.Validation
            if (CNPJ.IsValid(txtCnpj.Text))
            {

                Empresa empresa = new Empresa()
                {
                    Nome = txtNome.Text,
                    CNPJ = txtCnpj.Text,  //uso do Sirb.Validation
                    UF = cboUf.SelectedItem.ToString()
                };

                var Task = SalvarEmpresa(empresa);
                txtCnpj.Clear();
                txtNome.Clear();
            }else{
                MessageBox.Show("O CNPJ informado é invalido, por favor corrija.", "ERRO");
            }

        }

        private void txtCnpj_Enter(object sender, EventArgs e)
        {
            txtCnpj.SelectionStart = 0;
        }


        public static async Task SalvarEmpresa(Empresa empresa)
        {

            try
            {
                using (var db = new FornecedorContext())
                {
                    db.Empresas.Add(empresa);
                    await db.SaveChangesAsync();
                }

                MessageBox.Show("A empresa foi cadastrada com sucesso.", "Sucesso");

            }
            catch (Exception)
            {

                throw;

            }


        }
    }
}
