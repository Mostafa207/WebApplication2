using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        private readonly AppDbContext appDbContext;
        public userController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        [HttpGet("{id}")]
        public IActionResult Get( int id)
        {
            var user = appDbContext.Users.SingleOrDefault(x=>x.id == id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);

        }
        [HttpPost]
        public IActionResult post(dto user) {
            var ser = new user
            {
                email = user.email,
                name = user.name,
            };
            appDbContext.Users.Add(ser);
            appDbContext.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        public IActionResult delete(int id)
        {
            var user = appDbContext.Users.SingleOrDefault(x => x.id == id);
            if (user == null) {
            appDbContext.Users.Remove(user);
                appDbContext.SaveChanges();
                return Ok();
            }
            return NotFound();

        }
    }
    
}
