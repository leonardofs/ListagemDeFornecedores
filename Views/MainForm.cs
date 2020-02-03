using ListagemDeFornecedores.Repositorios;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NovoFormNoPainel(new CadastroDeEmpresaForm());
            //todo abrir frame de cadastro da empresa
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo: abrir frame de cadastro de fornecedor
            NovoFormNoPainel(new CadastroDeFornecedoresForm());

        }

        private void fornecedoresPorEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo: abrir frame de listagem.
            NovoFormNoPainel(new FornecedoresPorEmpresaForm());
        }



        private void NovoFormNoPainel(Form form)
        {
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;

            //se houver algo no painel
            if (ContainerPanel.Controls.Count > 0) {
                ContainerPanel.Controls.Clear();
            }
            ContainerPanel.Controls.Add(form);
            form.Show();
        }

        private void ContainerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        

        }
}
}
