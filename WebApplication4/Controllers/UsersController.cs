using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using WebApplication4.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private ApplicationContext _context;
        public UsersController(ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<Users> Get()
        {
            return _context.Users;
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}", Name = "Get")]
        public Users Get(int id)
        {
            return _context.Users.SingleOrDefault(q => q.ID == id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public async Task<ActionResult<Users>> Post([FromBody] Users users)
        {
            var getExistsUser = _context.Users.FirstOrDefault(q=>q.Login == users.Login
                                                     && q.Password == users.Password);

            if(getExistsUser != null)
            {
                return BadRequest(users);
            }
            _context.Users.Add(users);
            await _context.SaveChangesAsync();
            return Ok(users);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Users users)
        {
            _context.Users.Update(users);
            _context.SaveChanges();
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var result = _context.Users.FirstOrDefault(q => q.ID == id);
            if (result != null)
            {
                _context.Users.Remove(result);
                _context.SaveChanges();

            }
        }
    }
}
