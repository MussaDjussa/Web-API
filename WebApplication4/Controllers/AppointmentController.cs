using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private ApplicationContext _context;
        public AppointmentController(ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }
        // GET: api/<AppointmentController>
        [HttpGet]
        public IEnumerable<Appointment> GetAppointment()
        {
            return _context.Appointments;
        }

        // GET api/<AppointmentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AppointmentController>
        [HttpPost]
        public async Task<ActionResult<Appointment>> Post([FromBody] Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();
            return Ok(appointment);
        }

        // PUT api/<AppointmentController>/5
        [HttpPut]
        public async Task<ActionResult<Appointment>> Put([FromBody] Appointment appointment)
        {
            var getID = _context.Appointments.FirstOrDefault(q=>q.AppointmentCode == appointment.AppointmentCode);
            getID.AppointmentCode = appointment.AppointmentCode;
            getID.StartTime = appointment.StartTime;
            getID.EndTime = appointment.EndTime;
            getID.Note = appointment.Note;
            getID.Title = appointment.Title;
            getID.UserID = appointment.UserID;
            getID.Background = appointment.Background;
            
            await _context.SaveChangesAsync();
            return Ok(appointment);
            
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var getAppointment = _context.Appointments.FirstOrDefault(x => x.AppointmentCode == id);
            if (getAppointment != null)
            {
                _context.Appointments.Remove(getAppointment);
                _context.SaveChangesAsync();
            }
        }
    }
}
