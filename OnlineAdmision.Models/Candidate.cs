using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAdmision.Models
{
    public class Candidate : BaseModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfAdmission { get; set; }

        public ICollection<Address> Address { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}