using ListagemDeFornecedores.Contexto;
using ListagemDeFornecedores.Entidades;
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
    public partial class SelecionarEmpresaForm : Form
    {
        private List<Empresa> empresasList;
        private Empresa empresaSelecionada;
        SelecionarEmpresaForm()
        {
            InitializeComponent();
        }

        public SelecionarEmpresaForm(Action<Empresa> referencia)
        {
            InitializeComponent();
            referencia(empresaSelecionada);


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SelecionarEmpresaForm_Load(object sender, EventArgs e)
        {
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


        //todo refatorar
        public List<Empresa> CarregarEmpresas()
        {

            using (var db = new FornecedorContext())
            {
                return db.Empresas.Select(x => x).ToList();
                // return  await db.Empresas.Select(x => x).ToListAsync();
            }

        }


        private void btnSelecionarEmpressas_Click(object sender, EventArgs e)
        {
            if (listViewEmpresas.SelectedItems.Count >= 1)
            {
                string itemSelecionadoId = listViewEmpresas.SelectedItems[0].SubItems[0].Text;
                empresaSelecionada = empresasList.Find(emp => emp.EmpresaId == int.Parse(itemSelecionadoId));

                this.Dispose();
            }
        }

    }
}
