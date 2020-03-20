using System.Collections.Generic;

namespace WeddingMaster.Models
{
    public class Guest : User
    {
        public List<Review> Reviews { get; set; }
    }
}