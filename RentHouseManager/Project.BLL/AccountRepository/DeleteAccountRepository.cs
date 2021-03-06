﻿using RentHouseManager.Project.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentHouseManager.Project.BLL.AccountRepository
{
    public class DeleteAccountRepository
    {
        private RentHouseManagerEntities _context = new RentHouseManagerEntities();
        public bool DeleteAccountByName(string userName)
        {
            bool result;
            var searchUser = _context.ACCOUNTs.FirstOrDefault(acc => acc.IDUSER == userName);
            if (searchUser != null)
            {
                try
                {
                    _context.ACCOUNTs.Remove(searchUser);
                    _context.SaveChanges();
                    result = true;
                }
                catch (Exception e)
                {
                    result = false;
                    throw e;
                }
            }
            else
                result = false;
            return result;
        }
    }
}
