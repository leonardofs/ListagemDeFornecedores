using ListagemDeFornecedores.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeFornecedores.Entidades
{
    public class Empresa
    {
        public int EmpresaId { get; set; }

        public string Nome { get; set; }

        public string UF { get; set; }

        public long CNPJ { get; set; }

        //Navigation Properties

        public ICollection<Fornecedor> Fornecedores { get; set; }

        public  FornecedorPJ FornecedorPJ { get; set; }
    }
}
