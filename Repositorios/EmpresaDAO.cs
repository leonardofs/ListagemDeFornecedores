using ListagemDeFornecedores.Contexto;
using ListagemDeFornecedores.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeFornecedores.Repositorios
{
    public static class EmpresaDAO
    {

        public static List<Empresa> GetEmpresas()
        {

            using (var db = new FornecedorContext())
            {
                //  return db.Empresas.Select(x => x).ToList();

                return db.Empresas.ToList();
            }

        }


        public static Empresa GetEmpresa(int _empresaId)
        {

            using (var db = new FornecedorContext())
            {

                return db.Empresas.Where(emp => emp.EmpresaId == _empresaId).FirstOrDefault();
            }

        }


        public static async Task SalvarEmpresa(Empresa _empresa)
        {
            try
            {
                using (var db = new FornecedorContext())
                {

                    db.Empresas.Add(_empresa);
                    await db.SaveChangesAsync();
                }


            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task EditarEmpresa(Empresa _empresa)
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

                }
            }
        }

        public static async Task DeletarEmpresa(Empresa _empresa)
        {
            using (var db = new FornecedorContext())
            {
                var result = db.Empresas.Where(emp => emp.EmpresaId == _empresa.EmpresaId).FirstOrDefault();
                db.Empresas.Remove(result);

                await db.SaveChangesAsync();
            }
        }




    }
}
