using FluentValidation;
using SolarLab.Academy.Contracts.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarLab.Academy.AppServices.Validators;

public class CreateUserValidator : AbstractValidator<CreateUserRequest>
{
    public CreateUserValidator() 
    {
        RuleFor(x => x.FirstName).NotEmpty();
    }
}
