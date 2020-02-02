using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeFornecedores.Entidades
{
    public  class FornecedorPF : Fornecedor
    {

        public FornecedorPF()
        {
            TipoDePessoa = "PF";
        }

        public string Nome { get; set; }

        public DateTimeOffset DataNascimento { get; set; }

        public string Cpf { get; set; }

    }
}
