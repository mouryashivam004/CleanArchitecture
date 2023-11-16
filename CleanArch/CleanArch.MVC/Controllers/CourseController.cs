using CleanArch.Application.Interfaces;
using CleanArch.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.MVC.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;     
        }
        public async Task< IActionResult> Index()
        {
            return View(await _courseService.GetCourse()) ;
        }
    }
}
