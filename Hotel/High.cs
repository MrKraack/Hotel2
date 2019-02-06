using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class High : Room
    {
        bool spa;
        bool roomService;
        bool perfumeSamples;
        bool robes;
        bool holograms;

        public High()
        {
            spa = true;
            roomService = true;
            perfumeSamples = true;
            robes = true;
            holograms = true;
        }


    }
}
