﻿// <auto-generated />
using System;
using KyhProject1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KyhProject1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KyhProject1.Data.Calculator.Calculator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Operator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Result")
                        .HasColumnType("float");

                    b.Property<double>("num1")
                        .HasColumnType("float");

                    b.Property<double>("num2")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Calculators");
                });

            modelBuilder.Entity("KyhProject1.Data.RPS_Game.RPS", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Losses")
                        .HasColumnType("float");

                    b.Property<string>("PlayerChoice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rounds")
                        .HasColumnType("float");

                    b.Property<double>("Wins")
                        .HasColumnType("float");

                    b.Property<double>("winRate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("RPSGames");
                });

            modelBuilder.Entity("KyhProject1.Data.Shapes.Shape", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Area")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<double>("Perimeter")
                        .HasColumnType("float");

                    b.Property<double>("Side1")
                        .HasColumnType("float");

                    b.Property<double>("Side2")
                        .HasColumnType("float");

                    b.Property<double>("Side3")
                        .HasColumnType("float");

                    b.Property<string>("TypeOfShape")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shapes");
                });
#pragma warning restore 612, 618
        }
    }
}
