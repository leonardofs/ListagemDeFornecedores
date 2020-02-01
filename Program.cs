using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

using ListagemDeFornecedores.Contexto;
using ListagemDeFornecedores.Views;
using ListagemDeFornecedores.Entidades;

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
          var empresa = new Empresa { CNPJ = 9999999999, UF = "MG", Nome = "Empresa 1" };

             using (var db = new FornecedorContext())
                {
                    db.Empresas.Add(empresa);
                    db.SaveChanges();

                }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
