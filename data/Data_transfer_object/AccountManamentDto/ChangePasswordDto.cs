
using System.ComponentModel.DataAnnotations;


namespace backend.Data.Data_transfer_object.AccountManamentDto
{
    public class ChangePasswordDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
    }
}