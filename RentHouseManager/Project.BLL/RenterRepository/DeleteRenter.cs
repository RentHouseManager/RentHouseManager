using RentHouseManager.Project.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentHouseManager.Project.BLL.RenterRepository
{
    public class DeleteRenter
    {
        private RentHouseManagerEntities _context;
        public DeleteRenter()
        {
            _context = new RentHouseManagerEntities();
        }

        public bool DeleteRenterByIdentity(string identity)
        {
            bool result;
            var searchRenter = _context.NGTHUEs.FirstOrDefault(renter => renter.CMND == identity);
            if (searchRenter == null)
                result = false;
            else
            {
                try
                {
                    _context.NGTHUEs.Remove(searchRenter);
                    _context.SaveChanges();
                    result = true;
                }
                catch (Exception e)
                {
                    result = false;
                    throw e;
                }
            }
            return result;
        }
    }
}
