//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace GlaTicket.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProducerController : ControllerBase
//    {
//        static public List<Producer> ProducerList = new List<Producer>();
//        // GET: api/<ProducerController>
//        [HttpGet]
//        public IEnumerable<Producer> Get()
//        {
//            return ProducerList;
//        }

//        // GET api/<ProducerController>/5
//        [HttpGet("{id}")]
//        public Producer Get(int id)
//        {
//            return ProducerList.FirstOrDefault(p => p.ProducerId == id && p.ProducerStatus==true); ;
//        }

//        // POST api/<ProducerController>
//        [HttpPost]
//        public void Post(int producerId,string producerName)
//        {
//            ProducerList.Add(new Producer() {ProducerId=producerId,ProducerName=producerName,ProducerStatus=true,ProducerEventList=new List<int>() });
//        }

//        // PUT api/<ProducerController>/5
//        //[HttpPut("{id}")]
//        //public void Put(int id, [FromBody] p)
//        //{
            
//        //}

//        // DELETE api/<ProducerController>/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//            ProducerList.FirstOrDefault(p => p.ProducerId == id).ProducerStatus=false;
//        }
//    }
//}
