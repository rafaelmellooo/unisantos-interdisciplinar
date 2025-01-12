﻿namespace Unisantos.TI.Domain.DTO.Company;

public record ProductSectionResponseDTO
{
    public Guid Id { get; set; }

    public required string Title { get; set; }

    public ICollection<ProductResponseDTO> Products { get; set; } = new List<ProductResponseDTO>();
}