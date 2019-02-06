using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Low : Room
    {
        bool sharedToilet;
        bool bunkBeds;
        bool servesBreakfast;
        private string Name;


        public Low(string name)
        {
            sharedToilet = true;
            bunkBeds = true;
            servesBreakfast = false;
            this.Name = name;
        }
    }
}
