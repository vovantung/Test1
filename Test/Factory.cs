using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Factory
    {
        public Data data;
        public Data Init()
        {
           return data ?? (data = new Data());
        }
      
    }
}
