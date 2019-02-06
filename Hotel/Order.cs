using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{

    class Order
    {
        static public List<Room> RoomList()
        {
            List<Room> rooms = new List<Room>();

            Room low = new Low("Low budget room");
            low.Pris = 100;
            low.AntalSovePladser = 10;
            rooms.Add(low);

            Room med = new Med("Medium budget room");
            med.Pris = 10000;
            med.AntalSovePladser = 4;
            rooms.Add(med);

            Room high = new High("High budget room");
            high.Pris = 100000;
            high.AntalSovePladser = 2;
            rooms.Add(high);

            

            return rooms;
        }
    }
}
