using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAdmision.Models
{
    public class Course : BaseModel
    {
        public string Name { get; set; }

        public decimal Fees { get; set; }

        public int Duration { get; set; }

        public ICollection<Candidate> Candidates { get; set; }
    }
}