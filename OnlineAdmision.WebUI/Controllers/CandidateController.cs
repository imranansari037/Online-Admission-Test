using OnlineAdmision.BusinessService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineAdmision.WebUI.Controllers
{
    public class CandidateController : Controller
    {
        private ICandidateService candidateService;
        // GET: Candidate
        public CandidateController(ICandidateService candidateService)
        {
            this.candidateService = candidateService;
        }
        public ActionResult Index()
        {
            return View(candidateService.GetAll());
        }
    }
}