using Newtonsoft.Json; // Import the Newtonsoft.Json library for JSON serialization
using Furniture_Assignment2.Services;
using FurnitureAssignment2.Pages;

namespace Furniture_Assignment2.Services
{
    // Define the ProductService class responsible for retrieving product data
    public class ProductService
    {
        private readonly string _jsonFilePath; // Store the path to the JSON file

        // Constructor to initialize the ProductService with the path to the JSON file
        public ProductService(string jsonFilePath)
        {
            _jsonFilePath = jsonFilePath;
        }

        // Method to get a list of products from the JSON file
        public List<Product> GetProducts()
        {
            // Implement the logic to read product data from the JSON file
            // Read the entire content of the JSON file as a string
            string jsonData = File.ReadAllText(_jsonFilePath);

            // Deserialize the JSON data into a list of Product objects
            // using the JsonConvert.DeserializeObject method from Newtonsoft.Json library
            return JsonConvert.DeserializeObject<List<Product>>(jsonData);
        }
    }
}
