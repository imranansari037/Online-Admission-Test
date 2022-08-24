using OnlineAdmision.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAdmision.BusinessService.Interface
{
    public interface IAddressService
    {
        void Add(Address address);

        void Update(Address address);

        int Delete(Address address);

        void DeleteAll();

        IEnumerable<Address> GetAll();
    }
}
