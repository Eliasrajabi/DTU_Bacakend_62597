
using System.ComponentModel.DataAnnotations;


namespace backend.Data.Data_transfer_object
{
    public class Post_LoginDto
    {
     
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        
       
    }
}