﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tutorial_ASP.NET.Data;

#nullable disable

namespace Tutorial_ASP.NET.Migrations
{
    [DbContext(typeof(AplicationDBContext))]
    [Migration("20250122004151_SeedCategoryTable")]
    partial class SeedCategoryTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tutorial_ASP.NET.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "ACCION"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "SCI-FI,"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "TERROR"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "DOCUMENTAL"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
