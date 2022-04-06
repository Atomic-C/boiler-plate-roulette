﻿// <auto-generated />
using BoilerPlateRouletteSolution.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BoilerPlateRouletteSolution.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220205220739_totalNumberCountReverted")]
    partial class totalNumberCountReverted
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BoilerPlateRouletteSolution.Models.NumberStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("EvenCount")
                        .HasColumnType("float");

                    b.Property<double>("EvenPercentage")
                        .HasColumnType("float");

                    b.Property<double>("Number")
                        .HasColumnType("float");

                    b.Property<double>("OddCount")
                        .HasColumnType("float");

                    b.Property<double>("OddPercentage")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("TotalNumberCount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("NumberStats");
                });
#pragma warning restore 612, 618
        }
    }
}