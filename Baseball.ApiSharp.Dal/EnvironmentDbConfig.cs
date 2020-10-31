#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;

namespace Baseball.ApiSharp.Dal
{
    public class EnvironmentDbConfig
    {
        public const string Undefined = "(Database connection string is undefined. Check shell environment settings.)";

        public bool UseInMemoryDb { get; set; } = false;

        private readonly IConfigurationRoot _config;

        public EnvironmentDbConfig()
        {
            var builder = new ConfigurationBuilder();
            builder.AddEnvironmentVariables();
            _config = builder.Build();
        }

        public EnvironmentDbConfig(Dictionary<string, string> configDictionary)
        {
            var builder = new ConfigurationBuilder();
            builder.AddInMemoryCollection(configDictionary);
            _config = builder.Build();
        }

        public Action<DbContextOptionsBuilder> GetDbContextOptions()
        {
            if (UseInMemoryDb)
            {
                return options => options.UseInMemoryDatabase("inmemory-environment-class");
            }
            else
            {
                if (IsSqlServerConnectionStringDefined())
                {
                    var connectionString = GenerateSqlServerConnectionString();
                    return options => options
                        .UseSqlServer(connectionString, o => o.EnableRetryOnFailure())
                        .ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.QueryClientEvaluationWarning));
                }
                else if (IsMySqlConnectionStringDefined())
                {
                    var connectionString = GenerateMySqlConnectionString();
                    return options => options
                        .UseMySql(connectionString, o => o.EnableRetryOnFailure())
                        .ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.QueryClientEvaluationWarning));
                }
                else
                {
                    throw new ApplicationException("Failed to read DB environment connection properties from host environment");
                }
            }
        }

        public bool IsMySqlConnectionStringDefined()
        {
            return GetConfigValue("MYSQL_SERVICE_HOST") != Undefined;
        }

        public bool IsSqlServerConnectionStringDefined()
        {
            return GetConfigValue("SQL_AZURE_SERVER") != Undefined;
        }

        public string GenerateMySqlConnectionString()
        {
            return $@"server={GetConfigValue("MYSQL_SERVICE_HOST")};database={GetConfigValue("MYSQL_DATABASE")};uid={
                    GetConfigValue("MYSQL_USER_ID")
                };pwd={GetConfigValue("MYSQL_USER_PASSWORD")};";
        }

        public string GenerateSqlServerConnectionString()
        {
            return
                $@"Server={GetConfigValue("SQL_AZURE_SERVER")};Initial Catalog={
                        GetConfigValue("SQL_AZURE_CATALOG")
                    };User Id={GetConfigValue("SQL_AZURE_USER_ID")};Password={
                        GetConfigValue("SQL_AZURE_USER_PASSWORD")
                    };";
        }

        private string GetConfigValue(string configKey)
        {
            var configValue = _config[configKey];
            if (string.IsNullOrEmpty(configValue))
                return Undefined;
            return configValue;
        }

        public override string ToString()
        {
            if (IsSqlServerConnectionStringDefined())
            {
                return GenerateSqlServerConnectionString();
            }
            if (IsMySqlConnectionStringDefined())
            {
                return GenerateMySqlConnectionString();
            }
            return Undefined;
        }
    }
}
