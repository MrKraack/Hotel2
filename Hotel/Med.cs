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
        private string Name;

        public Med(string name)
        {
            childrensBed = true;
            television = true;
            freeSoap = true;
            this.Name = name;
        }
    }
    
}
