using Microsoft.EntityFrameworkCore;
using blasat.Models;

namespace blasat.Data;

public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<PizzaSpecial> Specials { get; set; }
    public DbSet<Pizza> Pizzas { get; set; }
}