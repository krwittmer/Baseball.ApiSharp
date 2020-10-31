#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Baseball.ApiSharp.Api.Controllers
{
    public class PaginationControllerBase : ControllerBase
    {
        protected void AddHeaderPaginationMetaData(int total, int pageSize, int pageNumber)
        {
            if (Response?.Headers == null || pageSize <= 0 || total <= 0) return;
            var paginationMetadata = new
            {
                totalCount = total,
                pageSize = pageSize,
                pageNumber = pageNumber,
                totalPages = total / pageSize
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(paginationMetadata));
        }
    }
}