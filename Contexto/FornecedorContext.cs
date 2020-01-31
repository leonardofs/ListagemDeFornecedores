
using ListagemDeFornecedores.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeFornecedores.Contexto
{
    public class FornecedorContext : DbContext
    {
        public DbSet<Empresa> empresas;
        public DbSet<Fornecedor> fornecedores;

        public FornecedorContext(string connectionString = "FornecedorContext")
          : base(connectionString)
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Empresa>()
                .HasKey(e => e.CNPJ)
                .HasOptional(e=>e.Fornecedores);

            modelBuilder.Entity<Fornecedor>()
                .Map<FornecedorPF>(f => f.Requires("Tipo").HasValue("PF"))
                .Map<FornecedorPJ>(f => f.Requires("Tipo").HasValue("PJ"))
                
               .HasRequired<Empresa>(f => f.Cliente)
               .WithMany(e => e.Fornecedores)               
               .HasForeignKey(f => f.ClieteId);

        }
    }


}
