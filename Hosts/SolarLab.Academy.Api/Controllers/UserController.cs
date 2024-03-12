using Microsoft.AspNetCore.Mvc;
using SolarLab.Academy.AppServices.Users.AppServices;

namespace SolarLab.Academy.Api.Controllers;

/// <summary>
/// Контроллер для работы с пользователями
/// </summary>
[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    /// <summary>
    /// Инициализирует экземпляр <see cref="UserController"/>
    /// </summary>
    /// <param name="userService">Сервис работы с пользователем</param>
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    /// <summary>
    /// Возвращает список пользователей
    /// </summary>
    /// <param name="cancellationToken">токен отмены операции</param>
    /// <returns>список пользователей</returns>
    [HttpGet]
    [Route("all")]
    public async Task<IActionResult> GetAllUsers(CancellationToken cancellationToken)
    {
        var result = await _userService.GetUsersAsync(cancellationToken);

        return Ok(result);
    }
}
