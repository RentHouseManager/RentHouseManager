using RentHouseManager.Project.Common.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentHouseManager.Project.DAL.Models
{
    public class Account
    {
        public string AccountId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public AccountType Type { get; set; }
    }
}
