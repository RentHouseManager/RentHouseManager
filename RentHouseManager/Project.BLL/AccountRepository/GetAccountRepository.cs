using RentHouseManager.Project.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentHouseManager.Project.BLL.AccountRepository
{
    public class GetAccountRepository
    {
        private RentHouseManagerEntities _context = new RentHouseManagerEntities();
        public List<ACCOUNT> GetAllAccount()
        {
            var accountList = new List<ACCOUNT>();
            accountList = _context.ACCOUNTs.ToList();
            if (accountList.Count > 0)
                return accountList;
            else return null;
        }
        public ACCOUNT GetAccountByName(string userName)
        {
            var result = _context.ACCOUNTs.FirstOrDefault(acc => acc.IDUSER == userName);
            return result;
        }
    }
}
