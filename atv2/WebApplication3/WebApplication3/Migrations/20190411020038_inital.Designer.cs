﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication3.Data;

namespace WebApplication3.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190411020038_inital")]
    partial class inital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApplication3.Models.Contact", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ContactId");

                    b.Property<string>("Name")
                        .HasMaxLength(30);

                    b.Property<string>("Phone")
                        .HasMaxLength(14);

                    b.HasKey("ID");

                    b.ToTable("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
