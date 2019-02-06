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
        private string Name;

        public High(string name)
        {
            spa = true;
            roomService = true;
            perfumeSamples = true;
            robes = true;
            holograms = true;
            this.Name = name;
        }


    }
}
