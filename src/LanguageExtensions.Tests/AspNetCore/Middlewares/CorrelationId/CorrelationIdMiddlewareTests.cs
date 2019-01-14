using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Builder;
using NUnit.Framework;
using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using FluentAssertions;

namespace LanguageExtensions.Tests.AspNetCore.Middlewares.CorrelationId
{
    public class CorrelationIdMiddlewareTests
    {
        [TestCase("ping", HttpStatusCode.OK)]
        [TestCase("dummy", HttpStatusCode.NotFound)]
        public async Task Valid_request_Api_should_genrate_and_return_correlationId(string url, HttpStatusCode responseStatus)
        {
            using (var server = new TestServer(new WebHostBuilder()
                .ConfigureServices(s => s.AddCorrelationContext())
                .Configure(app => app.UseCorrelationId().AddPingEndpoint())))
            using (var client = server.CreateClient())
            {
                var response = await client.GetAsync(url);
                var responseBody = await response.Content.ReadAsStringAsync();

                string responseCorrelationId = response.Headers.GetValues("X-Correlation-ID").FirstOrDefault();
                Assert.False(string.IsNullOrWhiteSpace(responseCorrelationId));
                Assert.True(Guid.TryParse(responseCorrelationId, out var guidOutput));

                response.StatusCode.Should().Be(responseStatus);
            }
        }

        [TestCase("hello_world")]
        [TestCase("  hello_world  ")]
        [TestCase(@"!@#$%^&*()_+-=[]\{}|;':,./<>?")]
        public async Task When_valid_correlationId_passed_by_client_then_api_should_return_the_same_correlation_id(string correlationId)
        {
            using (var server = new TestServer(new WebHostBuilder()
                .ConfigureServices(s => s.AddCorrelationContext())
                .Configure(app => app.UseCorrelationId().AddPingEndpoint())))
            using (var client = server.CreateClient())
            {
                client.DefaultRequestHeaders.Add("X-Correlation-ID", correlationId);
                var response = await client.GetAsync("ping");
                var responseBody = await response.Content.ReadAsStringAsync();

                response.Headers.GetValues("X-Correlation-ID").FirstOrDefault().Should().Be(correlationId);
                response.StatusCode.Should().Be(HttpStatusCode.OK);
                responseBody.Should().BeEquivalentTo("pong");
            }
        }

        [TestCase("")]
        [TestCase("      ")]
        [TestCase(null)]
        public async Task When_invalid_correlationId_passed_by_client_then_api_should_generate_and_return_new_correlation_id(string correlationId)
        {
            using (var server = new TestServer(new WebHostBuilder()
                .ConfigureServices(s => s.AddCorrelationContext())
                .Configure(app => app.UseCorrelationId().AddPingEndpoint())))
            using (var client = server.CreateClient())
            {
                client.DefaultRequestHeaders.Add("X-Correlation-ID", correlationId);
                var response = await client.GetAsync("ping");
                var responseBody = await response.Content.ReadAsStringAsync();

                string responseCorrelationId = response.Headers.GetValues("X-Correlation-ID").FirstOrDefault();
                Assert.False(string.IsNullOrWhiteSpace(responseCorrelationId));
                Assert.True(Guid.TryParse(responseCorrelationId, out var guidOutput));

                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
        }
    }
}
