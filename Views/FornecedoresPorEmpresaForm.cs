using ListagemDeFornecedores.Contexto;
using ListagemDeFornecedores.Entidades;
using ListagemDeFornecedores.Repositorios;
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

namespace ListagemDeFornecedores.Views
{
    public partial class FornecedoresPorEmpresaForm : Form
    {

        public FornecedoresPorEmpresaForm()
        {
            InitializeComponent();
        }

    

        private void PreencheBindSource(List<Empresa> _empresas)
        {
            foreach (Empresa emp in _empresas)
            {
                bindingSource.Add(emp);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CadastroDeFornecedoresForm form = new CadastroDeFornecedoresForm((Empresa)bindingSource.Current);

            if (form.ShowDialog() != DialogResult.Yes)
            {
                //aguarda o fechamento da tela para atualizar o bindingSource
                bindingSource_CurrentChanged(this, new EventArgs { });
            }

        }

        private void listViewFornecedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillListView(List<Fornecedor> _fornecedores)
        {
            if (listViewFornecedores.Items.Count > 0)
            {
                listViewFornecedores.Items.Clear();
            }
            foreach (Fornecedor f in _fornecedores)
            {
                if (f.GetType() == typeof(FornecedorPF))
                {
                    listViewFornecedores.Items.Add(
                      new ListViewItem(
                          new string[] {
                              f.FornecedorId.ToString(),
                              f.Tipo,
                              (f as FornecedorPF).NomeFornecedor,
                             (f as FornecedorPF).Cpf,
                             "",
                             (f as FornecedorPF).DataNascimento.ToString("dd/MM/yyyy")
                          })); 
                }
                else
                if (f.GetType() ==typeof(FornecedorPJ))
                {

                    Empresa _emp = EmpresaDAO.GetEmpresa((f as FornecedorPJ).EmpresaFornecedorId);
                    listViewFornecedores.Items.Add(
                      new ListViewItem(
                          new string[] {
                              f.FornecedorId.ToString(),
                              f.Tipo,
                              _emp.Nome,
                             _emp.CNPJ,
                             _emp.UF,
                             ""
                          }));
                }
            }
        }


        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {

            if (bindingSource.Count> 0)
            {
                fillListView(
                     FornecedorDAO.GetFornecedoresPorEmpresa(
                         ((Empresa)bindingSource.Current).EmpresaId)
                     );
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Função em desenvolvimento","Desculpe");
            //if (listViewFornecedores.SelectedItems.Count >= 1)
            //{


            //    string itemSelecionadoId = listViewFornecedores.SelectedItems[0].SubItems[0].Text;

            //    var _fornecedor = FornecedorDAO.GetFornecedor(int.Parse(itemSelecionadoId));

            //    var _empresa = EmpresaDAO.GetEmpresa(_fornecedor.EmpresaId);

            //   CadastroDeFornecedoresForm form = new CadastroDeFornecedoresForm(_empresa, _fornecedor);

            //}
        }

        private async void btnExcluir_ClickAsync(object sender, EventArgs e)
        {
            if (listViewFornecedores.SelectedItems.Count >= 1)
            {

                string itemSelecionadoId = listViewFornecedores.SelectedItems[0].SubItems[0].Text;

                await FornecedorDAO.DeletarFornecedor(int.Parse(itemSelecionadoId));

                bindingSource_CurrentChanged(this, new EventArgs { });

            }
        }

        private void FornecedoresPorEmpresaForm_Load(object sender, EventArgs e)
        {

            PreencheBindSource(EmpresaDAO.GetEmpresas());

            groupBox2.Enabled = true;
            txtNome.DataBindings.Add("Text", bindingSource, "Nome", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCnpj.DataBindings.Add("Text", bindingSource, "CNPJ", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUf.DataBindings.Add("Text", bindingSource, "UF", false, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
