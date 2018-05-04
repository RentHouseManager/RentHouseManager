using RentHouseManager.Project.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentHouseManager.Project.BLL.AccountRepository
{
    public class SaveAccountRepository
    {
        private RentHouseManagerEntities _context;

        public SaveAccountRepository()
        {
            _context = new RentHouseManagerEntities();
        }

        public bool SaveAccount(ACCOUNT newAccount)
        {
            bool result;
            var searchAccount = _context.ACCOUNTs.FirstOrDefault(acc => acc.IDUSER == newAccount.IDUSER);
            if (searchAccount == null)
            {
                try
                {
                    _context.ACCOUNTs.Add(newAccount);
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
            {
                result = false;
            }
            return result;
        }
    }
}
