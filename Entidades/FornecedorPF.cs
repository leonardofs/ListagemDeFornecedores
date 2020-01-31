using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeFornecedores.Entidades
{
    public  class FornecedorPF : Fornecedor
    {

        public string Nome { get; set; }

        public DateTimeOffset DataNascimento { get; set; }

        public long Cpf { get; set; }

    }
}
