
using ListagemDeFornecedores.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
            this.Configuration.ProxyCreationEnabled = false;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Empresa>()
               .HasKey(e => e.EmpresaId);


            modelBuilder.Entity<Fornecedor>()
                .ToTable("Fornecedores")               
                .HasRequired(f => f.Empresa)
                .WithMany(e => e.Fornecedores)
                .HasForeignKey(f => f.EmpresaId);

            modelBuilder.Entity<Fornecedor>()
            .HasKey(f => f.FornecedorId);

            modelBuilder.Entity<FornecedorPJ>()
                .ToTable("Fornecedor_PJ")
                .HasRequired(pj => pj.EmpresaFornecedor)
                .WithMany()
                .HasForeignKey(e => e.EmpresaFornecedorId);

            modelBuilder.Entity<FornecedorPF>()
               .ToTable("Fornecedor_PF")
               .Property(pf =>pf.DataNascimento)
               .HasColumnType("datetime2");

        }


        
    }


}
