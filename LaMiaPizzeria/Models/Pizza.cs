using System.ComponentModel.DataAnnotations;

namespace LaMiaPizzeria.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        [Range(1,15000)]
        public double Price { get; set; }


        public Pizza() { }

        public Pizza(string name, string description, string image, double price)
        {
            this.Name = name;
            this.Description= description;
            this.Image= image;
            this.Price= price;
        }
    }
}
