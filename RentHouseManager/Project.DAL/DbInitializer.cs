using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentHouseManager.Project.DAL
{
    public class DbInitializer
    {
        public static void Initialize(DBContext context)
        {
            context.Database.CreateIfNotExists();
        }
    }
}
