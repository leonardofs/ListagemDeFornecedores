using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeFornecedores.Entidades
{
    public class FornecedorPJ : Fornecedor
    {
        //Navigation Properties
        public int EmpresaFornecedorId { get; set; }

        public Empresa EmpresaFornecedor { get; set; }


    }
}
