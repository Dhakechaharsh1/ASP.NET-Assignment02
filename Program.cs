using Microsoft.AspNetCore.Builder; 
using Microsoft.AspNetCore.Hosting; 
using Microsoft.Extensions.DependencyInjection; 
using Microsoft.Extensions.Hosting; 

namespace Furniture_Assignment2
{
    // Define the Program class responsible for configuring and starting the web application
    public class Program
    {
        // The entry point of the application
        public static void Main(string[] args)
        {
            // Create a new WebApplication instance using the provided arguments
            var builder = WebApplication.CreateBuilder(args);

            // Add Razor Pages support to the services collection
            builder.Services.AddRazorPages();

            // Build the WebApplication
            var app = builder.Build();

            // Check if the application is not running in the Development environment
            if (!app.Environment.IsDevelopment())
            {
                // Configure the application to use an error handling page at "/Error" for non-development environments
                app.UseExceptionHandler("/Error");

                // Enable HTTP Strict Transport Security (HSTS) to enforce secure connections for non-development environments
                app.UseHsts();
            }

            // Configure the application to redirect HTTP requests to HTTPS
            app.UseHttpsRedirection();

            // Serve static files (e.g., CSS, JavaScript, images) from wwwroot directory
            app.UseStaticFiles();

            // Enable routing for incoming HTTP requests
            app.UseRouting();

            // Enable authorization, if any, for the application
            app.UseAuthorization();

            // Map the Razor Pages endpoint to the application's request pipeline
            app.MapRazorPages();

            // Start listening to incoming HTTP requests
            app.Run();
        }
    }
}
