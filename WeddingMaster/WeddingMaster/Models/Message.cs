using System;

namespace WeddingMaster.Models
{
    public class Message
    {
        public string MessageId { get; set; }
        public string GuestId { get; set; }
        public string ProviderId { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        
    }
}