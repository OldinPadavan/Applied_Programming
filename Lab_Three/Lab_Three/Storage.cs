using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Three
{
    internal class Storage
    {
        private long Capacity;


        Storage()
        {
            Capacity = 100;
        }
        Storage(long Capacity)
        {
            this.Capacity = Capacity;
        }
    }
}
