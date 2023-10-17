using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static async Task Main(string[] args)
    {
        string apiUrl = "http://localhost/api/api.php?x=10&y=55";

        using (HttpClient httpClient = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    var responseObject = JsonConvert.DeserializeObject<MyApiResponse>(responseBody);

                    string data = responseObject.data;

                    Console.WriteLine($"Data: {data}");

                    Console.WriteLine("Respuesta de la API:");
                    Console.WriteLine(responseBody);
                }
                else
                {
                    Console.WriteLine($"Error en la solicitud. Código de estado: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en la solicitud: {ex.Message}");
            }
        }
    }

    public class MyApiResponse
    {
        public string data { get; set; }
    }
}