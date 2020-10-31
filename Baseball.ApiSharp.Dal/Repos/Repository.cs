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
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Baseball.ApiSharp.Dal.Repos
{
    /**
        DZone inspired Generic Repository implementation. Modified for Entity Framework Core and now a work in-progress.
        See https://dzone.com/articles/implementing-repository for background details.

        This interface IRepository derives from IReadRepository, which is the preferred interface that clients should use.  
        To support the intent of IReadRepository, the method AsNoTracking() in the call chain.
    */
    public class Repository : IRepository
    {
        private readonly DbContext _repoDbContext;
        
        public Repository(DbContext context)
        {
            _repoDbContext = context;
        }

        public T Single<T>(Expression<Func<T, bool>> expression) where T : class
        {
            return All<T>().AsNoTracking().FirstOrDefault(expression);
        }

        public IQueryable<T> All<T>() where T : class
        {
            return _repoDbContext.Set<T>().AsQueryable().AsNoTracking();
        }

        public virtual IQueryable<T> Filter<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return _repoDbContext.Set<T>().AsNoTracking().Where(predicate).AsQueryable();
        }

        public virtual IQueryable<T> Filter<T>(Expression<Func<T, bool>> filter, out int total, int index = 0,
            int size = 50) where T : class
        {
            var skipCount = index * size;
            var resetSet = filter != null
                ? _repoDbContext.Set<T>().AsNoTracking().Where(filter).AsQueryable()
                : _repoDbContext.Set<T>().AsQueryable();
            resetSet = skipCount == 0 ? resetSet.Take(size) : resetSet.Skip(skipCount).Take(size);
            total = resetSet.Count();
            return resetSet.AsQueryable();
        }

        public virtual async Task<T> Create<T>(T TObject, bool skipAsyncSave = false) where T : class
        {
            var newEntry = _repoDbContext.Set<T>().Add(TObject);
            if (!skipAsyncSave)
            {
                await _repoDbContext.SaveChangesAsync(true);
            }
            return newEntry.Entity;
        }

        public virtual async Task<int> Delete<T>(T TObject) where T : class
        {
            _repoDbContext.Set<T>().Remove(TObject);
            return await _repoDbContext.SaveChangesAsync();
        }
        public virtual async Task<int> Delete<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            var objects = Filter(predicate);
            foreach (var obj in objects)
                _repoDbContext.Set<T>().Remove(obj);
            return await _repoDbContext.SaveChangesAsync();
        }

        public virtual async Task<int> Update<T>(T TObject) where T : class
        {
            var entry = _repoDbContext.Entry(TObject);
            _repoDbContext.Set<T>().Attach(TObject);
            entry.State = EntityState.Modified;
            return await _repoDbContext.SaveChangesAsync();
        }

        public bool Contains<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            var predicateEvalCount = _repoDbContext.Set<T>().AsNoTracking().Count(predicate);
            return predicateEvalCount > 0;
        }

        public virtual async Task<T> Find<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return await _repoDbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(predicate);
        }

        public virtual void SaveChanges()
        {
            try
            {
                _repoDbContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                //A concurrency error occurred
                //Should log and handle intelligently
                throw new BaseballApiConcurrencyException("A concurrency error happened.", ex);
            }
            catch (RetryLimitExceededException ex)
            {
                //DbResiliency retry limit exceeded
                //Should log and handle intelligently
                throw new BaseballApiRetryLimitExceededException("There is a problem with you connection.", ex);
            }
            catch (DbUpdateException ex)
            {
                //Should log and handle intelligently
                if (ex.InnerException is SqlException sqlException)
                {
                    if (sqlException.Message.Contains("FOREIGN KEY constraint", StringComparison.OrdinalIgnoreCase))
                    {
                        if (sqlException.Message.Contains("table \"Tag\", column 'Id'",
                            StringComparison.OrdinalIgnoreCase))
                        {
                            throw new BaseballApiInvalidTagException($"Invalid Tag Id\r\n{ex.Message}", ex);
                        }

                        if (sqlException.Message.Contains("table \"TagRelationships\", column 'Id'",
                            StringComparison.OrdinalIgnoreCase))
                        {
                            throw new BaseballApiInvalidTagRelationshipException($"Invalid Customer Id\r\n{ex.Message}", ex);
                        }
                    }
                }

                throw new BaseballApiException("An error occurred updating the database", ex);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }


        }

        public void Dispose()
        {
            _repoDbContext?.Dispose();
        }

        public DbContext GetContext()
        {
            return _repoDbContext;
        }
    }
}