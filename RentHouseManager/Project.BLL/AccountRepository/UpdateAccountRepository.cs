using RentHouseManager.Project.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentHouseManager.Project.BLL.AccountRepository
{
    public class UpdateAccountRepository
    {
        private RentHouseManagerEntities _context;
        public UpdateAccountRepository()
        {
            _context = new RentHouseManagerEntities();
        }
        public bool UpdateAccountByName(ACCOUNT newAccount)
        {
            bool result;
            var searchAccount = _context.ACCOUNTs.FirstOrDefault(acc => acc.IDUSER == newAccount.IDUSER);
            if (searchAccount == null)
            {
                result = false;
            }
            else
            {
                try
                {
                    searchAccount = newAccount;
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
