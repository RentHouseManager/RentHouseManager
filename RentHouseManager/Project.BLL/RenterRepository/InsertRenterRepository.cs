﻿using RentHouseManager.Project.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentHouseManager.Project.BLL.RenterRepository
{
    public class InsertRenterRepository
    {
        private RentHouseManagerEntities _context = new RentHouseManagerEntities();
        public bool InsertNewRenter(NGTHUE newRenter)
        {
            bool result;
            var searchRenter = _context.NGTHUEs.FirstOrDefault(renter => renter.CMND == newRenter.CMND);
            if (searchRenter != null)
                result = false;
            else
            {
                try
                {
                    _context.NGTHUEs.Add(newRenter);
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
