using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentHouseManager.Project.DAL.Models
{
    public class UserInfo
    {
        [Key]
        public string UserId { get; set; }
        public string AccountId { get; set; }
        public string FullName { get; set; }

        [ForeignKey("AccountId")]
        public Account Account { get; set; }
    }
}
