﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Unisantos.TI.Infrastructure;

#nullable disable

namespace Unisantos.TI.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CompanyEntityTagEntity", b =>
                {
                    b.Property<Guid>("CompaniesId")
                        .HasColumnType("uuid");

                    b.Property<int>("TagsId")
                        .HasColumnType("integer");

                    b.HasKey("CompaniesId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("CompanyTag", (string)null);
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Address.AddressEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<string>("Complement")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Address.CityEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("StateId")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character(255)");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Address.StateEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(2)
                        .HasColumnType("character(2)")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Company.CompanyEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Company.TagEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Token.TokenEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ExpiryAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsRevoked")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsUsed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("JwtId")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<byte>("Type")
                        .HasColumnType("smallint");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.User.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<byte>("Type")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CompanyEntityTagEntity", b =>
                {
                    b.HasOne("Unisantos.TI.Domain.Entities.Company.CompanyEntity", null)
                        .WithMany()
                        .HasForeignKey("CompaniesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Unisantos.TI.Domain.Entities.Company.TagEntity", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Address.AddressEntity", b =>
                {
                    b.HasOne("Unisantos.TI.Domain.Entities.Address.CityEntity", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityId")
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Address.CityEntity", b =>
                {
                    b.HasOne("Unisantos.TI.Domain.Entities.Address.StateEntity", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Company.CompanyEntity", b =>
                {
                    b.HasOne("Unisantos.TI.Domain.Entities.Address.AddressEntity", "Address")
                        .WithOne("Company")
                        .HasForeignKey("Unisantos.TI.Domain.Entities.Company.CompanyEntity", "AddressId")
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Token.TokenEntity", b =>
                {
                    b.HasOne("Unisantos.TI.Domain.Entities.User.UserEntity", "User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Address.AddressEntity", b =>
                {
                    b.Navigation("Company")
                        .IsRequired();
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Address.CityEntity", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Address.StateEntity", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.User.UserEntity", b =>
                {
                    b.Navigation("Tokens");
                });
#pragma warning restore 612, 618
        }
    }
}
