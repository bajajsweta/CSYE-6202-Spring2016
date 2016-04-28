using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    public class Price
    {
        int PriceID { get; set; }
        int FlightID { get; set; }
        int FlightScheduleID { get; set; }
        int SeatID { get; set; }
        float Cost { get; set; }


        public Price construct(List<object> list)
        {
            Price price = new Price();
            price.PriceID = (int)list[0];
            price.FlightID = (int)list[1];
            price.FlightScheduleID = (int)list[2];
            price.SeatID = (int)list[3];
            price.Cost = (float)list[4];
            return price;
        }

    }
}
