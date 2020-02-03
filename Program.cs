using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

using ListagemDeFornecedores.Contexto;
using ListagemDeFornecedores.Views;
using ListagemDeFornecedores.Entidades;
using ListagemDeFornecedores.Repositorios;

namespace ListagemDeFornecedores
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

            DadosTeste dados = new DadosTeste();
            dados.PopulaBancoEmpresas();

            dados.PopulaBancoFornecedorEmpresa();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
