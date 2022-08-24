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
    public class AddressService : IAddressService
    {
        private OnlineDbContext context;
        public AddressService()
        {
            context = new OnlineDbContext();
        }
        public void Add(Address address)
        {
            context.Addresses.Add(address);
            context.SaveChanges();
        }

        public int Delete(Address address)
        {
            address.isActive = false;
            address.DeletedBy = "System";
            address.DeletedOn = DateTime.Now;

            context.Entry(address).State = System.Data.Entity.EntityState.Modified;
            return context.SaveChanges();
        }

        public void DeleteAll()
        {
            var allActiveAddresss = context.Addresses.Where(x => x.isActive == true);

            foreach (Address address in allActiveAddresss)
            {
                Delete(address);
            }
            context.SaveChanges();
        }

        public IEnumerable<Address> GetAll()
        {
            return context.Addresses.Where(x => x.isActive == true);
        }

        public void Update(Address address)
        {
            address.UpdatedOn = DateTime.Now;
            address.UpdatedBy = "System";
            context.Entry(address).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();
        }
    }
}
