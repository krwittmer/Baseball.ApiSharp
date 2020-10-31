#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Collections.Generic;
using Xunit;

namespace Baseball.ApiSharp.Dal.Tests
{
    public class EnvironmentDbConfigTest
    {
        private const string Localhost = "dbserver";
        private const string LahmansBaseball = "LahmansBaseball";
        private const string MySqlDbUser = "dbuser";
        private const string MySqlDbUserPassword = "dbpassw0RD";

        [Fact]
        public void DbEnvironmentReadTest()
        {
            var dbCredentials = new Dictionary<string, string>
            {
                {"MYSQL_SERVICE_HOST", Localhost},
                {"MYSQL_DATABASE", LahmansBaseball},
                {"MYSQL_USER_ID", MySqlDbUser},
                {"MYSQL_USER_PASSWORD", MySqlDbUserPassword}
            };

            var configUnderTest = new EnvironmentDbConfig(dbCredentials);
            Assert.NotNull(configUnderTest);

            var connectionString = configUnderTest.ToString();
            Assert.Equal($@"server={Localhost};database={LahmansBaseball};uid={MySqlDbUser};pwd={MySqlDbUserPassword};", connectionString);
        }

        [Fact]
        public void DbEnvironmentReadTestWithEmptyInputTest()
        {
            var dbCredentials = new Dictionary<string, string>();
            var configUnderTest = new EnvironmentDbConfig(dbCredentials);
            Assert.NotNull(configUnderTest);

            var connectionString = configUnderTest.ToString();
            Assert.Equal(EnvironmentDbConfig.Undefined, connectionString);
        }

        [Fact]
        public void DbEnvironmentReadTestWithMissingVariablesTest()
        {
            var dbCredentials = new Dictionary<string, string>
            {
                {"MYSQL_SERVICE_HOST", Localhost},
                {"MYSQL_DATABASE", LahmansBaseball}
            };

            var configUnderTest = new EnvironmentDbConfig(dbCredentials);
            Assert.NotNull(configUnderTest);

            var connectionString = configUnderTest.ToString();
            Assert.Equal($@"server={Localhost};database={LahmansBaseball};uid={EnvironmentDbConfig.Undefined};pwd={EnvironmentDbConfig.Undefined};", connectionString);
        }
    }
}
