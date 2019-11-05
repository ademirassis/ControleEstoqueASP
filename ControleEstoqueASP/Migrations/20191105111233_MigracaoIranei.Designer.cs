﻿// <auto-generated />
using System;
using ControleEstoqueASP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControleEstoqueASP.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20191105111233_MigracaoIranei")]
    partial class MigracaoIranei
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControleEstoqueASP.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("ControleEstoqueASP.Models.Devolucao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriaId");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<int?>("FornecedorId");

                    b.Property<int?>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Devolucoes");
                });

            modelBuilder.Entity("ControleEstoqueASP.Models.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AtualizadoEm");

                    b.Property<string>("Localizacao");

                    b.Property<int?>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Estoque");
                });

            modelBuilder.Entity("ControleEstoqueASP.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cnpj");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("ControleEstoqueASP.Models.Movimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriaId");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("EnderecoEstoque");

                    b.Property<int?>("FornecedorId");

                    b.Property<int?>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.Property<string>("TipoMovimento");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Movimentos");
                });

            modelBuilder.Entity("ControleEstoqueASP.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriaId");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("Descricao");

                    b.Property<int?>("FornecedorId");

                    b.Property<string>("Nome");

                    b.Property<double>("Preco");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("ControleEstoqueASP.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cargo");

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.Property<string>("Sexo");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ControleEstoqueASP.Models.Devolucao", b =>
                {
                    b.HasOne("ControleEstoqueASP.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");

                    b.HasOne("ControleEstoqueASP.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId");

                    b.HasOne("ControleEstoqueASP.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("ControleEstoqueASP.Models.Estoque", b =>
                {
                    b.HasOne("ControleEstoqueASP.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("ControleEstoqueASP.Models.Movimento", b =>
                {
                    b.HasOne("ControleEstoqueASP.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");

                    b.HasOne("ControleEstoqueASP.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId");

                    b.HasOne("ControleEstoqueASP.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("ControleEstoqueASP.Models.Produto", b =>
                {
                    b.HasOne("ControleEstoqueASP.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");

                    b.HasOne("ControleEstoqueASP.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId");
                });
#pragma warning restore 612, 618
        }
    }
}
