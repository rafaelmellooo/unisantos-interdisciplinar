﻿using Unisantos.TI.Domain.Entities.Company;
using Unisantos.TI.Domain.Entities.Token;
using Unisantos.TI.Domain.Enums.User;

namespace Unisantos.TI.Domain.Entities.User;

public class UserEntity
{
    public Guid Id { get; set; }

    public string Email { get; set; }

    public string Name { get; set; }

    public string Password { get; set; }

    public UserType Type { get; set; }

    public DateTime CreatedAt { get; set; }

    public ICollection<TokenEntity> Tokens { get; set; } = new List<TokenEntity>();

    public CompanyEntity Company { get; set; }

    public ICollection<FavoriteEntity> Favorites { get; set; } = new List<FavoriteEntity>();

    public ICollection<RateEntity> Rates { get; set; } = new List<RateEntity>();
}