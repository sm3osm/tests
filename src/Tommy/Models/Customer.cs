using System.ComponentModel.DataAnnotations;

namespace Tommy.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Display(Name = "Telephone Number")]
        public string Phone { get; set; }

        public string Address { get; set; }
    }
}
