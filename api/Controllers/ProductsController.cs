using System.Data;
using api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ProductsController : ControllerBase
{
    private readonly IDatabaseService _db;

    public ProductsController(IDatabaseService db)
    {
        _db = db;
    }
    
    [HttpGet(Name = "GetAllProducts")]
    public async Task<IActionResult> Get()
    {
       try
       {
            List<Dictionary<string, object?>> rows = await _db.QueryAsync("GetProducts");
            
            List<Product> products = rows.Select(MapToProduct).ToList();
            return Ok(products);
       }
       catch
       {
            // Log the exception (not shown here)
            return StatusCode(500, "An error occurred while processing your request.");
       }
    }

    private static Product MapToProduct(Dictionary<string, object?> row) => new Product
    {
      ProductID = Convert.ToInt32(row["ProductID"]),
      ProductName = row["ProductName"]?.ToString() ?? string.Empty,
      CategoryID = Convert.ToInt32(row["CategoryID"]),
      SubcategoryID = Convert.ToInt32(row["SubcategoryID"]),
      Category = row["Category"]?.ToString() ?? string.Empty,
      Subcategory = row["Subcategory"]?.ToString() ?? string.Empty,
      UnitPrice = Convert.ToDecimal(row["UnitPrice"]),
      Quantity = Convert.ToInt32(row["Quantity"])
    };
}