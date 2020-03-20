using System;
using System.Collections.Generic;

namespace WeddingMaster.Models
{
    public class Provider : User
    {
        public string Description { get; set; }
        public string CategoryId { get; set; }
        public int MinimumPrice { get; set; }
        public string Place { get; set; }
        public int NumberOfGuests { get; set; }
        public DateTime FreeDates { get; set; }
        public List<Message> Messages { get; set; }
        public int UserRating { get; set; }
    }
}