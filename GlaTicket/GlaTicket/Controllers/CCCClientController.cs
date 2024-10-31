//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace GlaTicket.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ClientController : ControllerBase
//    {
//        static public List<Client> clientList=new List<Client>();
//        // GET: api/<ClientController>
//        [HttpGet]
//        public IEnumerable<Client> Get()
//        {
//            return clientList;
//        }

//        // GET api/<ClientController>/5
//        [HttpGet("{id}")]
//        public Client Get(int id)
//        {
//            return clientList.FirstOrDefault(c => c.ClientId==id && c.ClientStatus==true);
//        }

//        // POST api/<ClientController>
//        //[HttpPost]
//        //public void Post([FromBody] string value)
//        //{
//                //ההכנסה מתבצעת בהזמנת כרטיס
//        //}

//        // PUT api/<ClientController>/5
//        [HttpPut("{id}")]
//        public void Put(int id,int eventCode)
//        {
//            //אפשרות לבטל הזמנה
//            clientList.FirstOrDefault(l => l.ClientId==id).ClientTicketList.Remove(eventCode);
//        }

//        // DELETE api/<ClientController>/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//            clientList.FirstOrDefault(l => l.ClientId == id).ClientStatus= false;
//        }
//    }
//}
