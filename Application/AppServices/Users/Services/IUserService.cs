using SolarLab.Academy.Contracts.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarLab.Academy.AppServices.Users.AppServices;

/// <summary>
/// Сервис работы с пользователем
/// </summary>
public interface IUserService
{
    /// <summary>
    /// Возвращает всех пользователей
    /// </summary>
    /// <returns>Список пользователей <see cref="UserDto"/>.</returns>
    Task<IEnumerable<UserDto>> GetUsersAsync(CancellationToken cancellationToken);
}
