using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Training_Demo_0403.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        ///[Controller]/[ActionName]/[Parameters]
        // https://localhost:xxxx/Helloworld/Welcome
        //Requests using GET should only be used to request data (they shouldn't include data).
        //Query string- it will start with "?" after path
        //Pass parameter: name=value combination separated by &
        // https://localhost:[port]/HelloWOrld/Welcome?name=ABC&numTimes=4
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
