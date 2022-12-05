﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Unisantos.TI.Infrastructure;

#nullable disable

namespace Unisantos.TI.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221204211411_AddTriggerUpdateCompanyRating")]
    partial class AddTriggerUpdateCompanyRating
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
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
                        .HasMaxLength(9)
                        .HasColumnType("character(9)")
                        .IsFixedLength();

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

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Company.BusinessHoursEntity", b =>
                {
                    b.Property<int>("DayOfWeek")
                        .HasColumnType("integer");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uuid");

                    b.Property<TimeOnly>("ClosingTime")
                        .HasColumnType("time without time zone");

                    b.Property<TimeOnly>("OpeningTime")
                        .HasColumnType("time without time zone");

                    b.HasKey("DayOfWeek", "CompanyId");

                    b.HasIndex("CompanyId");

                    b.ToTable("BusinessHours");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Company.CompanyEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("AdminId")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Facebook")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("ImagePreviewUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Instagram")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<float?>("Rating")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("AdminId")
                        .IsUnique();

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Company.FavoriteEntity", b =>
                {
                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("CompanyId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Company.ProductEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<Guid>("ProductsSectionId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ProductsSectionId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Company.ProductsSectionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("ProductsSections");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Company.RateEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uuid");

                    b.Property<float>("Rate")
                        .HasColumnType("real");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("UserId");

                    b.ToTable("Rates");
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

                    b.Property<byte>("TagsSectionId")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("TagsSectionId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Company.TagsSectionEntity", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<byte>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.ToTable("TagsSections");
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

                    b.Property<byte>("Role")
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

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Company.BusinessHoursEntity", b =>
                {
                    b.HasOne("Unisantos.TI.Domain.Entities.Company.CompanyEntity", "Company")
                        .WithMany("BusinessHours")
                        .HasForeignKey("CompanyId")
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Company.CompanyEntity", b =>
                {
                    b.HasOne("Unisantos.TI.Domain.Entities.Address.AddressEntity", "Address")
                        .WithOne("Company")
                        .HasForeignKey("Unisantos.TI.Domain.Entities.Company.CompanyEntity", "AddressId")
                        .IsRequired();

                    b.HasOne("Unisantos.TI.Domain.Entities.User.UserEntity", "Admin")
                        .WithOne("Company")
                        .HasForeignKey("Unisantos.TI.Domain.Entities.Company.CompanyEntity", "AdminId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Company.FavoriteEntity", b =>
                {
                    b.HasOne("Unisantos.TI.Domain.Entities.Company.CompanyEntity", "Company")
                        .WithMany("Favorites")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Unisantos.TI.Domain.Entities.User.UserEntity", "User")
                        .WithMany("Favorites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Company.ProductEntity", b =>
                {
                    b.HasOne("Unisantos.TI.Domain.Entities.Company.ProductsSectionEntity", "ProductsSection")
                        .WithMany("Products")
                        .HasForeignKey("ProductsSectionId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("ProductsSection");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Company.ProductsSectionEntity", b =>
                {
                    b.HasOne("Unisantos.TI.Domain.Entities.Company.CompanyEntity", "Company")
                        .WithMany("ProductsSections")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Company.RateEntity", b =>
                {
                    b.HasOne("Unisantos.TI.Domain.Entities.Company.CompanyEntity", "Company")
                        .WithMany("Rates")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Unisantos.TI.Domain.Entities.User.UserEntity", "User")
                        .WithMany("Rates")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Company.TagEntity", b =>
                {
                    b.HasOne("Unisantos.TI.Domain.Entities.Company.TagsSectionEntity", "TagsSection")
                        .WithMany("Tags")
                        .HasForeignKey("TagsSectionId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("TagsSection");
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
                    b.Navigation("Company");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Address.CityEntity", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Address.StateEntity", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Company.CompanyEntity", b =>
                {
                    b.Navigation("BusinessHours");

                    b.Navigation("Favorites");

                    b.Navigation("ProductsSections");

                    b.Navigation("Rates");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Company.ProductsSectionEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.Company.TagsSectionEntity", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("Unisantos.TI.Domain.Entities.User.UserEntity", b =>
                {
                    b.Navigation("Company");

                    b.Navigation("Favorites");

                    b.Navigation("Rates");

                    b.Navigation("Tokens");
                });
#pragma warning restore 612, 618
        }
    }
}