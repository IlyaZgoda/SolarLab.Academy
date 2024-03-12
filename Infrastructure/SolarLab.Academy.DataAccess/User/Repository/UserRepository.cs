using SolarLab.Academy.AppServices.Users.Repositories;
using SolarLab.Academy.Contracts.User;


namespace SolarLab.Academy.DataAccess.User.Repository;


/// <inheritdoc/>
public class UserRepository : IUserRepository
{
    /// <inheritdoc/>
    public Task<IEnumerable<UserDto>> GetaAll(CancellationToken cancellationToken)
    {
        var users = UserList();

        return Task.Run(() => users.Select(u => new UserDto
        {
            Id = u.Id,
            FirstName = u.FirstName,
            LastName = u.LastName,
            MiddleName = u.MiddleName, 
            FullName = $"{u.LastName} {u.FirstName} {u.MiddleName}"
        }), cancellationToken);
    }

    public static List<Domain.Users.Entity.User> UserList()
    {
        return new List<Domain.Users.Entity.User>()
        {
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
        };
    }
}
