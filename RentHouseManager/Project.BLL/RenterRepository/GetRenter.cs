using RentHouseManager.Project.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentHouseManager.Project.BLL.RenterRepository
{
    public class GetRenter
    {
        private RentHouseManagerEntities _context;
        public GetRenter()
        {
            _context = new RentHouseManagerEntities();
        }
        public List<NGTHUE> ListAllRenter()
        {
            var renterList = _context.NGTHUEs.ToList();
            if (renterList.Count > 0)
                return renterList;
            else return null;
        }
        public NGTHUE GetRenterByIdentity(string identityNum)
        {
            var searchRenter = _context.NGTHUEs.FirstOrDefault(renter => renter.CMND == identityNum);
            return searchRenter;
        }
    }
}
