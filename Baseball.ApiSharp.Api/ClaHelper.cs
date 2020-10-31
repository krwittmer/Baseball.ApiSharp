#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System;
using Microsoft.Extensions.Configuration;

namespace Baseball.ApiSharp.Api
{
    public class ClaHelper
    {
        private static string GetSchemaCommand(IConfigurationRoot config)
        {
            var outValue = config["Schema:Op"];
            return outValue == null ? string.Empty : outValue.ToString();
        }

        public static bool HasMatchingArgument(string argumentPattern)
        {
            var args = Environment.GetCommandLineArgs();

            var builder = new ConfigurationBuilder();
            builder.AddCommandLine(args);
            var configuration = builder.Build();

            return HasMatchingArgument(configuration, argumentPattern);
        }

        public static bool HasMatchingArgument(IConfigurationRoot config, string argumentPattern)
        {
            var schemaCommand = GetSchemaCommand(config);
            return !string.IsNullOrWhiteSpace(schemaCommand) && schemaCommand.ToLower().StartsWith(argumentPattern);
        }
    }
}
