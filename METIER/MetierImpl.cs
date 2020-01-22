using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_DI_Principe
{
    class MetierImpl : IMetier
    {
        public IDao dao { get; set; }
        public MetierImpl()
        {

        }
        public MetierImpl(IDao dao)
        {
            this.dao = dao;
        }
        public double calcul() 
        {
            double value = dao.getValue();
            return value * 9;
        }
    }
}
