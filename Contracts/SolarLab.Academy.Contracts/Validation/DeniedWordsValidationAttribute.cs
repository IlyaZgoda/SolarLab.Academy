using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarLab.Academy.Contracts.Validation;

public class DeniedWordsValidationAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        if (value.ToString().Contains("bla"))
        {
            return false;
        }

        return base.IsValid(value);
    }
}
