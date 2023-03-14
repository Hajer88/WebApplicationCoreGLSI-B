﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationCoreGLSI_B.Models;

#nullable disable

namespace WebApplicationCoreGLSI_B.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230221152036_AddCatAndSubCat")]
    partial class AddCatAndSubCat
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplicationCoreGLSI_B.Models.Categorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("cats");
                });

            modelBuilder.Entity("WebApplicationCoreGLSI_B.Models.SousCategorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("categorieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("categorieId");

                    b.ToTable("sscats");
                });

            modelBuilder.Entity("WebApplicationCoreGLSI_B.Models.SousCategorie", b =>
                {
                    b.HasOne("WebApplicationCoreGLSI_B.Models.Categorie", "categorie")
                        .WithMany()
                        .HasForeignKey("categorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categorie");
                });
#pragma warning restore 612, 618
        }
    }
}
