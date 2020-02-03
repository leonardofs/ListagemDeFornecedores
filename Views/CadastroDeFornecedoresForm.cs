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
using ListagemDeFornecedores.Repositorios;
using Sirb.Documents.BR.Validation;



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

        private void rBtnPF_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnPJ.Checked)
            {
                lblNome.Text = "Razão Social";
                lblCpfCnpj.Text = "CNPJ";
                txtCpf.Mask = Sirb.Documents.BR.Validation.CNPJ.PlaceMask("00000000000000");


                lblIdadeUF.Text = "UF";
                
                lblPJ.Visible = true;
                txtPJ.Visible = true;
                btnSelecionarPJ.Visible = true;

                txtNome.Enabled = false;
                txtCpf.Enabled = false;
                txtIdadeUF.Enabled = false;

                txtIdadeUF.Mask = "CCCC"; 
                txtNome.ReadOnly = true;
                txtCpf.ReadOnly = true;
                txtIdadeUF.ReadOnly = true;


                btnSelecionarPJ.Visible = true;

            }
            else
            {
                lblIdadeUF.Text = "Idade";
                
                lblNome.Text = "Nome";
                lblCpfCnpj.Text = "CPF";
                txtCpf.Mask = Sirb.Documents.BR.Validation.CPF.PlaceMask("00000000000");

                btnSelecionarPJ.Visible =false;
                lblPJ.Visible = false;
                txtPJ.Visible = false;

                txtNome.Enabled = true;
                txtCpf.Enabled = true;
                txtIdadeUF.Enabled = true;

                txtNome.ReadOnly = false;
                txtCpf.ReadOnly = false;
                txtIdadeUF.ReadOnly = false;
                txtIdadeUF.Mask = "999";
            }

            txtNome.Clear();
            txtCpf.Clear();
            txtIdadeUF.Clear();
            txtPJ.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            gBoxEmpresa.Visible = true;

            empresas =EmpresaDAO.GetEmpresas();

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            listViewEmpresas.DataBindings.Clear();
            listViewEmpresas.Clear();
            gBoxEmpresa.Visible = false;
        }
      
        public void PreencheTxtEmpresa()
        {
            PreencheTxtEmpresa(null);
        }

        public void PreencheTxtEmpresa(Empresa _emp)
        {
            if (_emp != null) {
                txtEmpresa.Text = _emp.Nome;
                empresa = _emp;
            } else
            {

            }

        }

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
                    txtIdadeUF.Mask = "CCCC";
                   txtIdadeUF.Text = empresaFornecedora.UF;
                   
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

            empresasFornecedoras = EmpresaDAO.GetEmpresas(); 

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

        private void btnSalvarFornecedor_Click(object sender, EventArgs e)
        {
            
            if (rBtnPF.Checked) {
                if ( int.Parse(txtIdadeUF.Text) >=18)
                {
                    if (CPF.IsValid(txtCpf.Text))
                    {

                        var _fornecedor = new FornecedorPF()
                        {
                            NomeFornecedor = txtNome.Text,
                            Cpf = txtCpf.Text,
                            EmpresaId = empresa.EmpresaId
                        };

                        try
                        {
                        Task task = FornecedorDAO.SalvarFornecedor(_fornecedor);

                            this.Dispose();


                        }
                        catch (Exception)
                        {

                            throw;

                        } 

                    }
                    else
                    {
                        MessageBox.Show("Informe um CPF valido","Valor incorreto");
                        txtCpf.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Para cadastra uma Pessoa fissica como fornecedor ele deve ser maior de idade.", "Valor invalido");
                    txtIdadeUF.Text="";
                }

                


            } 
            else // Fornecedor PJ
            {
            

                força erro
                    //todo : salvar fornecedor PJ

            }



        }
    }

}


