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

        public string Nome { get; set; }

        public UnidadesFederativas UF { get; set; }

        public int CNPJ { get; set; }

        // propiedades para relacionamento do entity framework
        public ICollection<Fornecedor> Fornecedores { get; set; }

        public virtual FornecedorPF FornecedorPF { get; set; }
    }
}
