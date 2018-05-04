using RentHouseManager.Project.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentHouseManager.Project.BLL.RenterRepository
{
    public class UpdateRenter
    {
        private RentHouseManagerEntities _context;

        public UpdateRenter()
        {
            _context = new RentHouseManagerEntities();
        }

        public bool UpdateRenterByIdentity(NGTHUE updateInfo)
        {
            bool result;
            var searchRenter = _context.NGTHUEs.FirstOrDefault(renter => renter.CMND == updateInfo.CMND);
            if (searchRenter == null)
            {
                try
                {
                    searchRenter = updateInfo;
                    _context.SaveChanges();
                    result = true;
                }
                catch (Exception e)
                {
                    result = false;
                    throw e;
                }
            }
            else result = false;

            return result;
        }
    }
}
