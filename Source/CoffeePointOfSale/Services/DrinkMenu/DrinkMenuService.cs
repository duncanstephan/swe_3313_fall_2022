using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.Storage;
using System.Security.Cryptography.X509Certificates;

namespace CoffeePointOfSale.Services.Menu;

public class DrinkMenuService : IDrinkMenuService
{
    private readonly IStorageService _storageService;

    public DrinkMenuService(IStorageService storageService)
    {
        _storageService = storageService;
        //your DrinkMenu.json to load on start will go in the JsonStorage directory
        Drinks = _storageService.Read<Drinks>();

        
    }
    public Drinks Drinks { get; init; }
    public void Write() => _storageService.Write(Drinks);

}