﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NGO.Models;

namespace NGO.Migrations
{
    [DbContext(typeof(StoreDBContext))]
    partial class StoreDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("NGO.Models.AboutUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageAbout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AboutUs");
                });

            modelBuilder.Entity("NGO.Models.Donate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateDonate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("ProgrammeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProgrammeId");

                    b.ToTable("Donates");
                });

            modelBuilder.Entity("NGO.Models.Gallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ImageGallery")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Galleries");
                });

            modelBuilder.Entity("NGO.Models.New", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagesNew")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProgrameId")
                        .HasColumnType("int");

                    b.Property<int?>("ProgrammesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProgrammesId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("NGO.Models.Ngo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageNgo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ngos");
                });

            modelBuilder.Entity("NGO.Models.Programme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Programmes");
                });

            modelBuilder.Entity("NGO.Models.Donate", b =>
                {
                    b.HasOne("NGO.Models.Programme", "Programmes")
                        .WithMany("Donates")
                        .HasForeignKey("ProgrammeId");

                    b.Navigation("Programmes");
                });

            modelBuilder.Entity("NGO.Models.New", b =>
                {
                    b.HasOne("NGO.Models.Programme", "Programmes")
                        .WithMany()
                        .HasForeignKey("ProgrammesId");

                    b.Navigation("Programmes");
                });

            modelBuilder.Entity("NGO.Models.Programme", b =>
                {
                    b.Navigation("Donates");
                });
#pragma warning restore 612, 618
        }
    }
}
