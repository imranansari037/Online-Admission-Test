using OnlineAdmision.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAdmision.BusinessService.Interface
{
    public interface ICandidateService
    {
        void Add(Candidate candidate);

        void Update(Candidate candidate);

        int Delete(Candidate candidate);

        void DeleteAll();

        IEnumerable<Candidate> GetAll();
    }
}
