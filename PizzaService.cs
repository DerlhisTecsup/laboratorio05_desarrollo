// PizzaService.cs
using System.Threading.Tasks;

namespace BlazingPizza.Data
{
    public class PizzaService
    {
        // Simulación de datos en lugar de una base de datos
        private static readonly Pizza[] pizzas = new[]
        {
            new Pizza { PizzaId = 1, Name = "Margherita", Description = "Tomato, mozzarella, and basil", Price = 8.99m, Vegetarian = true, Vegan = false },
            new Pizza { PizzaId = 2, Name = "Pepperoni", Description = "Tomato sauce, mozzarella, and pepperoni", Price = 9.99m, Vegetarian = false, Vegan = false },
            new Pizza { PizzaId = 3, Name = "Veggie", Description = "Mixed vegetables with mozzarella", Price = 10.99m, Vegetarian = true, Vegan = true }
        };

        public Task<Pizza[]> GetPizzasAsync()
        {
            // Simulamos una llamada asincrónica
            return Task.FromResult(pizzas);
        }
    }
}
