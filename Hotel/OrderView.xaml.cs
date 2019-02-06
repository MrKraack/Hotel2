using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hotel
{
    /// <summary>
    /// Interaction logic for OrderView.xaml
    /// </summary>
    public partial class OrderView : Window
    {
        public OrderView()
        {
            InitializeComponent();
            List<Room> rooms = Order.RoomList();
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

            HotelList.ItemsSource = rooms;

        }
    }
}
