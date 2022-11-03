﻿using Microsoft.EntityFrameworkCore;
using Unisantos.TI.Core.Interfaces;
using Unisantos.TI.Domain.Entities.Address;
using Unisantos.TI.Domain.Entities.Company;
using Unisantos.TI.Domain.Entities.Token;
using Unisantos.TI.Domain.Entities.User;
using Unisantos.TI.Infrastructure.EntityMapping.Address;
using Unisantos.TI.Infrastructure.EntityMapping.Company;
using Unisantos.TI.Infrastructure.EntityMapping.Token;
using Unisantos.TI.Infrastructure.EntityMapping.User;

namespace Unisantos.TI.Infrastructure;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public DbSet<UserEntity> Users => Set<UserEntity>();

    public DbSet<TokenEntity> Tokens => Set<TokenEntity>();

    public DbSet<StateEntity> States => Set<StateEntity>();

    public DbSet<CityEntity> Cities => Set<CityEntity>();

    public DbSet<AddressEntity> Addresses => Set<AddressEntity>();

    public DbSet<CompanyEntity> Companies => Set<CompanyEntity>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<string>().HaveMaxLength(255);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserEntityMapping());
        modelBuilder.ApplyConfiguration(new TokenEntityMapping());
        modelBuilder.ApplyConfiguration(new CityEntityMapping());
        modelBuilder.ApplyConfiguration(new StateEntityMapping());
        modelBuilder.ApplyConfiguration(new AddressEntityMapping());
        modelBuilder.ApplyConfiguration(new CompanyEntityMapping());
    }
}