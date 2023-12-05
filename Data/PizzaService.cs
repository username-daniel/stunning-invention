namespace blasat.Data;
using Microsoft.EntityFrameworkCore;
using blasat.Models;

public class PizzaService
{
    /*public Task<Pizza[]> GetPizzasAsync()
    {
        // Call your data access technology here
    }*/
    
    private readonly PizzaStoreContext _context;

    public PizzaService(PizzaStoreContext context)
    {
        _context = context;
    }

    public async Task<PizzaSpecial[]> GetPizzasAsync()
    {
        return await _context.Specials.ToArrayAsync();
    }
}