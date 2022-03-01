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

  [HttpPost]
  public ActionResult<Product> AddProduct([FromForm] Product product) // FromBody and FromForm
  {
      return Ok(product);
  }

  
  [HttpPost("add")]
  public ActionResult<Product> AddProductV2([FromForm] Product product) // FromBody and FromForm
  {
      return Ok(product);
  }

  [HttpPut("{id}")]  // ../product/1111
  public ActionResult UpdateProductById(int id, [FromBody] Product product)
  {
      
      if (id != product.id){
          return BadRequest();
      }

      if (id != 1111){
          return NotFound();
      }

      return Ok(product);
  }

  [HttpDelete("{id}")]
  public ActionResult DeleteById(int id)
  {
      if (id != 1111){
          return NotFound();
      }

      return NoContent();
  }
  

  public class Product {
      public int id { get; set; }
      public string name { get; set; }
      public int price { get; set; }
  }
  
}
