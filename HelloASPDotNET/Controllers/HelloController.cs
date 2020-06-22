using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld/")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/'>" +                
                "<input type='text' name='name' />" +
                "<select name='language' id='language-select'>" +
                    "<option value='english'>--Please choose an option--</option>" +
                    "<option value='english'>English</option>" +
                    "<option value='spanish'>Spanish</option>" +
                    "<option value='french'>French</option>" +
                    "<option value='german'>German</option>" +
                    "<option value='arabic'>Arabic</option>" +
                    "<option value='italian'>Italian</option>" +
                "</select>" +
                "<input type='submit' value='Greet Me!' />" +                
                "</form>";
            
            return Content(html, "text/html");
        }

        // GET: /hello/welcome
        //[HttpGet]
        //[Route("/helloworld/welcome/{name?}")]
        [HttpGet("welcome/{name?}")]
        [HttpPost]
        public IActionResult Welcome(string name = "World", string language = "english")
        {
            return Content(CreateMessage(name, language));
        }

        public static string CreateMessage(string name = "World", string language = "english")
        {
            Dictionary<string, string> message = new Dictionary<string, string>();
            message.Add("english", "Hello");
            message.Add("spanish", "Hola");
            message.Add("french", "Bonjour");
            message.Add("german", "Guten Tag");
            message.Add("arabic", "Marhaba");
            message.Add("italian", "Ciao");

            return message[language] + " " + name;


        }
    }
}
