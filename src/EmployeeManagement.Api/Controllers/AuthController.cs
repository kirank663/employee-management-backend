using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest req)
        {
            // placeholder - implement authentication via stored procedure later
            if (req.Username == "admin" && req.Password == "admin")
            {
                return Ok(new { token = "__placeholder_token__", username = "admin", role = "HR" });
            }
            return Unauthorized();
        }
    
    public record LoginRequest(string Username, string Password);
}
}