using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCWebApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }

        //https://localhost:44366/HelloWorld/Welcome?name=Andrew&numTimes=4

        public string Welcome(string name, int numTimes = 1) 
        {
            return HtmlEncoder.Default.Encode($"Hello {name}. Nuntimes is: {numTimes}");
        }

        //https://localhost:44366/HelloWorld/Welcome/4?name=Andrew
        public string Hello(string name, int ID = 1) 
        {
            return HtmlEncoder.Default.Encode($"Hello {name} your ID: {ID}");
        }
    }
}