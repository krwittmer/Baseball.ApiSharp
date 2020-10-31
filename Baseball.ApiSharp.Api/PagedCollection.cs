#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Collections.Generic;
using System.Linq;

namespace Baseball.ApiSharp.Api
{
    public class PagedCollection<T>
    {
        public PagedCollection(IQueryable<T> queryable, int pageIndex, int pageSize)
        {
            if (queryable != null && pageIndex >= 0 && pageSize > 0)
            {
                List = FilterList(queryable, pageIndex, pageSize);
                PageIndex = pageIndex;
                PageSize = pageSize;
                TotalCount = List.Count;

                var mod = TotalCount % pageSize;
                TotalPages = TotalCount / pageSize + (mod == 0 ? 0 : 1);
            }
            else
            {
                List = new List<T>();
            }
        }

        public IList<T> List { get; }

        public int PageIndex { get; }

        public int PageSize { get; }

        public int TotalPages { get; }

        public int TotalCount { get; }

        private IList<T> FilterList(IQueryable<T> queryable, int pageIndex, int pageSize)
        {
            var skipAmount = pageSize * (pageIndex - 1);
            var pagedList = queryable.Skip(skipAmount).Take(pageSize).ToList();
            return pagedList;
        }
    }
}
