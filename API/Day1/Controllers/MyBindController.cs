using Day1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController] // Binding as API
    public class MyBindController : ControllerBase
    {

        // Bind Primitive Type ===> Route Segment /id ===> Query String ?id=1
        // Bind Complext Type  ===> Request Body
       /* [HttpGet("{id:int}")] // api/MyBind/1
        public IActionResult Get1(int id) // , string name , Department departemnt)
        {

            return Ok();
        }
*/
        [HttpPost]   
        public IActionResult Add(Department department , string name) // Request Body
        {
            return Ok();
        }

        [HttpGet("{id:int}/{name:alpha}")] // api/mybind/1?name=ahmed
        public IActionResult Get2(int id,string name)
        {
            return Ok();    
        }

        [HttpGet("{id:int}")]
        public IActionResult Get3(int id ,[FromBody] string name)
        {
            return Ok();
        }

        [HttpGet("{Name:alpha}/{Manager:alpha}/{age:int}")]
        public IActionResult Get4([FromBody] int id,int age, [FromRoute] Department department)
        {
            return Ok("Has been Done Successfully");
        }
    }
}
