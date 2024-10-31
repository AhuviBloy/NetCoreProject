//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace GlaTicket.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class EventController : ControllerBase
//    {
//        static public List<Event> EventList = new List<Event>();
//        // GET: api/<EventController>
//        [HttpGet]
//        public IEnumerable<Event> Get()
//        {
//            return EventList;
//        }

//        // GET api/<EventController>/5
//        [HttpGet("{id}")]
//        public Event Get(int id)
//        {
//            return EventList.FirstOrDefault(e => e.EventCode==id && e.EventStatus==true);
//        }

//        // POST api/<EventController>
//        [HttpPost]
//        public void Post([FromBody] Event e)
//        {
//            EventList.Add(e);
//            ProducerController.ProducerList.FirstOrDefault(p => p.ProducerId == e.EventProducerId).ProducerEventList.Add(e.EventCode);
//        }

//        // PUT api/<EventController>/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] Event e)
//        {
//            EventList.FirstOrDefault(l => l.EventCode==id).EventPrice = e.EventPrice;
//            EventList.FirstOrDefault(l => l.EventCode==id).EventDate = e.EventDate;
//        }

//        // DELETE api/<EventController>/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//            EventList.FirstOrDefault(e => e.EventCode == id).EventStatus=false;
//            ProducerController.ProducerList.FirstOrDefault(p => p.ProducerEventList.Contains(id)).ProducerEventList.Remove(id);
//            ClientController.clientList.FirstOrDefault(p => p.ClientTicketList.Contains(id)).ClientTicketList.Remove(id);
//        }
//    }
//}
