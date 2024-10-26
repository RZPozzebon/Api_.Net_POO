﻿// <auto-generated />
using System;
using Api_Venda.Migrations.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api_Venda.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241026145209_addProduto")]
    partial class addProduto
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Api_Venda.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CNPJ")
                        .HasColumnType("TEXT");

                    b.Property<string>("CPF")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoCliente")
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<int?>("enderecoId")
                        .HasColumnType("INTEGER");

                    b.Property<char>("sexo")
                        .HasColumnType("TEXT");

                    b.Property<string>("telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("enderecoId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Api_Venda.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bairro")
                        .HasColumnType("TEXT");

                    b.Property<string>("CEP")
                        .HasColumnType("TEXT");

                    b.Property<int>("Numero")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Rua")
                        .HasColumnType("TEXT");

                    b.Property<string>("pontoReferencia")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Api_Venda.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<char>("sexo")
                        .HasColumnType("TEXT");

                    b.Property<string>("usuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Api_Venda.Models.Cliente", b =>
                {
                    b.HasOne("Api_Venda.Models.Endereco", "endereco")
                        .WithMany()
                        .HasForeignKey("enderecoId");

                    b.Navigation("endereco");
                });
#pragma warning restore 612, 618
        }
    }
}