using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAPI.Models
{
    [Table("reviews")]
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public int DestinationId { get; set; }
        [Required]
        public string ReviewText { get; set; }
        [Required]
        public string Author { get; set; }
        [Range(0,10)]
        public int Rating { get; set; }
    }
}