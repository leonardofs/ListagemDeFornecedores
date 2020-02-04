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


        public static Fornecedor GetFornecedor(int _fornecedorId)
        {

            using (var db = new FornecedorContext())
            {

                return db.Fornecedores.Where(fornecedor => fornecedor.FornecedorId == _fornecedorId).FirstOrDefault();
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

            //todo: editar com polimorfismo.
            //using (var db = new FornecedorContext())
            //{
            //    var result = db.Fornecedores.Where(f => f.FornecedorId == _fornecedor.FornecedorId).FirstOrDefault();
            //    if (result != null)
            //    {
            //        await db.SaveChangesAsync();
            //    }
            //}
        }

        public static async Task DeletarFornecedor(int _fornecedorId)
        {
            using (var db = new FornecedorContext())
            {
                var result = db.Fornecedores.Where(forn=> forn.FornecedorId == _fornecedorId).FirstOrDefault();
                db.Fornecedores.Remove(result);

                await db.SaveChangesAsync();
            }
        }



    }
}
