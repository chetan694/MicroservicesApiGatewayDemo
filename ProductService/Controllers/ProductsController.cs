using Microsoft.AspNetCore.Mvc;
using ProductService.Model;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    static List<string> products = new();

    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok(products);
    }

    [HttpPost]
    public IActionResult AddProduct([FromBody] Product product)
    {
        products.Add(product.Name);
        return Ok("Product added");
    }
}