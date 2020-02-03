using ListagemDeFornecedores.Contexto;
using ListagemDeFornecedores.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeFornecedores.Repositorios
{
    public class DadosTeste
    {

        Empresa empresa;
        Fornecedor fornecedor;
        Task task, task2, task3, task4, task5, task6, task7, task8, task9;
        public void PopulaBancoEmpresas()
        {
            int count = 0;

            using (var db = new FornecedorContext())
            {
               count = db.Empresas.Count();
            }

            if (count == 0) {

            empresa = new Empresa { Nome = "Empresa 1", CNPJ = "20,147,161/0001-10", UF = "MG" };
            task = EmpresaDAO.SalvarEmpresa(empresa);

            empresa = new Empresa { Nome = "Empresa 2", CNPJ = "20,147,161/0001-10", UF = "SP" };
            task2 = EmpresaDAO.SalvarEmpresa(empresa);

            empresa = new Empresa { Nome = "Empresa 3", CNPJ = "20,147,161/0001-10", UF = "AC" };
            task3  = EmpresaDAO.SalvarEmpresa(empresa);

            empresa = new Empresa { Nome = "Empresa 4", CNPJ = "20,147,161/0001-10", UF = "AL" };
            task4  = EmpresaDAO.SalvarEmpresa(empresa);

            empresa = new Empresa { Nome = "Empresa 5", CNPJ = "20,147,161/0001-10", UF = "RS" };
            task5= EmpresaDAO.SalvarEmpresa(empresa);

            empresa = new Empresa { Nome = "Empresa 6", CNPJ = "20,147,161/0001-10", UF = "MT" };
            task6 = EmpresaDAO.SalvarEmpresa(empresa);

            empresa = new Empresa { Nome = "Empresa 7", CNPJ = "20,147,161/0001-10", UF = "MS" };
            task7 = EmpresaDAO.SalvarEmpresa(empresa);

            empresa = new Empresa { Nome = "Empresa 8", CNPJ = "20,147,161/0001-10", UF = "PE" };
            task8 = EmpresaDAO.SalvarEmpresa(empresa);

            empresa = new Empresa { Nome = "Empresa 9", CNPJ = "20,147,161/0001-10", UF = "RO" };
            task9 = EmpresaDAO.SalvarEmpresa(empresa);
            }
        }

        public void PopulaBancoFornecedorEmpresa()
        {

            int count = 0;

            using (var db = new FornecedorContext())
            {
                count = db.Fornecedores.Count();
            }

            if (count == 0)
            {

                fornecedor = new FornecedorPJ {  EmpresaId = 1 , EmpresaFornecedorId= 2 };
                task = FornecedorDAO.SalvarFornecedor(fornecedor);

                fornecedor = new FornecedorPJ { EmpresaId = 1, EmpresaFornecedorId = 3 };
                task2 = FornecedorDAO.SalvarFornecedor(fornecedor);

                fornecedor = new FornecedorPJ { EmpresaId = 1, EmpresaFornecedorId = 4 };
                task3 = FornecedorDAO.SalvarFornecedor(fornecedor);

                fornecedor = new FornecedorPJ { EmpresaId = 1, EmpresaFornecedorId = 5 };
                task4 = FornecedorDAO.SalvarFornecedor(fornecedor);

                fornecedor = new FornecedorPJ { EmpresaId = 1, EmpresaFornecedorId = 6 };
                task5 = FornecedorDAO.SalvarFornecedor(fornecedor);

                fornecedor = new FornecedorPJ { EmpresaId = 2, EmpresaFornecedorId = 3 };
                task6 = FornecedorDAO.SalvarFornecedor(fornecedor);

                fornecedor = new FornecedorPJ { EmpresaId = 2, EmpresaFornecedorId = 4 };
                task7 = FornecedorDAO.SalvarFornecedor(fornecedor);

                fornecedor = new FornecedorPJ { EmpresaId = 2, EmpresaFornecedorId = 5 };
                task8 = FornecedorDAO.SalvarFornecedor(fornecedor);

                fornecedor = new FornecedorPF { EmpresaId = 1, NomeFornecedor = "Leonardo", Cpf = "015,257,428-78" };
                task = FornecedorDAO.SalvarFornecedor(fornecedor);

                fornecedor = new FornecedorPF { EmpresaId = 1, NomeFornecedor = "Andre", Cpf = "015,257,165-78" };
                task2 = FornecedorDAO.SalvarFornecedor(fornecedor);

                fornecedor = new FornecedorPF { EmpresaId = 1,  NomeFornecedor = "Renata", Cpf = "015,257,351-78" };
                task3 = FornecedorDAO.SalvarFornecedor(fornecedor);

                fornecedor = new FornecedorPF { EmpresaId = 2, NomeFornecedor = "Fernanda", Cpf = "015,257,268-78" };
                task4 = FornecedorDAO.SalvarFornecedor(fornecedor);

                fornecedor = new FornecedorPF { EmpresaId = 2, NomeFornecedor = "William", Cpf = "015,257,391-78" };
                task5 = FornecedorDAO.SalvarFornecedor(fornecedor);

                fornecedor = new FornecedorPF { EmpresaId = 3, NomeFornecedor = "Higor", Cpf = "015,257,471-78" };
                task6 = FornecedorDAO.SalvarFornecedor(fornecedor);

                fornecedor = new FornecedorPF { EmpresaId = 3, NomeFornecedor = "Geraldo", Cpf = "015,257,551-78" };
                task7 = FornecedorDAO.SalvarFornecedor(fornecedor);

                fornecedor = new FornecedorPF { EmpresaId = 4, NomeFornecedor = "Antonio", Cpf = "015,257,328-78" };
                task8 = FornecedorDAO.SalvarFornecedor(fornecedor);

                fornecedor = new FornecedorPF { EmpresaId = 5, NomeFornecedor = "Edmilson", Cpf = "015,257,789-78" };
                task9 = FornecedorDAO.SalvarFornecedor(fornecedor);

            }
        }

    }
}
