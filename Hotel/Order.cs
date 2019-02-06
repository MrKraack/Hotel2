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
            rooms.Add(low);

            Room med = new Med("Medium budget room");
            med.Pris = 10000;
            rooms.Add(med);

            Room high = new High("High budget room");
            high.Pris = 100000;
            rooms.Add(high);

            return rooms;
        }
    }
}
