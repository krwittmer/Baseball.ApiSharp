#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using Microsoft.AspNetCore.Mvc;

namespace Baseball.ApiSharp.Api.Interfaces
{
    interface IPitchersController
    {
        IActionResult GetPitcherById(string pitcherId, [FromQuery] int pageNumber = 0, [FromQuery] int pageSize = 25);
    }
}