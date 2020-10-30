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
        [HttpGet("/skills/")]
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

        // GET: /skills/form
        [HttpGet("/skills/form/")]
        public IActionResult Form()
        {

                string input = "<form method='post' action='/skills/progress/'>" +
                    "<label>Date: </label>" +
                    "<input type='date' name='date'/>" +
                    "<br>" +
                    "<label>Please select learning progress for C#: </label>" +
                    "<br>" +
                    "<select name='skillLevelCsharp' id='skillLevelCsharp'>" +
                    "<option value='high'>Master Coder</option>" +
                    "<option value='medium'>Making Apps</option>" +
                    "<option value='low'>Learning Basics</option>" +
                    "</select>" +
                    "<br>" +
                    "<label>Please select learning progress for JavaScript: </label>" +
                    "<br>" +
                    "<select name='skillLevelJavascript' id='skillLevelJavascript'>" +
                    "<option value='high'>Master Coder</option>" +
                    "<option value='medium'>Making Apps</option>" +
                    "<option value='low'>Learning Basics</option>" +
                    "</select>" +
                    "<br>" +
                    "<label>Please select learning progress for Python: </label>" +
                    "<br>" +
                    "<select name='skillLevelPython' id='skillLevelPython'>" +
                    "<option value='high'>Master Coder</option>" +
                    "<option value='medium'>Making Apps</option>" +
                    "<option value='low'>Learning Basics</option>" +
                    "</select>" +
                    "<br>" +
                    "<button type='submit'>Submit</button>" +
                    "</form>";
                return Content(input, "text/html");
      
        }

        // POST: /skills/progress
        [HttpPost("/skills/progress/")]
        public IActionResult SkillsProgress(string date, string skillLevelCsharp, string skillLevelJavascript, string skillLevelPython)
        {
            string html = "<h1>" + date + "</h1>" +
                "<table>" +
                "<tr>" +
                "<td>C#</td>" +
                "<td>" + skillLevelCsharp + "</td>" +
                "</tr>" +
                "<tr>" +
                "<td>JavaScript</td>" +
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
