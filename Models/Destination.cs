using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAPI.Models
{
    [Table("destinations")]
    public class Destination
    {

        public Destination()
        {
            this.Reviews = new HashSet<Review>();
        }
        [Key]
        public int DestinationId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public double AvgRating { get; set; }
        
        
        public ICollection<Review> Reviews { get; set; }

        public void GetAvgRating()
        {
            double sum = 0;
            foreach (Review review in Reviews)
            {
                sum += review.Rating;
                Console.WriteLine(sum);
            }
            AvgRating = sum / Reviews.Count;
        }
    }
}