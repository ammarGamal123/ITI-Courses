using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class FirstController : Controller
    {
        // Controller is a set of classes of methods the main goal is to catch the request
        // what is request? request = class/request
        // Url : First/Weclome
        // While you call the class from Controller you don't  have to end with "Controller"
        // Just call the class name without it
        
        
        
        // Action : Any Method inside class called "Action"
        // Action Contraints : 1) Must be  public
        //                     2) Can't be static (we won't to make it viewed by anyone)
        //                     3) Can't be overload (it will confuse the runtime because it can't determine which function should i gooo)
        
        // Url : first/welcome
        public string Welcome()
        {
            return $"Welcome From First Actoin";
        }


        // Url : first/welcome2
        public IActionResult Welcome2()
        {
            // Conditions : 
            // 1) declare object
            // 2) set values
            // 3) return object

            return Content("Page With New Syntax");
        }

        
        // ViewResult is related to HTML files
        // first/getData
        public IActionResult getView()
        {
           

            return View("MyView");
        }

        // first/getJson
        public IActionResult getJson()
        {
            
            return Json(new { Id = 3 , Name = "Ammar Hammad" });
        }

        // return type which Actions?
        // 1) String     ====> ContentResult
        // 2)Views(HTML) ====> ViewResult
        // 3) JavaScript ====> JavaSriptResult
        // 4) Json       ====> JsonResult
        // 5) Files      ====> FileResult


        public IActionResult getMix()
        {
            if (DateTime.Now.Day == 6)
            {

                return Content("Registration is OVER");
            }
            else
            {
                return View("MyView"); // My HTML Page
            }
        }



    }
}
