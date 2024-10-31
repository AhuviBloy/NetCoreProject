using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GlaTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        public static List<Client> clientList = new List<Client>();
        // GET: api/<ClientController>
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return clientList;
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public Client Get(int id)
        {
            return clientList.FirstOrDefault(c => c.ClientId == id && c.ClientStatus == true);
        }


        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id, int eventCode)
        {
            clientList.FirstOrDefault(c => c.ClientId == id).ClientTicketList.Remove(eventCode);
        }
    }
}
