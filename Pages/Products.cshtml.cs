using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace FurnitureAssignment2.Pages
{
    public class ProductsModel : PageModel
    {
        public List<Product> Products { get; set; }

        public void OnGet()
        {
            // Read the JSON data from the products.json file
            string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Data", "furniture.json");
            string jsonData = System.IO.File.ReadAllText(jsonFilePath);
            
            // Deserialize the JSON data into a list of Product objects
            Products = JsonConvert.DeserializeObject<List<Product>>(jsonData);
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}
