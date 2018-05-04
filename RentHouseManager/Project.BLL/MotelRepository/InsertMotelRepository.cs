using RentHouseManager.Project.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentHouseManager.Project.BLL.MotelRepository
{
    public class MotelRepository
    {
        private RentHouseManagerEntities _context;
        public MotelRepository()
        {
            _context = new RentHouseManagerEntities();
        }

    }
}
