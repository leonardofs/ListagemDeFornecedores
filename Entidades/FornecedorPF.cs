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
            Tipo = "PF";
        }

        public string NomeFornecedor { get; set; }

        public string Cpf { get; set; }

    }
}
