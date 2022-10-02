using Microsoft.AspNetCore.Mvc;
using MyMessanger;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPCoreServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Messanger : ControllerBase
    {

        static List<Message> ListOfMessage = new List<Message>();
        // GET api/<Messanger>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            string OutputString = "Not found";
            if ((id < ListOfMessage.Count) && (id >= 0))
            {
                OutputString = JsonConvert.SerializeObject(ListOfMessage[id]);
            }
            Console.WriteLine(String.Format("Запрошено сообщение № {0} : {1}", id, OutputString));
            return OutputString;
        }

        // POST api/<Messanger>
        [HttpPost]
        public IActionResult SendMessage([FromBody] Message msg)
        {
            if (msg == null)
            {
                return BadRequest();
            }
            ListOfMessage.Add(msg);
            Console.WriteLine(String.Format("Всего сообщений: {0} Посланное сообщение: {1}", ListOfMessage.Count, msg));
            return new OkResult();
        }

       
    }
}
