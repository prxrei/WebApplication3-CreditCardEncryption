using Microsoft.AspNetCore.Identity;

namespace WebApplication3.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName {  get; set; }

        public string CreditCard {  get; set; }
    }
}
