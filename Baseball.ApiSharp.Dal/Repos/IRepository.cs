#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

#pragma warning disable 1591 
using System.Threading.Tasks;

namespace Baseball.ApiSharp.Dal.Repos {

    public interface IRepository : IReadRepository
    {
        /// <summary>
        /// Create a new object to database.
        /// </summary>
        /// <param name="t">Specified a new object to create.</param>
        /// <param name="skipAsyncSave">Skip the call to async save changes</param>
        /// <returns></returns>
        Task<T> Create<T>(T t, bool skipAsyncSave = false) where T : class;

        /// <summary>
        /// Delete the object from database.
        /// </summary>
        /// <param name="t">Specified a existing object to delete.</param>
        Task<int> Delete<T>(T t) where T : class;

        /// <summary>
        /// Update object changes and save to database.
        /// </summary>
        /// <param name="t">Specified the object to save.</param>
        /// <returns></returns>
        Task<int> Update<T>(T t) where T : class;
       
        void SaveChanges();
        
    }
}