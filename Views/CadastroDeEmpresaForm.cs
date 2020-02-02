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
    public partial class CadastroDeEmpresaForm : Form
    {
        private List<Empresa> empresasList = null;
        private Empresa empresa = null;

        public CadastroDeEmpresaForm()
        {
            InitializeComponent();

            //Sirb.Documents.BR.Enumeration.State
            cboUf.DataSource = Enum.GetValues(typeof(State));
            cboEditUF.DataSource = Enum.GetValues(typeof(State));
            txtCnpj.Mask = Sirb.Documents.BR.Validation.CNPJ.PlaceMask("00.000.000/0000-00");
            txtEditCnpj.Mask = Sirb.Documents.BR.Validation.CNPJ.PlaceMask("00.000.000/0000-00");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {


            //validação com o Sirb.Validation
            if (Sirb.Documents.BR.Validation.CNPJ.IsValid(txtCnpj.Text))
            {
                Empresa empresa = new Empresa()
                {
                    Nome = txtNome.Text,
                    CNPJ = txtCnpj.Text,  //uso do Sirb.Validation
                    UF = cboUf.SelectedItem.ToString()
                };

                var task = SalvarEmpresa(empresa);
                txtCnpj.Clear();
                txtNome.Clear();
            }
            else
            {
                MessageBox.Show("O CNPJ informado é invalido, por favor corrija.", "ERRO");
            }
        }

        private void txtCnpj_Enter(object sender, EventArgs e)
        {
            txtCnpj.SelectionStart = 0;
        }

        private void btnCarregarEmpressas_Click(object sender, EventArgs e)
        {

            btnCarregarEmpressas.Enabled = false;
            //todo carregar todas as empresas para o listview

            RefreshListView();

            btnCarregarEmpressas.Enabled = true;
        }

        private void listViewEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewEmpresas.SelectedItems.Count >= 1)
            {

                string itemSelecionadoId = listViewEmpresas.SelectedItems[0].SubItems[0].Text;
                empresa = empresasList.Find(emp => emp.EmpresaId == int.Parse(itemSelecionadoId));

                //Sirb.Documents.BR.Enumeration.State
                var uf = (State)Enum.Parse(typeof(State), empresa.UF);

                pnlEdit.Enabled = true;

                cboEditUF.SelectedItem = uf;
                txtEditNome.Text = empresa.Nome;
                txtEditCnpj.Text = empresa.CNPJ;


                lblAviso.Visible = false;
            }
        }

        private void btnEditSalvar_Click(object sender, EventArgs e)
        {
            btnEditSalvar.Enabled = false;
            //validação do CNPJ no edit
            if (Sirb.Documents.BR.Validation.CNPJ.IsValid(txtEditCnpj.Text))
            {
                var _empresaEditada = new Empresa
                {
                    EmpresaId = empresa.EmpresaId,
                    Nome = txtEditNome.Text,
                    CNPJ = txtEditCnpj.Text,
                    UF = cboEditUF.Text
                };
                Task task = EditarEmpresa(_empresaEditada);

                txtEditNome.Clear();
                txtEditCnpj.Clear();

                RefreshListView();
            }
            else
            {
                MessageBox.Show("CNPJ invalido");
            }
            btnEditSalvar.Enabled = true;

        }

        private void btnApagarEmpresa_Click(object sender, EventArgs e)
        {
            if (txtEditCnpj.Text != "" && txtEditNome.Text != "" && empresa != null)
            {
                var task = DeletarEmpresa(empresa);
                task.Wait();
                listViewEmpresas.SelectedItems.Clear();

                txtEditNome.Clear();
                txtEditCnpj.Clear();
                cboEditUF.SelectedIndex = 0;
                empresa = null;

                pnlEdit.Enabled = false;
                lblAviso.Visible = true;

                RefreshListView();
            }
        }


        //todo: refatorar
        private void RefreshListView() {

            listViewEmpresas.Items.Clear();

            empresasList = CarregarEmpresas();

            foreach (Empresa emp in empresasList)
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



        //todo: refatorar para DAO
        #region Data Acess Functions 

        public List<Empresa> CarregarEmpresas()
        {
           
            using (var db = new FornecedorContext())
            {
                return db.Empresas.Select(x => x).ToList();
               // return  await db.Empresas.Select(x => x).ToListAsync();
            }

           

        }

        public async Task SalvarEmpresa(Empresa _empresa)
        {
            try
            {
                using (var db = new FornecedorContext())
                {

                    db.Empresas.Add(_empresa);
                    await db.SaveChangesAsync();
                }

                MessageBox.Show("A empresa foi cadastrada com sucesso.", "Sucesso");

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task EditarEmpresa(Empresa _empresa)
        {
            using (var db = new FornecedorContext())
            {
                var result = db.Empresas.Where(emp => emp.EmpresaId == _empresa.EmpresaId).FirstOrDefault();
                if (result != null)
                {
                    result.Nome = _empresa.Nome;
                    result.CNPJ = _empresa.CNPJ;
                    result.UF = _empresa.UF;

                    await db.SaveChangesAsync();

                    MessageBox.Show("Alterações salvas com sucesso");
                }
            }
        }

        public async Task DeletarEmpresa(Empresa _empresa)
        {
            using (var db = new FornecedorContext())
            {
                var result = db.Empresas.Where(emp => emp.EmpresaId == _empresa.EmpresaId).FirstOrDefault();
                db.Empresas.Remove(result);

                await db.SaveChangesAsync();
            }
        }

        #endregion


    }
}

