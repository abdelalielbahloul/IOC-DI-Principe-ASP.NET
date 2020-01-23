using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_DI_Principe.DAO
{
    class DaoIpml : IDao
    {
        public double getValue()
        {
            double data = 100;
            return data;
        }
    }
}
