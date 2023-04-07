using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace OpenAITest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string apiKey = "Tu-ApiKey-de-OpenAI";
            string apiUrl = "https://api.openai.com/v1/chat/completions";

            var request = new
            {
                model = "gpt-3.5-turbo",
                max_tokens = 4000,
                messages = new object[]
                {
                    new { role = "system", content = "Eres el mejor asistente del mundo" },
                    new { role = "user", content = "Qué es la inteligencia artificial avanzada?" }
                }
            };

            string requestData = JsonSerializer.Serialize(request);
            StringContent content = new StringContent(requestData, Encoding.UTF8, "application/json");

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(apiUrl, content);

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    string responseString = await httpResponseMessage.Content.ReadAsStringAsync();
                    JsonElement response = JsonSerializer.Deserialize<JsonElement>(responseString);
                    Console.WriteLine(response.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString());
                }
                else
                {
                    Console.WriteLine($"Error: {httpResponseMessage.StatusCode} - {httpResponseMessage.ReasonPhrase}");
                }
            }
        }
    }
}
