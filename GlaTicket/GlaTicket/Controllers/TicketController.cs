using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GlaTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        public static List<Ticket> ticketList = new List<Ticket>();  

        // POST api/<TicketController>
        [HttpPost]
        public void Post([FromBody] Ticket ticket)
        {
            if(EventController.eventList.Any(e=>e.EventCode==ticket.EventCode && e.EventStatus==true))
            {
                if(ClientController.clientList.Any(c=>c.ClientId==ticket.ClientId))
                {
                    ClientController.clientList.FirstOrDefault(c => c.ClientId == ticket.ClientId).ClientTicketList.Add(ticket.EventCode);
                }
                else
                {
                    ClientController.clientList.Add(new Client(){ ClientId = ticket.ClientId, ClientName = ticket.ClientName, ClientStatus = true, ClientTicketList = new List<int>() { ticket.EventCode } });
                }
            }
        }

    }
}
