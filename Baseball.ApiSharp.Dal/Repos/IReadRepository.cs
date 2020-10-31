#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

#pragma warning disable 1591 
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Baseball.ApiSharp.Dal.Repos {

    public interface IReadRepository : IDisposable
    {
        /// <summary>
        /// Gets all objects from database
        /// </summary>
        /// <returns></returns>
        IQueryable<T> All<T>() where T : class;
        /// <summary>
        /// Gets objects from database by filter.
        /// </summary>
        /// <param name="predicate">Specified a filter</param>
        /// <returns></returns>
        IQueryable<T> Filter<T>(Expression<Func<T, bool>> predicate) where T : class;

        /// <summary>
        /// Gets objects from database with filtering and paging.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filter">Specified a filter</param>
        /// <param name="total">Returns the total records count of the filter.</param>
        /// <param name="index">Specified the page index.</param>
        /// <param name="size">Specified the page size</param>
        /// <returns></returns>
        IQueryable<T> Filter<T>(Expression<Func<T, bool>> filter, out int total, int  index = 0, int size = 50) where T : class;

        /// <summary>
        /// Gets the object(s) is exists in database by specified filter.
        /// </summary>
        /// <param name="predicate">Specified the filter expression</param>
        /// <returns></returns>
        bool Contains<T>(Expression<Func<T, bool>> predicate) where T : class;

        /// <summary>
        /// Find object by specified expression.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<T> Find<T>(Expression<Func<T, bool>> predicate) where T : class;

        /// <summary>
        /// Select Single Item by specified expression.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
        T Single<T>(Expression<Func<T, bool>> expression) where T : class;

        /// <summary>
        /// Return the Entity Framework DbContext for direct interaction
        /// </summary>
        /// <returns></returns>
        DbContext GetContext();
    }
}
