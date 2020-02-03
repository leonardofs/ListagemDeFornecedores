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
        public object EmpresaDao { get; private set; }

        public FornecedoresPorEmpresaForm()
        {
            InitializeComponent();
        }

        private void toolBtnCarregar_Click(object sender, EventArgs e)
        {
            List<Empresa> _empresas = EmpresaDAO.GetEmpresas();
            foreach (Empresa emp in _empresas)
            {
                bindingSource.Add(emp);
            }

            txtNome.DataBindings.Add("Text", bindingSource, "Nome", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCnpj.DataBindings.Add("Text", bindingSource, "CNPJ", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUf.DataBindings.Add("Text", bindingSource, "UF", false, DataSourceUpdateMode.OnPropertyChanged);

        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CadastroDeFornecedoresForm form = new CadastroDeFornecedoresForm((Empresa)bindingSource.Current);
            form.Show();
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
                if (f.GetType().Name == typeof(FornecedorPF).Name)
                {
                    listViewFornecedores.Items.Add(
                      new ListViewItem(
                          new string[] {
                              f.FornecedorId.ToString(),
                              f.Tipo,
                              (f as FornecedorPF).NomeFornecedor,
                             (f as FornecedorPF).Cpf,
                             ""
                          }));
                }
                else
                if (f.GetType().Name == typeof(FornecedorPJ).GetType().Name)
                {

                    Empresa _emp = EmpresaDAO.GetEmpresa((f as FornecedorPJ).EmpresaFornecedorId);
                    listViewFornecedores.Items.Add(
                      new ListViewItem(
                          new string[] {
                              f.FornecedorId.ToString(),
                              f.Tipo,
                              _emp.Nome,
                             _emp.CNPJ,
                             _emp.UF
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
            //todo: editar fornecedor
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //todo: excluir fornecedor
        }
    }
}
