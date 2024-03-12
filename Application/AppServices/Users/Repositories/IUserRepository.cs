using SolarLab.Academy.Contracts.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarLab.Academy.AppServices.Users.Repositories;

/// <summary>
/// Репозиторий для работы с пользователем
/// </summary>
public interface IUserRepository
{
    Task<IEnumerable<UserDto>> GetaAll(CancellationToken cancellationToken);
}
