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
        public IEnumerable<User> Get()
        {
            return  _context.Users;
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}", Name = "Get")]
        public User Get(int id)
        {
            return _context.Users.SingleOrDefault(q => q.ID == id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public async Task<ActionResult<User>> Post([FromBody] User user)
        {
            var getExistsUser = _context.Users.FirstOrDefault(q=>q.Login == user.Login
                                                     && q.Password == user.Password);

            if(getExistsUser != null)
            {
                return BadRequest(user);
            }
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }

        // PUT api/<UsersController>/5
        [HttpPut]
        public void Put([FromBody] User users)
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
