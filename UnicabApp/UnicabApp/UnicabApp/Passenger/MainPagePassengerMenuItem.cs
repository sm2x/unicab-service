using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicabApp.Passenger
{

    public class MainPagePassengerMenuItem
    {
        public MainPagePassengerMenuItem()
        {
            TargetType = typeof(MainPagePassengerDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}