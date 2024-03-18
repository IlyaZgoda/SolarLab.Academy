using SolarLab.Academy.AppServices.Users.AppServices;
using SolarLab.Academy.AppServices.Users.Repositories;
using SolarLab.Academy.AppServices.Validators;
using SolarLab.Academy.Contracts.User;
using SolarLab.Academy.Contracts.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        //CreateUserValidator createUserValidator = new CreateUserValidator();
        //ValidationResult validationResult = createUserValidator.Validate(new CreateUserRequest());
        return _userRepository.GetaAll(cancellationToken);
    }

    //public Task<UserDto> CreateUserAsync(CreateUserRequest request)
    //{
    //    var user = _userRepository.Get();

    //    if(user != null)
    //    {
    //        throw new AlreadyExsistException();
    //    }
    //}
}
