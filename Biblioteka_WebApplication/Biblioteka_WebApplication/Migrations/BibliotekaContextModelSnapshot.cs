﻿// <auto-generated />
using System;
using Biblioteka_WebApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Biblioteka_WebApplication.Migrations
{
   // [DbContext(typeof(GatunekRepository))]
    partial class BibliotekaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Biblioteka_WebApplication.Models.Gatunek", b =>
                {
                    b.Property<int>("GatunekId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GatunekId");

                    b.ToTable("Gatunek");
                });

            modelBuilder.Entity("Biblioteka_WebApplication.Models.Ksiazka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ebook")
                        .HasColumnType("bit");

                    b.Property<string>("Imie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("LiczbaStron")
                        .HasColumnType("bigint");

                    b.Property<string>("Nazwisko")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tytul")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wydawnictwo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Książka");
                });

            modelBuilder.Entity("Biblioteka_WebApplication.Models.Uzytkownik", b =>
                {
                    b.Property<int>("UzytkownikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Hasło")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UzytkownikId");

                    b.ToTable("Użytkownik");
                });

            modelBuilder.Entity("Biblioteka_WebApplication.Models.Wypozyczenie", b =>
                {
                    b.Property<int>("WypozyczenieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataOddania")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataWypozyczenia")
                        .HasColumnType("datetime2");

                    b.Property<int>("KsiazkaID")
                        .HasColumnType("int");

                    b.Property<int>("UzytkownikID")
                        .HasColumnType("int");

                    b.HasKey("WypozyczenieId");

                    b.HasIndex("KsiazkaID");

                    b.HasIndex("UzytkownikID");

                    b.ToTable("Wypozyczenia");
                });

            modelBuilder.Entity("GatunekKsiazka", b =>
                {
                    b.Property<int>("GatunekId")
                        .HasColumnType("int");

                    b.Property<int>("KsiazkiId")
                        .HasColumnType("int");

                    b.HasKey("GatunekId", "KsiazkiId");

                    b.HasIndex("KsiazkiId");

                    b.ToTable("GatunekKsiazka");
                });

            modelBuilder.Entity("Biblioteka_WebApplication.Models.Wypozyczenie", b =>
                {
                    b.HasOne("Biblioteka_WebApplication.Models.Ksiazka", "Ksiazka")
                        .WithMany("Wypozyczenia")
                        .HasForeignKey("KsiazkaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Biblioteka_WebApplication.Models.Uzytkownik", "Uzytkownik")
                        .WithMany("Wypozyczenias")
                        .HasForeignKey("UzytkownikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ksiazka");

                    b.Navigation("Uzytkownik");
                });

            modelBuilder.Entity("GatunekKsiazka", b =>
                {
                    b.HasOne("Biblioteka_WebApplication.Models.Gatunek", null)
                        .WithMany()
                        .HasForeignKey("GatunekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Biblioteka_WebApplication.Models.Ksiazka", null)
                        .WithMany()
                        .HasForeignKey("KsiazkiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Biblioteka_WebApplication.Models.Ksiazka", b =>
                {
                    b.Navigation("Wypozyczenia");
                });

            modelBuilder.Entity("Biblioteka_WebApplication.Models.Uzytkownik", b =>
                {
                    b.Navigation("Wypozyczenias");
                });
#pragma warning restore 612, 618
        }
    }
}
