#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Baseball.ApiSharp.Api
{
    public static class MainLog
    {
        public static void LogSetup(string[] args)
        {
            Host.CreateDefaultBuilder(args).ConfigureLogging(logging => logging.SetMinimumLevel(LogLevel.Information));
        }
    }
}
