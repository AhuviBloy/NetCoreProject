using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GlaTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        static public List<Event> eventList = new List<Event>();
        // GET: api/<EventController>
        [HttpGet]
        public IEnumerable<Event> Get()
        {

            return eventList;
        }

        // GET api/<EventController>/5
        [HttpGet("{id}")]
        public Event Get(int id)
        {
            return eventList.FirstOrDefault(e => e.EventCode == id && e.EventStatus == true);
        }

        // POST api/<EventController>
        [HttpPost]
        public void Post([FromBody] Event eventt)
        {
            eventList.Add(eventt);
            if (ProducerController.producersList.Any(p => p.ProducerId == eventt.EventProducerId))
            {
                ProducerController.producersList.FirstOrDefault(p => p.ProducerId == eventt.EventProducerId).ProducerEventList.Add(eventt.EventCode);
            }

        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event eventt)
        {
            Event temp = eventList.FirstOrDefault(e => e.EventCode == id);
            temp.EventDate = eventt.EventDate;
            temp.EventPrice = eventt.EventPrice;
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            eventList.FirstOrDefault(e => e.EventCode == id).EventStatus = false;
        }
    }
}
