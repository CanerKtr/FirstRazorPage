using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        [Required]
        public PizzaType PizzaName { get; set; }
        public PizzaSize Size { get; set; }
        public bool IsGlutenFree { get; set; }

        [Range(0.01, 9999.99)]
        public decimal Price { get; set; }
    }

    public enum PizzaSize
    {
        Small, 
        Medium, 
        Large
    }
    public enum PizzaType
    {
        Margherita,
        Pepperoni,
        BBQChicken,
        Veggie,
        Hawaiian
    }
}