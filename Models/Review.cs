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
        public string ReviewText { get; set; }
        public string Author { get; set; }
        public int Rating { get; set; }
    }
}