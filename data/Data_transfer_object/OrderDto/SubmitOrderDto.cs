using DTU_Bacakend_62597.Models;
using System.ComponentModel.DataAnnotations;


namespace backend.Data.Data_transfer_object.OrderDto;

public class SubmitOrderDto
{
    [Required(ErrorMessage = "Name is required")]
    [StringLength(100)]
    public string? Name { get; set; }

    [Required(ErrorMessage = "City is required")]
    [StringLength(100)]
    public string? City { get; set; }

    [Required(ErrorMessage = "Zip code is required")]
    [Range(1, int.MaxValue)]
    public string? ZipCode { get; set; }

    [Required(ErrorMessage = "Address is required")]
    [StringLength(100)]
    public string? Address { get; set; }

    [Required(ErrorMessage = "Phone is required")]
    [StringLength(100)]
    //[Phone] but this should not be used because there are different phone number formats
    public string? Phone { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [StringLength(100)]
    [EmailAddress]
    public string? Email { get; set; }

    [Required(ErrorMessage = "You must select a product")]
    public List<Product>? Products { get; set; }

    public string? Company { get; set; }
    public string? Country { get; set; }

    public string? VatNumber { get; set; }
}