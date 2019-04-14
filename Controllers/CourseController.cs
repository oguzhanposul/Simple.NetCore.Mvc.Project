using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MiniProjectCourseApp2.Models;

namespace MiniProjectCourseApp2.Controllers
{
    //localhost:5000/course
    public class CourseController:Controller
    {
        //localhost:5000/course/Index
        public IActionResult Index(){
            return View();
        }

        [HttpGet]
        public IActionResult Apply()
        {
          return View();
        }

        [HttpPost]
        public IActionResult Apply(Student student)
        {
          if(ModelState.IsValid){
            Repository.AddStudent(student); 
            return View("Thanks",student);
          }else
          {
              return View(student);
          }
        
        }

        public IActionResult Details(){

            var course = new Course(){
                Name="Asp.Net Core 2.2",
                Description="Çok iyi bir kurs",
                isPublished=true
            };
            
            return View(course);
        }

        //localhost:5000/course/List
        public IActionResult List(){
            
            var studentsConfirmed = Repository.Students.Where(i=>i.Confirm==true);

            return View(studentsConfirmed);
        }




    }
}