using Microsoft.AspNetCore.Mvc;

namespace taskManager.Controllers
{
    public class ApiController : Controller
    {
        public ApiController()
        {
            //i'm the constructor
        }
        
        [HttpGet]
        public IActionResult Test()
        {
            string name = "Jay";
            return Json(name);
        }

        [HttpGet]
        public IActionResult GetTask()
        {
            return Json(null);
        }

        [HttpPost]
        public IActionResult PostTask()
        {
            return Json(null);
        }

    
    }
}