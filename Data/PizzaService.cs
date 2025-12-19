using System;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
namespace BlazingPizza.Data;

public class PizzaService
{
    private readonly HttpClient HttpClient;
    private readonly NavigationManager NavigationManager;
    public PizzaService(HttpClient httpClient, NavigationManager navigationManager)
    {
        HttpClient = httpClient;
        NavigationManager = navigationManager;
    }
    /*
    public async Task<PizzaSpecial[]> GetPizzasAsync()
    {
        return await HttpClient.GetFromJsonAsync<PizzaSpecial[]>(NavigationManager.BaseUri + "specials");
    }
    */
    public async Task<PizzaSpecial[]> GetPizzasFromApiAsync()
    {
        return await HttpClient.GetFromJsonAsync<PizzaSpecial[]>(NavigationManager.BaseUri + "specials");
    }
}
