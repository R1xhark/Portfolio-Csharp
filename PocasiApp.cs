using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Získání uživatelem zadaného města
            Console.Write("Zadejte město: ");
            string mesto = Console.ReadLine();

            // Získání a výpis informací o počasí
            ZiskejPocasi(mesto);
        }

        static async void ZiskejPocasi(string mesto)
        {
            // Připojení k API pro získání dat o počasí
            string api_url = $"http://api.openweathermap.org/data/2.5/weather?q={mesto}&appid=TVOJE_API_KLÍČ";
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(api_url);
            dynamic data = JsonConvert.DeserializeObject(response);

            // Zpracování dat a výpis informací o počasí
            double teplota = data.main.temp - 273.15;  // Převod teploty na stupně Celsius
            int vlhkost = data.main.humidity;
            string popis = data.weather[0].description;

            Console.WriteLine($"Počasí pro {mesto}:");
            Console.WriteLine($"Teplota: {teplota:F1}°C");
            Console.WriteLine($"Vlhkost: {vlhkost}%");
            Console.WriteLine($"Popis: {popis}");
        }
    }
}
