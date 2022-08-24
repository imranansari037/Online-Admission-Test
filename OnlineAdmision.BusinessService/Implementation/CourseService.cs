using OnlineAdmision.BusinessService.EF;
using OnlineAdmision.BusinessService.Interface;
using OnlineAdmision.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAdmision.BusinessService.Implementation
{
    public class CourseService : ICourseService
    {
        private OnlineDbContext context;
        public CourseService()
        {
            context=new OnlineDbContext();
        }
        public void Add(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
        }

        public int Delete(Course course)
        {
            course.isActive = false;
            course.DeletedBy = "System";
            course.DeletedOn = DateTime.Now;

            context.Entry(course).State = System.Data.Entity.EntityState.Modified;
            return context.SaveChanges();
        }

        public void DeleteAll()
        {
            var allActiveCourses = context.Courses.Where(x=>x.isActive==true);

            foreach(Course course in allActiveCourses)
            {
                Delete(course);
            }
            context.SaveChanges();
        }

        public IEnumerable<Course> GetAll()
        {
            return context.Courses.Where(x => x.isActive == true);
        }

        public void Update(Course course)
        {
            course.UpdatedOn = DateTime.Now;
            course.UpdatedBy = "System";
            context.Entry(course).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();
        }
    }
}
