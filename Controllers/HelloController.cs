using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {

        //Get: <controller>
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/'>" +
                "<input type='text' name='name' />" + 

                "<label for='language'></label>" +
                "<select name = 'lang' id='language'/>" +
                    "<option value = '>Choose a Language</option>" +
                    "<option value = 'english'>English</option>" +
                    "<option value = 'spanish'>Spanish</option>" +
                    "<option value = 'french'>French</option>" +
                    "<option value = 'italian'>Italian</option>" +
                    "<option value = 'german'>German</option>" +
                "</select>" +
                "<input type='submit' value='Greet Me!'/>" +
                "</form>";

            return Content(html, "text/html");
        }
        // GET: /hello/welcome
        // [HttpGet]
        // [Route("/helloworld/welcome/{name?}")]
        [HttpGet("welcome/{language?}")]
        [HttpPost]
        public IActionResult CreateMessage(string lang = "", string name = "")
        {
            // string language = value;
            if (lang == "spanish")
            {
                return Content("<h1>Hola, " + name + "!</h1>", "text/html");
            }
            else if (lang == "french")
            {
                return Content("<h1>BonJour, " + name + "!</h1>", "text/html");
            }
            else if (lang == "italian")
            {
                return Content("<h1>Ciao, " + name + "!</h1>", "text/html");
            }
            else if (lang == "german")
            {
                return Content("<h1>Hallo, " + name + "!</h1>", "text/html");
            }
            return Content("<h1>Hello, " + name + "!</h1>", "text/html");
           
          

        }
    }
}
