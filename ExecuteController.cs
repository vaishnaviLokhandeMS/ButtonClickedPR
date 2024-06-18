using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace YourAspNetCoreApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExecuteController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Execute()
        {
            try
            {
                Console.WriteLine("Execute method called"); // Debugging: Log method call
                await PRGenerationAzure.Program.Main(new string[0]); // Call the main method or any other method as required
                Console.WriteLine("PR generation completed"); // Debugging: Log completion
                return Ok("Execution Completed");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}"); // Debugging: Log any exceptions
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
