﻿using System.ComponentModel.DataAnnotations;

namespace Unisantos.TI.Domain.DTO.Company;

public class CreateBusinessHoursInputDTO
{
    [Required(ErrorMessage = "O dia da semana é obrigatório")]
    public DayOfWeek DayOfWeek { get; set; }
    
    [Required(ErrorMessage = "A hora de abertura é obrigatória")]
    public TimeSpan OpeningTime { get; set; }
    
    [Required(ErrorMessage = "A hora de fechamento é obrigatória")]
    public TimeSpan ClosingTime { get; set; }
}