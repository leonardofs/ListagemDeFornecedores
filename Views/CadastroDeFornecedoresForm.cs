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
using System.Runtime.CompilerServices;

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
            btnSalvarFornecedor.Enabled = false;
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

            EditarFornecedor(_fornecedor);
        }

        private void CadastroDeFornecedoresForm_Load(object sender, EventArgs e)
        {
            txtCpf.Mask = Sirb.Documents.BR.Validation.CPF.PlaceMask("00000000000");
            datePickerNasc.MaxDate = DateTime.Now.Date;
            datePickerNasc.CustomFormat = "dd/MM/yyyy";
            cboUF.DataSource = Enum.GetValues(typeof(State));
            // empresa = null;

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

                cboUF.Visible = true;
                datePickerNasc.Visible = false;

                txtNome.Enabled = false;
                txtCpf.Enabled = false;
                cboUF.Enabled = false;
                datePickerNasc.Enabled = false;

               
                txtNome.ReadOnly = true;
                txtCpf.ReadOnly = true;
                

                btnSelecionarPJ.Visible = true;

            }
            else
            {
                lblIdadeUF.Text = "Data de Nascimento";

                lblNome.Text = "Nome";
                lblCpfCnpj.Text = "CPF";
                txtCpf.Mask = Sirb.Documents.BR.Validation.CPF.PlaceMask("00000000000");



                btnSelecionarPJ.Visible = false;
                lblPJ.Visible = false;
                txtPJ.Visible = false;
                cboUF.Visible = false;
                datePickerNasc.Visible = true;

                txtNome.Enabled = true;
                txtCpf.Enabled = true;
                cboUF.Enabled = false;
                datePickerNasc.Enabled = true;

                txtNome.ReadOnly = false;
                txtCpf.ReadOnly = false;
             
            }

            txtNome.Clear();
            txtCpf.Clear();
            txtPJ.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            gBoxEmpresa.Visible = true;

            empresas = EmpresaDAO.GetEmpresas();

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
            if (_emp != null)
            {
                txtEmpresa.Text = _emp.Nome;
                empresa = _emp;
            }
        }

        public void EditarFornecedor(Fornecedor _fornecedor)
        {
            if (_fornecedor.GetType() == typeof(FornecedorPF))
            {
                rBtnPF.Checked = true;

                txtNome.Text = (_fornecedor as FornecedorPF).NomeFornecedor;
                txtCpf.Text = (_fornecedor as FornecedorPF).Cpf;
                // todo: logica do botão salvar clique diferenciar o create do update.

            } 
            else if(_fornecedor.GetType() == typeof(FornecedorPJ))
            {
                rBtnPJ.Checked = true;

                // todo: editar informações da empresa?

            }






        }

        private void btnSelecionarEmpressas_Click(object sender, EventArgs e)
        {
            if (listViewEmpresas.SelectedItems.Count >= 1)
            {

                bool selecaoDeEmpresaFornecedora = (gBoxEmpresa.Text == "Selecione empresa fornecedora");


                string itemSelecionadoId = listViewEmpresas.SelectedItems[0].SubItems[0].Text;

                if (selecaoDeEmpresaFornecedora) // selecao de empresa que sera uma fornecedoraPJ.
                {

                    empresaFornecedora = empresasFornecedoras.Find(emp => emp.EmpresaId == int.Parse(itemSelecionadoId));

                    txtPJ.Text = empresaFornecedora.Nome;
                    txtNome.Text = empresaFornecedora.Nome;
                    txtCpf.Text = empresaFornecedora.CNPJ;
                    //Sirb.Documents.BR.Enumeration.State;
                    cboUF.SelectedItem = (State)Enum.Parse(typeof(State), empresaFornecedora.UF);
                   

                }
                else // Empresa que recebera fornecedor;
                {
                    empresa = empresas.Find(emp => emp.EmpresaId == int.Parse(itemSelecionadoId));
                    PreencheTxtEmpresa(empresa);
                    btnSalvarFornecedor.Enabled = true;
                }

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
            btnSalvarFornecedor.Enabled = false;

            if (rBtnPF.Checked && empresa != null)
            {
                if (IsMaiorDeIdade(datePickerNasc.Value))
                {
                    if (CPF.IsValid(txtCpf.Text))
                    {
                        var _fornecedor = new FornecedorPF()
                        {
                            NomeFornecedor = txtNome.Text,
                            Cpf = txtCpf.Text,
                            EmpresaId = empresa.EmpresaId,
                            DataNascimento = datePickerNasc.Value
                        };

                        try
                        {
                            Task task = FornecedorDAO.SalvarFornecedor(_fornecedor);

                            MessageBox.Show("Fornecedor Salvo com sucesso", "Registro Salvo");
                            this.Dispose();

                        }
                        catch (Exception)
                        {

                            throw;

                        }

                    }
                    else
                    {
                        MessageBox.Show("Informe um CPF valido", "Valor incorreto");
                        txtCpf.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Para cadastra uma Pessoa fissica como fornecedor ele deve ser maior de idade.", "Valor invalido");
                }

            }
            else if (rBtnPJ.Checked && empresa != null)
            {

                if (empresaFornecedora != null | empresa != null)
                {

                    var task = FornecedorDAO.SalvarFornecedor(
                        new FornecedorPJ
                        {
                            EmpresaId = empresa.EmpresaId,
                            EmpresaFornecedorId = empresaFornecedora.EmpresaId
                        }
                        );
                    this.Dispose();
                }
                {


                }
            }

            btnSalvarFornecedor.Enabled = true;
        }

        public bool IsMaiorDeIdade(DateTime date)
        {
            var idade = DateTime.Now.Year - date.Year;

            return (idade >= 18);
        }

    }

}


