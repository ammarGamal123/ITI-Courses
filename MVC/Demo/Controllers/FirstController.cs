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
        public ContentResult Welcome2()
        {
            // Conditions : 
            // 1) declare object
            // 2) set values
            // 3) return object

            ContentResult result = new ContentResult();
            result.Content = $"Welcome2 From Second Action";
            return result;
        }

        
        // ViewResult is related to HTML files
        // first/getData
        public ViewResult getView()
        {
            ViewResult vResult = new ViewResult();
            vResult.ViewName = "MyView" ; 

            return vResult;
        }

        // first/getJson
        public JsonResult getJson()
        {
            JsonResult jsonResult = new JsonResult(
                new {
                   Id = 1,
                   Name = "Ahmed"
                
                }
                );


            return jsonResult;
 
        }

        // return type which Actions?
        // 1) String     ====> ContentResult
        // 2)Views(HTML) ====> ViewResult
        // 3) JavaScript ====> JavaSriptResult
        // 4) Json       ====> JsonResult
        // 5) Files      ====> FileResult






    }
}
