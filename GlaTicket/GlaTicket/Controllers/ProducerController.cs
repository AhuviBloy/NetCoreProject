using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GlaTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducerController : ControllerBase
    {
        public static List<Producer> producersList=new List<Producer>();
        // GET: api/<ProducerController>
        [HttpGet]
        public IEnumerable<Producer> Get()
        {
            return producersList;
        }

        // GET api/<ProducerController>/5
        [HttpGet("{id}")]
        public Producer Get(int id)
        {
            return producersList.FirstOrDefault(p=>p.ProducerId==id && p.ProducerStatus == true);
        }

        // POST api/<ProducerController>
        [HttpPost]
        public void Post(int producerId, string producerName)
        {
            producersList.Add(new Producer() {ProducerId=producerId,ProducerName=producerName,ProducerStatus=true,ProducerEventList=new List<int>() });
        }

        // DELETE api/<ProducerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            producersList.FirstOrDefault(p => p.ProducerId == id).ProducerStatus = false;
        }
    }
}
