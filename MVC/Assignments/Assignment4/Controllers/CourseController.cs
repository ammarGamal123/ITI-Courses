using Assignment4.Models;
using Assignment4.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Assignment4.Controllers
{
    public class CourseController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        // Course/Index
        public IActionResult Index()
        {
            var courses = context.Courses.ToList();
            return View("Index", courses);
        }

        //Course/Details
        public IActionResult Details(int id)
        {
            var courseId = context.Courses.FirstOrDefault(c => c.Id == id);

            return View("details", courseId);
        }


        public IActionResult CourseTrainesDegres(int id)
        {
            CourseResultViewModel crsRstVM = new CourseResultViewModel();

            var result = (from tr in context.Traines
                          join cr in context.CourseResults
                          on tr.Id equals cr.CourseResultTranId
                          join c in context.Courses
                          on cr.CourseResultCrsId equals c.Id
                          where c.Id == id
                          select new
                          {
                              TraineeName = tr.Name,
                              CourseName = c.Name,
                              TraineeDegree = tr.Grade,
                              CourseMinDegree = c.MinDegree
                          }).ToList();


            if (result.Any()) // Check if there are any elements in the result
            {
                crsRstVM.CourseName = result.First().CourseName;// Assign the TraineeName property directly
                crsRstVM.CourseMinDegree = result.First().CourseMinDegree;// Assign the TraineeName property directly

                crsRstVM.TraineeName = result.First().TraineeName;
                crsRstVM.TraineeDegree = result.First().TraineeDegree;

                if (result.First().TraineeDegree >
                    result.First().CourseMinDegree)
                {
                    crsRstVM.TraineeColor = "green";
                }
                else crsRstVM.TraineeColor = "red";
            }


            return View("CourseTrainesDegres", crsRstVM);
        }

        public IActionResult SetCookies()
        {
            CookieOptions cookie = new CookieOptions();
            cookie.Expires = DateTime.Now.AddMinutes(5);

            Response.Cookies.Append("Name", "Ammar Hammad"); // Key , Value
            Response.Cookies.Append("Position", "Software Engineer", cookie);

            return Content("Cookies has been Set successefully");
        }

        public IActionResult GetCookies()
        {
            var name = Request.Cookies["Name"].ToString();
            var position = Request.Cookies["Position"].ToString();


            return Content($"Get Cookies : Name {name} , Position {position}");
        }

        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("Name", "Ahmed");
            HttpContext.Session.SetString("Position", "Backend Engineer");

            return Content("Set Session Saccussfully");
        }
        public IActionResult GetSession()
        {
            var name = HttpContext.Session.GetString("Name");
            var position = HttpContext.Session.GetString("Position");

            return Content($"Sessoin Data , Name {name} , Position {position}");
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
