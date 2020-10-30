using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {

        // GET: /<controller>/
        [HttpGet]
        [HttpPost]
        [Route("/skills/")]
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" +
                "<h2>Three potential languages that are being worked:</h2>" +
                "<ol>" +
                "<li>C#</li>" +
                "<li>JavaScript</li>" +
                "<li>Python</li>" +
                "</ol>";
            return Content(html, "text/html");
        }

        // POST: /skills/form
        [HttpGet]
        [Route("/skills/form/")]
        public IActionResult Form()
        {

                string input = "<form method='post' action='/skills/levels/'>'" +
                    "<label>Date</label>\n" +
                    "<input type='date' name='date'></input>\n" +
                    "<label>Please select learning progress level for C#:</label>\n" +
                    "<select name='skillLevelCsharp' id='skillLevelCsharp'>" +
                    "<option value='high'>High</option>" +
                    "<option value='medium'>Medium</option>" +
                    "<option value='low'>Low</option>" +
                    "</select>" +
                    "<label>Please select learning progress level for Javascript:</label>\n" +
                    "<select name='skillLevelJavascript' id='skillLevelJavascript'>" +
                    "<option value='high'>High</option>" +
                    "<option value='medium'>Medium</option>" +
                    "<option value='low'>Low</option>" +
                    "</select>" +
                    "<label>Please select learning progress level for Python:</label>\n" +
                    "<select name='skillLevelPython' id='skillLevelPython'>" +
                    "<option value='high'>High</option>" +
                    "<option value='medium'>Medium</option>" +
                    "<option value='low'>Low</option>" +
                    "</select>" +
                    "<button type='submit'>Submit</button>" +
                    "</form>";
                return Content(input, "text/html");
      
        }

        [HttpPost("/skills/levels/")]
        public IActionResult FormResult(string date, string skillLevelCsharp, string skillLevelJavascript, string skillLevelPython)
        {
            string html = "<h1>" + date + "</h1>" +
                "<table>" +
                "<tr>" +
                "<td>C#</td>" +
                "<td>" + skillLevelCsharp + "</td>" +
                "</tr>" +
                "<tr>" +
                "<td>Javascript</td>" +
                "<td>" + skillLevelJavascript + "</td>" +
                "</tr>" +
                "<tr>" +
                "<td>Python</td>" +
                "<td>" + skillLevelPython + "</td>" +
                "</tr>" +
                "</table>";
            return Content(html, "text/html");
        }

    }
}
