﻿//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace GlaTicket.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class TicketController : ControllerBase
//    {
//        // GET: api/<TicketController>
//        //[HttpGet]
//        //public IEnumerable<string> Get()
//        //{
//        //    return new string[] { "value1", "value2" };
//        //}

//        // GET api/<TicketController>/5
//        //[HttpGet("{id}")]
//        //public string Get(int id)
//        //{
//        //    return "value";
//        //}

//        // POST api/<TicketController>
//        [HttpPost]
//        public void Post([FromBody] Ticket t)
//        {
//            if (EventController.EventList.Count(c => c.EventCode == t.EventCode) > 0 )//רק אם קיים כזה ארוע בכלל
//            {
//                if (ClientController.clientList.Count(c => c.ClientId == t.ClientId) > 0)
//                    ClientController.clientList.FirstOrDefault(c => c.ClientId == t.ClientId).ClientTicketList.Add(t.EventCode);
//                else
//                    ClientController.clientList.Add(new Client() { ClientId = t.ClientId, ClientName = t.ClientName, ClientStatus = true, ClientTicketList = new List<int>() { t.EventCode } });
                
//            }
//        }

//        // PUT api/<TicketController>/5
//        //[HttpPut("{id}")]
//        //public void Put(int id, [FromBody] string value)
//        //{
//        //}

//        // DELETE api/<TicketController>/5
//        //[HttpDelete("{id}")]
//        //public void Delete(int id)
//        //{
//        //}
//    }
//}