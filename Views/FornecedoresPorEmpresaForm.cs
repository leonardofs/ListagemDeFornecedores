using ListagemDeFornecedores.Contexto;
using ListagemDeFornecedores.Entidades;
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

        private void toolBtnCarregar_Click(object sender, EventArgs e)
        {
            List<Empresa> _empresas = CarregarEmpresas();
            foreach (Empresa emp in _empresas)
            {
                bindingSource.Add(emp);

            }

            txtNome.DataBindings.Add("Text", bindingSource, "Nome", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCnpj.DataBindings.Add("Text", bindingSource, "CNPJ", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUf.DataBindings.Add("Text", bindingSource, "UF", false, DataSourceUpdateMode.OnPropertyChanged);

        }

        //todo: ao refatorar usar a EmpresaDAO

        #region Metodos de acesso aos dados

        public List<Empresa> CarregarEmpresas()
        {
            using (var db = new FornecedorContext())
            {
                return db.Empresas.Select(x => x).ToList();
                // return  await db.Empresas.Select(x => x).ToListAsync();
            }
        }




        #endregion

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CadastroDeFornecedoresForm form = new CadastroDeFornecedoresForm((Empresa)bindingSource.Current);
            form.Show();

        }
    }
}
