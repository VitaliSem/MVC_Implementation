using Microsoft.AspNetCore.Http;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace CRM_for_English_School.IntegrationTests
{
    public class AsyncBenchmark
    {
        private const string BaseUrl = "http://localhost:28157";
        private const int NumberOfRequests = 250;

        public static async Task RunRequestsAsync(HttpContext context)
        {
            await RunRequest("api/teachers/async", context);
        }


        public static async Task RunRequestsSync(HttpContext context)
        {
            await RunRequest("api/teachers", context);
        }

        private static async Task RunRequest(string endpoint, HttpContext context)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (var i = 0; i < NumberOfRequests; i++)
            {
                using var client = new HttpClient();
                client.BaseAddress = new Uri(BaseUrl);
                var result = await client.GetAsync(endpoint);
            }
            stopWatch.Stop();
            TimeSpan timeSpan = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
            timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds,
            timeSpan.Milliseconds / 10);
            await context.Response.WriteAsync("Runtime: " + elapsedTime);
        }
    }
}
