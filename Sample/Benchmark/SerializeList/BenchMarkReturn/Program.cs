using AspNetCoreList;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using System.Threading.Tasks;

namespace BenchMarkReturn
{
    public class Program
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public Program()
        {
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Program>();
        }

        [Benchmark]
        public void NoYieldAsync()
        {
            Task<HttpResponseMessage> task = _client.GetAsync("/api/values/NoYield");
            task.Wait();
            HttpResponseMessage httpResponseMessage = task.Result;
            httpResponseMessage.EnsureSuccessStatusCode();
        }

        [Benchmark]
        public void YieldAsync()
        {
            Task<HttpResponseMessage> task = _client.GetAsync("/api/values/Yield");
            task.Wait();
            HttpResponseMessage httpResponseMessage = task.Result;
            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
