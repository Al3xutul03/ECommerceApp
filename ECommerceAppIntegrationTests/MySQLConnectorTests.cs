using MySql.Data.MySqlClient;
using Utils.MySQLInterface;

namespace ECommerceAppIntegrationTests
{
    [TestFixture]
    public class MySQLConnectorTests
    {
        // Instructions:
        // 1. Add a project reference to the target AppHost project, e.g.:
        //
        //    <ItemGroup>
        //        <ProjectReference Include="../MyAspireApp.AppHost/MyAspireApp.AppHost.csproj" />
        //    </ItemGroup>
        //
        // 2. Uncomment the following example test and update 'Projects.MyAspireApp_AppHost' to match your AppHost project:
        //
        // [Test]
        // public async Task GetWebResourceRootReturnsOkStatusCode()
        // {
        //     // Arrange
        //     var appHost = await DistributedApplicationTestingBuilder.CreateAsync<Projects.MyAspireApp_AppHost>();
        //     appHost.Services.ConfigureHttpClientDefaults(clientBuilder =>
        //     {
        //         clientBuilder.AddStandardResilienceHandler();
        //     });
        //     await using var app = await appHost.BuildAsync();
        //     var resourceNotificationService = app.Services.GetRequiredService<ResourceNotificationService>();
        //     await app.StartAsync();

        //     // Act
        //     var httpClient = app.CreateHttpClient("webfrontend");
        //     await resourceNotificationService.WaitForResourceAsync("webfrontend", KnownResourceStates.Running).WaitAsync(TimeSpan.FromSeconds(30));
        //     var response = await httpClient.GetAsync("/");

        //     // Assert
        //     Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        // }

        [Test]
        public async Task CreateConnection_CreatedSuccessfullty_NoExceptions()
        {
            // Arrange
            string connectionFilePath = @"MySQL_connection.xml";
            var connector = new MySQLConnector(connectionFilePath);
            MySqlConnection connection;

            // Act
            try { connection = await connector.CreateConnection(); }

            // Assert
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Fail();
            }

            Assert.Pass();
        }
    }
}
