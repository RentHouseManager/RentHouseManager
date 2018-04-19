using RentHouseManager.Project.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentHouseManager.Project.BLL
{
    public class AccountService
    {
        private RentHouseManagerEntities context;

        public AccountService()
        {
            context = new RentHouseManagerEntities();
        }

        public List<ACCOUNT> GetAllAccount()
        {
            List<ACCOUNT> result = new List<ACCOUNT>();
            var accounts = from account in context.ACCOUNTs
                           orderby account.PRIVILIGES
                           select account;
            result = accounts.ToList();
            return result;
        }

        public ACCOUNT GetAccount(string userName)
        {
            ACCOUNT result = new ACCOUNT();
            var account = (from acc in context.ACCOUNTs
                          where acc.IDUSER == userName
                          select acc)
                          .ToList();
            if (account.Count <= 0)
                result = null;
            else result = account[0];
            return result;
        }
    }
}
