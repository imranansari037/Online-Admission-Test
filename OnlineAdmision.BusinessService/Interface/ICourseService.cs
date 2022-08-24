using OnlineAdmision.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAdmision.BusinessService.Interface
{
    public interface ICourseService
    {
        void Add(Course course);

        void Update(Course course);

        int Delete(Course course);

        void DeleteAll();

        IEnumerable<Course> GetAll();
    }
}
