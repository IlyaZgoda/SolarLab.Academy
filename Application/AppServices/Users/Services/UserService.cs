using SolarLab.Academy.AppServices.Users.AppServices;
using SolarLab.Academy.AppServices.Users.Repositories;
using SolarLab.Academy.Contracts.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarLab.Academy.AppServices.Users.Services;

/// <inherictdoc />
public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    /// <summary>
    /// Инициализирует экземпляр <see cref="UserService"/>
    /// </summary>
    /// <param name="userRepository">Репозиторий для работы с пользователем</param>
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    /// <inherictdoc />
    public Task<IEnumerable<UserDto>> GetUsersAsync(CancellationToken cancellationToken)
    {
        return _userRepository.GetaAll(cancellationToken);
    }
}
