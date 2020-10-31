#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Baseball.ApiSharp.Mvc.ViewComponents
{
    public class PlayersSearchViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.Run<IViewComponentResult>(() =>
            {
                return Task.Run<IViewComponentResult>(() => View("PlayersSearch"));
            });
        }
    }
}