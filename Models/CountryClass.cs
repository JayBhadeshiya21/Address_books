using System.ComponentModel.DataAnnotations;

namespace Address_books.Models
{
    public class CountryClass
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string CountryCode { get; set; }
    }
}
