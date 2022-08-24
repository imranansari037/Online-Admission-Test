using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAdmision.Models
{
    public abstract class BaseModel
    {

        public BaseModel()
        {
                
        } 
        
        public int Id { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public string DeletedBy { get; set; }

        public DateTime? DeletedOn { get; set; }

        public bool isActive { get; set; }
    }
}
