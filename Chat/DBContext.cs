using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public class DBContext : DbContext
    {
        protected DBContext():base("DbConnectionString")
        {

        }
    }
}
