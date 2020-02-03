using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeFornecedores.Entidades
{
    public class FornecedorPJ : Fornecedor
    {

        public FornecedorPJ()
        {
            Tipo = "PJ";
        }

        //Navigation Properties

        public int EmpresaFornecedorId { get; set; }
        public virtual Empresa EmpresaFornecedor { get; set; }


    }
}
