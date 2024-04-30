using Microsoft.AspNetCore.Identity;

namespace DTU_Bacakend_62597.Models
{
    public class Userr : IdentityUser 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
