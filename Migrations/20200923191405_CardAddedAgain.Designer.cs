﻿// <auto-generated />
using System;
using CardApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CardApp.Migrations
{
    [DbContext(typeof(CardDbContext))]
    [Migration("20200923191405_CardAddedAgain")]
    partial class CardAddedAgain
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CardApp.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Balance")
                        .HasColumnType("int");

                    b.Property<int>("CVC")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<string>("CardHolder")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)")
                        .HasMaxLength(16);

                    b.Property<DateTime>("ExpDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}
