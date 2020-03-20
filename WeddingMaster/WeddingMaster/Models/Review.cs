using System;
using System.Reflection.PortableExecutable;

namespace WeddingMaster.Models
{
    public class Review
    {
        public string ReviewId { get; set; }
        public string GuestId { get; set; }
        public string ProviderId { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public int NumberOfGuests { get; set; }
        public int Rate { get; set; }
    }
}