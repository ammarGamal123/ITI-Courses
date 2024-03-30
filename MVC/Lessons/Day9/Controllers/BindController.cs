using Day9.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day9.Controllers
{
    public class BindController : Controller
    {

        // Model Binding : Map Action Parameter with request data
        // (FormData - Query String - RouteData)

        // Types of Binding
        // 1- Bind Premitive type

        // How to call this method in URL 

        // if it was Get
        // Bind/testPremetive?id=1&name=Ahmed 
        // Bind/testPremetive/1?name=Ahmed&age=21&color=green&color=red&color=blue
        public IActionResult testPremetive(int id , string name , int age , string[] color)
        {
            

            return Content($"Name = {name} , Id = {id} , Age {age}");
        }



        //2- Bind Collection (Dictionary (key,value))
        // bind/testdict?name=sd&phones[ammar]=1234&phones[mido]=4321&phones[kareem]=12345
        public IActionResult testDict(Dictionary<string,int> phones , string name)
        {

            return Content($"Name = {name}"); 
        } 


        //3- Bind Custom/Complex type ===> Model Binding
        // Bind/testComplex/21?name=sd&managername=Ali
        public IActionResult testComplex(Department dept)
        {

            return Content("Masterpiece");
        }


        // Another Way to Bind a Model but that means I will get a specific .. 
        // attributes from clients if any thing was added regardless of ..
        // what demanded it will be ignored

        // Bind/testComplex2/1?name=Ammar&managername=Yasser
        public IActionResult testComplex2 (
            [Bind(include:"Id,Name")]Department dept)
        {

            return Content("Ok ");
        }
    }
}
