using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
                "<input type='text' name='name'>" +
                "<select name='lang' id='lang'>" +
                "<option value='english'>English</option>" +
                "<option value='french'>French</option>" +
                "<option value='spanish'>Spanish</option>" +
                "<option value='italian'>Italian</option>" +
                "<option value='german'>German</option>" +
                "</select>" +
                "<button type='submit'>Greet Me!</button>" +
                "</form>";
            return Content(html, "text/html");
        }

        // GET: /hello/welcome (uses conventional routing)

        [HttpGet("/welcome/{name?}")]
        [HttpPost]
        public IActionResult Welcome(string lang, string name = "World")
        {
            return Content(CreateMessage(lang, name), "text/html");
        }


        public static string CreateMessage(string lang, string name)
        {
            if(lang == "french")
            {
                return "<h1>Bienvenue sur mon application " + name + "!</h1>";
            }
            if (lang == "japanese")
            {
                return "<h1>Bienvenido a mi solicitud" + name + "!</h1>";
            }
            if (lang == "italian")
            {
                return "<h1>Benvenuto nella mia domanda" + name + "!</h1>";
            }
            if (lang == "german")
            {
                return "<h1>Willkommen zu meiner Bewerbung" + name + "!</h1>";
            }
            else
            {
                return "<h1>Welcome to my app, " + name + "!</h1>";
            }
        }

    }

    
}
