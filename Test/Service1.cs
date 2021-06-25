using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Service1
    {
        Factory _factory;
        Data data;
        Data Data
        {
            get { return data ?? (data = _factory.Init()); }
        }
        public Service1(Factory factory)
        {
            _factory = factory;
            Data.str ="";
        }
        public void Action()
        {
            Data.str = "Service 1";
        }
       
    }
}
