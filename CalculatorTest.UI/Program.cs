using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace CalculatorTest.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1. Using console
            //IDiagnostics diagnosticsConsole = new Diagnostics();
            //ISimpleCalculator calculatorConsole = new SimpleCalculator(diagnosticsConsole);
            //calculatorConsole.Add(201, 300);
            //// 2. Using Entity Framework
            //IDiagnostics diagnosticsEntityFramework = new Diagnostics(LoggingMode.EntityFramework, new EntityFrameworkManager());
            //ISimpleCalculator calculatorEntityFramework = new SimpleCalculator(diagnosticsEntityFramework);
            //calculatorEntityFramework.Add(20, 300);
            //// 2. Using ADO.NET
            //IDiagnostics diagnosticsAdoNet = new Diagnostics(LoggingMode.AdoNet, new AdoNetManager());
            //ISimpleCalculator calculatorAdoNet = new SimpleCalculator(diagnosticsAdoNet);
            //calculatorAdoNet.Add(120, 300);

            //4. Using Web Api 
            RunAsync().Wait();
        }
        static async Task RunAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:44302/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                var input = new Numbers
                {
                    value1 = 10,
                    value2 = 20
                };
                string json = JsonConvert.SerializeObject(input, Formatting.Indented);
                var httpContent = new StringContent(json);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var httpResponseMessage = await httpClient.PostAsync("Calculator/Add/", httpContent);
                var response = httpResponseMessage.Content.ReadAsStringAsync();
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    Console.WriteLine("Response received by the service is " + response.Result);
                    Console.ReadLine();
                }
                Console.ReadLine();
            }
        }
    }
}
