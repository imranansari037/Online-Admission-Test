using OnlineAdmision.BusinessService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineAdmision.WebUI.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course

        private ICourseService courseService;

        public CourseController(ICourseService courseService1)
        {
            this.courseService = courseService1;
        }
        public ActionResult Index()
        {
            return View(courseService.GetAll());
        }
    }
}