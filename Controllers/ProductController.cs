using Microsoft.AspNetCore.Mvc;

namespace net6_demo.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
  [HttpGet]
  public ActionResult<List<string>> GetProducts(){
      var products = new List<string>();
      products.Add("VueJS");
      products.Add("Flutter");
      products.Add("React");      
      return Ok(products);
  }

  [HttpGet("{id}")] // .../12
  public ActionResult GetProductById(int id)
  {
      return Ok(new {productId = id, name = "VueJs"});
  }

  [HttpGet("search/{id}/{category}")] // .../12
  public ActionResult SearchProductById(int id, string category)
  {
      return Ok(new {productId = id, name = "VueJs", cat = category});
  }

  [HttpGet("query/product")] // .../query/product?id=12&cat=web
  public ActionResult QueryProductById([FromQuery] int id, [FromQuery] string category)
  {
      return Ok(new {productId = id, name = "VueJs", cat = category});
  }

  [HttpGet("queryv2/product/{user}")] // .../query/product?id=12&cat=web
  public ActionResult QueryProductById([FromQuery] int id, [FromQuery] string category, string user)
  {
      return Ok(new {productId = id, name = "VueJs", cat = category, user = user});
  }
  
}
