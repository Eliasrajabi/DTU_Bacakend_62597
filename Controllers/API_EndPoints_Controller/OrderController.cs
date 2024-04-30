using backend.Data;
using backend.Data.Data_transfer_object.OrderDto;
using DTU_Bacakend_62597.data;
using DTU_Bacakend_62597.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controller.API_EndPoints_Controller;

[ApiController]
[Route("api/[controller]")]
public class OrderController(ApplicationDbContext databaseContext) : ControllerBase
{
    [HttpPost("/orderSubmit")]
    public async Task<IActionResult> SubmitOrder([FromBody] SubmitOrderDto submitOrderDto)
    {
        try
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var totalOrders = await databaseContext.Orders.CountAsync();

            var order = new Order
            {
                Name = submitOrderDto.Name,
                City = submitOrderDto.City,
                Address = submitOrderDto.Address,
                Phone = submitOrderDto.Phone,
                Email = submitOrderDto.Email,
                Company = submitOrderDto.Company,
                VatNumber = submitOrderDto.VatNumber,
                Products = submitOrderDto.Products,
                ZipCode = submitOrderDto.ZipCode,
                Country = submitOrderDto.Country,
                OrderId = $"order-{totalOrders + 1}"
            };

            await databaseContext.Orders.AddAsync(order);
            await databaseContext.SaveChangesAsync();

            return StatusCode(200, "Order submitted successfully.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"An error occurred while submitting order: {ex.Message}");
        }
    }
}