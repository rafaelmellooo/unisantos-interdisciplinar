﻿namespace Unisantos.TI.Domain.Entities.Company;

public class TagsSectionEntity
{
    public byte Id { get; set; }

    public required string Title { get; set; }

    public ICollection<TagEntity> Tags { get; set; } = new List<TagEntity>();
}