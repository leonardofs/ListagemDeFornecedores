using ListagemDeFornecedores.Contexto;
using ListagemDeFornecedores.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeFornecedores.Repositorios
{
    public static class FornecedorDAO
    {

        public static List<Fornecedor> GetFornecedoresPorEmpresa(int _empresaId)
        {

            using (var db = new FornecedorContext())
            {

                return db.Fornecedores.Where(f => f.EmpresaId == _empresaId).ToList();
            }

        }


        public static List<Fornecedor> GetFornecedores()
        {
            using (var db = new FornecedorContext())
            {
                return (from f in db.Fornecedores select f).ToList();
            }

        }

        public static async Task SalvarFornecedor(Fornecedor _fornecedor)
        {
            try
            {
                using (var db = new FornecedorContext())
                {

                    db.Fornecedores.Add(_fornecedor);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task EditarFornecedor(Fornecedor _fornecedor)
        {
            using (var db = new FornecedorContext())
            {
                var result = db.Fornecedores.Where(f => f.FornecedorId == _fornecedor.FornecedorId).FirstOrDefault();
                if (result != null)
                {
                    //result.Nome = _fornecedor.Nome;
                    //result.CNPJ = _fornecedor.CNPJ;
                    //result.UF = _fornecedor._empresa.UF;
                    //todo polimorfismo
                    await db.SaveChangesAsync();

                }
            }
        }

        public static async Task DeletarFornecedor(Fornecedor _fornecedor)
        {
            using (var db = new FornecedorContext())
            {
                var result = db.Fornecedores.Where(emp => emp.EmpresaId == _fornecedor.FornecedorId).FirstOrDefault();
                db.Fornecedores.Remove(result);

                await db.SaveChangesAsync();
            }
        }



    }
}
