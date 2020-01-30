using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeFornecedores.Entidades
{
    public abstract class Fornecedor
    {
        public int Id { get; set; }


        // propiedades para relacionamento do entity framework
        public int ClieteId { get; set; }

        public Empresa Cliente { get; set; }
    }
}
