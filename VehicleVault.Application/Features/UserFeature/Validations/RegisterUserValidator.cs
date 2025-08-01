﻿using FluentValidation;
using VehicleVault.Application.Features.UserFeature.DTOs;

namespace VehicleVault.Application.Features.UserFeature.Validations;

public class RegisterUserValidator: AbstractValidator<UserRegisterDto>
{
    public RegisterUserValidator()
    {
        RuleFor(user => user.Email)
            .EmailAddress().WithMessage("Invalid email format")
            .NotEmpty().WithMessage("Email must not be empty.")
            .NotNull().WithMessage("Email must not be null");
        
        RuleFor(s => s.Password)
            .MinimumLength(8).WithMessage("Password must be at least 8 characters long.")
            .MaximumLength(100).WithMessage("Password cannot exceed 100 characters.")
            .NotEmpty().WithMessage("Password must not be empty.")
            .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$")
            .WithMessage("Password must contain uppercase, lowercase, number, and special character.");
    }
}