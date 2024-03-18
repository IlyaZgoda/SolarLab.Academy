using SolarLab.Academy.Contracts.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarLab.Academy.Contracts.Validation
{
    public class BirthdayValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            DateTime? dateTime = (DateTime?)value;
            return dateTime != new DateTime(2024, 1, 1);
        }

        public override string FormatErrorMessage(string name)
        {
            if(name == nameof(CreateUserRequest.BirthDate))
            {
                return "Не нравится дата рождения";
            }
            return base.FormatErrorMessage(name);
        }
    }
}
