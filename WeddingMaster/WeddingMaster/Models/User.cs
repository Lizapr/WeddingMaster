using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace WeddingMaster.Models
{
    public class User : IdentityUser
    {
        private List<Message> Messages { get; set; }
     }
}