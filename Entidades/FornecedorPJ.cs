using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeFornecedores.Entidades
{
    public class FornecedorPJ : Fornecedor
    {
        // propiedades para relacionamento do entity framework
        public virtual Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
    }
}
