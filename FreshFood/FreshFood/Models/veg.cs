using System.ComponentModel.DataAnnotations;

namespace FreshFood.Models
{
    public class veg
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Item Name Should Greater Than 3 chars..")]
        public string Name { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Item Dispcription Should Greater Than 3 chars..")]
        public string Description { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
     
        public float? Price { get; set; }
        [Required]
        public string ImageUrl{ get; set; }
        [Required]
        public string Quantiy { get; set; }
        
    }
}
