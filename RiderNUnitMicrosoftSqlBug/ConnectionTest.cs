using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using NUnit.Framework;

namespace RiderNUnitMicrosoftSqlBug
{
    [TestFixture]
    public sealed class ConnectionTest
    {
        [Test]
        public async Task CreateConnection()
        {
            await using var connection = SqlClientFactory.Instance.CreateConnection();
            connection.ConnectionString = "Server=.;Database=master;User ID=sa;Password=Master1234";

            await connection.OpenAsync();

            await using var command = connection.CreateCommand();
            command.CommandText = "SELECT @@VERSION";
            string text = await command.ExecuteScalarAsync() as string;

            Assert.That(text, Contains.Substring("Microsoft SQL Server"));
        }
    }
}