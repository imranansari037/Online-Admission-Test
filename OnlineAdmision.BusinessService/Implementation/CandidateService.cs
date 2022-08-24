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
    public class CandidateService : ICandidateService
    {
        private OnlineDbContext context;
        public CandidateService()
        {
            context = new OnlineDbContext();
        }
        public void Add(Candidate candidate)
        {
            context.Candidates.Add(candidate);
            context.SaveChanges();
        }

        public int Delete(Candidate candidate)
        {
            candidate.isActive = false;
            candidate.DeletedBy = "System";
            candidate.DeletedOn = DateTime.Now;

            context.Entry(candidate).State = System.Data.Entity.EntityState.Modified;
            return context.SaveChanges();
        }

        public void DeleteAll()
        {
            var allActiveCandidates = context.Candidates.Where(x => x.isActive == true);

            foreach (Candidate candidate in allActiveCandidates)
            {
                Delete(candidate);
            }
            context.SaveChanges();
        }

        public IEnumerable<Candidate> GetAll()
        {
            return context.Candidates.Where(x => x.isActive == true);
        }

        public void Update(Candidate candidate)
        {
            candidate.UpdatedOn = DateTime.Now;
            candidate.UpdatedBy = "System";
            context.Entry(candidate).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();
        }
    }
}
