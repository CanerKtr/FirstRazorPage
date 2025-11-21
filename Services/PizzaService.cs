using WebApplication1.Models;
using WebApplication1.Data;
namespace WebApplication1.Services
{
    public class PizzaService
    {
        private readonly WebAppDbContext _context = default!;

        public PizzaService(WebAppDbContext context)
        {
            _context = context;
        }

        public IList<Pizza> GetPizzas()
        {
            if (_context.Pizzas != null)
            {
                return _context.Pizzas.ToList();
            }
            return new List<Pizza>();
        }

        public void AddPizza(Pizza pizza)
        {
            if (_context.Pizzas != null)
            {
                _context.Pizzas.Add(pizza);
                _context.SaveChanges();
            }
        }

        public void DeletePizza(int id)
        {
            if (_context.Pizzas != null)
            {
                var pizza = _context.Pizzas.Find(id);
                if (pizza != null)
                {
                    _context.Pizzas.Remove(pizza);
                    _context.SaveChanges();
                }
            }
        }
    }
}
