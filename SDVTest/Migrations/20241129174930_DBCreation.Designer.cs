﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SDVTest.Context;

#nullable disable

namespace SDVTest.Migrations
{
    [DbContext(typeof(SDVContext))]
    [Migration("20241129174930_DBCreation")]
    partial class DBCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SDVTest.Models.Enemies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Lvl")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Enemies");
                });

            modelBuilder.Entity("SDVTest.Models.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("lvl")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Materias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Throw Fire",
                            Name = "Fire",
                            lvl = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Throw Ice",
                            Name = "Ice",
                            lvl = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Throw Thunder",
                            Name = "Thunder",
                            lvl = 1
                        });
                });

            modelBuilder.Entity("SDVTest.Models.People", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("IdProfession")
                        .HasColumnType("int");

                    b.Property<int>("IdWeaponEquiped")
                        .HasColumnType("int");

                    b.Property<int>("Lvl")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdProfession");

                    b.HasIndex("IdWeaponEquiped");

                    b.ToTable("Peoples");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 31,
                            IdProfession = 1,
                            IdWeaponEquiped = 1,
                            Lvl = 0,
                            Name = "Cloud"
                        });
                });

            modelBuilder.Entity("SDVTest.Models.People_Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdMateria")
                        .HasColumnType("int");

                    b.Property<int>("IdPeople")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMateria");

                    b.HasIndex("IdPeople");

                    b.ToTable("People_Materia");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdMateria = 1,
                            IdPeople = 1
                        },
                        new
                        {
                            Id = 2,
                            IdMateria = 2,
                            IdPeople = 1
                        },
                        new
                        {
                            Id = 3,
                            IdMateria = 3,
                            IdPeople = 1
                        });
                });

            modelBuilder.Entity("SDVTest.Models.Professions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Professions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "SwordMaster"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Pugilist"
                        });
                });

            modelBuilder.Entity("SDVTest.Models.Vehicles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Car"
                        });
                });

            modelBuilder.Entity("SDVTest.Models.Weapons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdProfession")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdProfession");

                    b.ToTable("Weapons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdProfession = 1,
                            Name = "Buster Sword"
                        });
                });

            modelBuilder.Entity("SDVTest.Models.People", b =>
                {
                    b.HasOne("SDVTest.Models.Professions", "Professions")
                        .WithMany("People")
                        .HasForeignKey("IdProfession")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SDVTest.Models.Weapons", "Weapons")
                        .WithMany("People")
                        .HasForeignKey("IdWeaponEquiped")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Professions");

                    b.Navigation("Weapons");
                });

            modelBuilder.Entity("SDVTest.Models.People_Materia", b =>
                {
                    b.HasOne("SDVTest.Models.Materia", "Materia")
                        .WithMany("People_materia")
                        .HasForeignKey("IdMateria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SDVTest.Models.People", "People")
                        .WithMany("People_materia")
                        .HasForeignKey("IdPeople")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materia");

                    b.Navigation("People");
                });

            modelBuilder.Entity("SDVTest.Models.Weapons", b =>
                {
                    b.HasOne("SDVTest.Models.Professions", "Professions")
                        .WithMany("Weapons")
                        .HasForeignKey("IdProfession")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professions");
                });

            modelBuilder.Entity("SDVTest.Models.Materia", b =>
                {
                    b.Navigation("People_materia");
                });

            modelBuilder.Entity("SDVTest.Models.People", b =>
                {
                    b.Navigation("People_materia");
                });

            modelBuilder.Entity("SDVTest.Models.Professions", b =>
                {
                    b.Navigation("People");

                    b.Navigation("Weapons");
                });

            modelBuilder.Entity("SDVTest.Models.Weapons", b =>
                {
                    b.Navigation("People");
                });
#pragma warning restore 612, 618
        }
    }
}
