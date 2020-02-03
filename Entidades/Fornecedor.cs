using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeFornecedores.Entidades
{
    public abstract class Fornecedor
    {
        public int FornecedorId { get; set; }



        //Navigation Properties
        public int EmpresaId { get; set; }

        public string Tipo { get; set; }

        public virtual Empresa Empresa { get; set; }




    }
}
