using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Day6.Controllers
{
    public class PassDataController : Controller
    {
        public IActionResult SetCookie()
        {
            CookieOptions cookieOption = new CookieOptions();
            cookieOption.Expires = DateTimeOffset.Now.AddHours(1);
            // Response
            Response.Cookies.Append("Name", "Assiut"); // Session Cookie
            Response.Cookies.Append("Department", "SD", cookieOption);// Persisiten cookie 
             
            return Content("Cookies Saved");
        }

        public IActionResult GetCookie()
        {
            // Request 
            string result = Request.Cookies["Name"].ToString();
            string department = Request.Cookies["Department"].ToString();
            return Content($"Cookies Frome Set Cookies {result} , {department}");
        }

        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("Name", "Intake42");
            HttpContext.Session.SetInt32("Age", 21);

            return Content("Session Saved");
        }

        public IActionResult GetSession()
        {
            var name = HttpContext.Session.GetString("Name");
            var age = HttpContext.Session.GetInt32("Age");


            return Content($"Get From Session Name : {name} , Age : {age}");
        }

        public IActionResult First()
        {
            TempData["Msg"] = "Data From First Action"; // Set
            // It will be stored at client in the Coookies (Default)

            return Content("Data Saved");
        }

        public IActionResult Second()
        {
            string msg = "Empty ";
            if (TempData.ContainsKey("Msg"))
            {
                msg = TempData["Msg"].ToString(); // Read
                TempData.Keep("Msg"); // it keeps the key and doesn't remove it


                //msg = TempData.Peek("Msg").ToString();
                // when using Peek it won't be removed as expected 
            }
            return Content("Second " + msg);
        }

        public IActionResult Third()
        {
            string msg = "Empty ";
            if (TempData.ContainsKey("Msg"))
                msg = TempData.Peek("Msg").ToString();


            
            return Content("Third " + msg);
        }
    }
}
