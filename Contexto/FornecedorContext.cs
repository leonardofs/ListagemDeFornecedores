
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
        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<Fornecedor> Fornecedores { get; set; }

        public FornecedorContext()
          : base("name=FornecedorContext")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Empresa>()
                .HasKey(e => e.EmpresaId)
                .HasOptional(e => e.Fornecedores);


            // Herança com abordagem Table per Type

            modelBuilder.Entity<Fornecedor>()
                .ToTable("Fornecedores")
                .HasRequired(f => f.Empresa)
                .WithMany(e => e.Fornecedores)
                .HasForeignKey(f => f.EmpresaId);

            modelBuilder.Entity<FornecedorPJ>()
                .ToTable("Fornecedor_PJ")
                .HasRequired(f => f.EmpresaFornecedor)
                .WithMany()
                .HasForeignKey(e => e.EmpresaFornecedorId);

            modelBuilder.Entity<FornecedorPF>()
               .ToTable("Fornecedor_PF");


        }


        
    }


}
