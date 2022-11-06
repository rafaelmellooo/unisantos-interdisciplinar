﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unisantos.TI.Domain.Entities.Company;

namespace Unisantos.TI.Infrastructure.EntityMapping.Company;

public class CompanyEntityMapping : IEntityTypeConfiguration<CompanyEntity>
{
    public void Configure(EntityTypeBuilder<CompanyEntity> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.Property(e => e.Name).IsRequired();
        builder.Property(e => e.Description).IsRequired();

        builder.HasOne(e => e.CompanyType).WithMany(e => e.Companies).HasForeignKey(e => e.CompanyTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasOne(e => e.Address).WithOne(e => e.Company).HasForeignKey<CompanyEntity>(e => e.AddressId)
            .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasOne(e => e.Admin).WithOne(e => e.Company).HasForeignKey<CompanyEntity>(e => e.AdminId)
            .OnDelete(DeleteBehavior.ClientCascade);

        builder.HasMany(e => e.Tags).WithMany(e => e.Companies).UsingEntity(j => j.ToTable("CompanyTag"));
    }
}