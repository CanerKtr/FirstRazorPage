using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerAddress { get; set; }
        [Required]
        public int CustomerPhoneNumber { get; set; }
        public IList<string> Cart { get; set; }
        public Cityies City { get; set; }
        public CustomerType CustomerType { get; set; }


    }
    public enum Cityies
    {
        NewYork,
        LosAngeles,
        Chicago,
        Houston,
        Phoenix
    }
    public enum CustomerType
    {
        Regular,
        Premium,
        VIP
    }
}
