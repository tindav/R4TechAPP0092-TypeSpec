using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Ready4Tech.Kiota.Client;
using Ready4Tech.Kiota.Client.Models;

// API requires no authentication, so use the anonymous
// authentication provider
var authProvider = new AnonymousAuthenticationProvider();
// Create request adapter using the HttpClient-based implementation
var adapter = new HttpClientRequestAdapter(authProvider);
adapter.BaseUrl = "https://localhost:5001/";

// Create the API client
var client = new KiotaClient(adapter);

try
{
    // GET /geolocation/{city}
    var coordinates = await client.V1.Api.Geolocation["Issy-les-Moulineaux"].GetAsync();
    Console.WriteLine(
        $"Retrieved Lat:{coordinates?.Latitude}, Long:{coordinates?.Longitude} as coordinates for Issy-les-Moulineaux");

    // POST /DawnDusk/{CalculationType}
    var body = new DawnDuskCalculationInputRequest
    {
        Coordinates = coordinates,
        Date = DateTimeOffset.Now
    };

    var dawnDusk = await client.V1.Api.Dawndusk["All"].PostAsync(body);
    Console.WriteLine(
        $"At provided coordinates, Sunrise will be: {dawnDusk?.Sunrise}, Sunset will be: {dawnDusk?.Sunset} and Zenith will be: {dawnDusk?.Zenith}");
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
    Console.WriteLine(ex.StackTrace);
}