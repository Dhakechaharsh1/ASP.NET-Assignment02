using Microsoft.AspNetCore.Mvc.RazorPages;
using Furniture_Assignment2.Services; // Import the correct namespace for ProductService
using FurnitureAssignment2.Pages;

namespace Furniture_Assignment2.Pages
{
    // Define the Razor Page Model class for the "Products" Razor Page
    public class ProductsModel : PageModel
    {
        // Private field to hold the ProductService instance
        private readonly ProductService _productService;

        // Public property to store the list of products retrieved from the ProductService
        public List<Product> Products { get; set; }

        // Constructor for the ProductsModel class, using dependency injection to get the ProductService instance
        public ProductsModel(ProductService productService)
        {
            _productService = productService;
        }

        // Method that is automatically executed when the "Products" Razor Page is requested (HTTP GET)
        public void OnGet()
        {
            // Specify the path to the JSON file containing the product data (not used in this code snippet)
            string jsonFilePath = "path/to/products.json";

            // Call the GetProducts() method of the ProductService to retrieve the list of products
            // and assign it to the Products property, making it available for the Razor Page view
            Products = _productService.GetProducts();
        }
    }
}
