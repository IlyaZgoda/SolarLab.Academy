using SolarLab.Academy.Contracts.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarLab.Academy.Contracts.Users;
/// <summary>
/// Создает пользователя 
/// </summary>
public class CreateUserRequest
{
    /// <summary>
    /// Имя
    /// </summary>   
    //[Required(AllowEmptyStrings = false, ErrorMessage = "Введите имя")]
    //[StringLength(10)]
    //[DeniedWordsValidation]
    public string FirstName { get; set; }

    /// <summary>
    /// Фамилия
    /// </summary>

    public string LastName { get; set; }

    /// <summary>
    /// Отчество
    /// </summary>

    public string MiddleName { get; set; }

    /// <summary>
    /// Дата рождения
    /// </summary>

    public DateTime? BirthDate { get; set; }

    /// <summary>
    /// Регион проживания
    /// </summary>

    public int? Region { get; set; }
}
