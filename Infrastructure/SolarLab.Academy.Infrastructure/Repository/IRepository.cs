using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SolarLab.Academy.Infrastructure.Repository;

public interface IRepository<TEntity> where TEntity : class
{
    /// <summary>
    /// Возвращает все элементы сущности <see cref="TEntity"/>
    /// </summary>
    /// <returns>Все элементы сущности <see cref="TEntity"/></returns>
    IQueryable<TEntity> GetAll();

    /// <summary>
    /// Возвращает все элементы сущности <see cref="TEntity"/> по предикату
    /// </summary>
    /// <param name="predicate">Предикат</param>
    /// <returns></returns>
    IQueryable<TEntity> GetFiltered(Expression<Func<TEntity, bool>> predicate);

    /// <summary>
    /// Возвращает элемент сущности по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns><see cref="TE"/></returns>
    ValueTask<TEntity> GetByIdAsync(Guid id);

    Task AddAsync(TEntity model);

    Task UpdateAsync(TEntity model);

    Task DeleteAsync(TEntity model);



}
