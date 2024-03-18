using Microsoft.EntityFrameworkCore;
using SolarLab.Academy.AppServices.Users.Repositories;
using SolarLab.Academy.Contracts.User;
using SolarLab.Academy.Infrastructure.Repository;


namespace SolarLab.Academy.DataAccess.User.Repository;


/// <inheritdoc/>
public class UserRepository : IUserRepository
{
    private readonly IRepository<Domain.Users.Entity.User> _repository;

    /// <inheritdoc/>
    public async Task<IEnumerable<UserDto>> GetaAll(CancellationToken cancellationToken)
    {
        //var users = UserList();
        var users = await _repository.GetFiltered(u => u.LastName.Contains("Иванов")).ToListAsync(cancellationToken);

        return users.Select(u => new UserDto
        {
            Id = u.Id,
            FirstName = u.FirstName,
            LastName = u.LastName,
            MiddleName = u.MiddleName,
            FullName = $"{u.LastName} {u.FirstName} {u.MiddleName}"
        });
    }

    /// <summary>
    /// Данные якобы из БД
    /// </summary>
    /// <returns></returns>
    public static List<Domain.Users.Entity.User> UserList()
    {
        return
        [
            new()
            {
                Id = Guid.NewGuid(),
                FirstName = "Иван",
                LastName = "Иванов",
                MiddleName = "Иванович"
            },

            new()
            {
                Id = Guid.NewGuid(),
                FirstName = "Петр",
                LastName = "Петров",
                MiddleName = "Иванович"
            }
        ];
    }
}
