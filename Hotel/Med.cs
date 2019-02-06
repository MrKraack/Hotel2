using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Med : Room
    {
        bool childrensBed;
        bool television;
        bool freeSoap;

        public Med()
        {
            childrensBed = true;
            television = true;
            freeSoap = true;
        }
    }
    
}
