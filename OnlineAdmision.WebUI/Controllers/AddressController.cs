using OnlineAdmision.BusinessService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineAdmision.WebUI.Controllers
{
    public class AddressController : Controller
    {
        // GET: Address
        private IAddressService addressService;
        public AddressController(IAddressService addressService)
        {
            this.addressService = addressService;
        }
        public ActionResult Index()
        {
            return View(addressService.GetAll());
        }
        public ActionResult Create(IAddressService addressService)
        {
            
            return View(addressService);
        }
    }
}