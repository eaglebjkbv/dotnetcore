﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Personnel.DAL;

namespace Personnel.DAL.Migrations
{
    [DbContext(typeof(PersonnelDbContext))]
    [Migration("20191031171812_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("Personnel.Domains.Personnel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isActive")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Personnels");
                });
#pragma warning restore 612, 618
        }
    }
}