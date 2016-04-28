using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    public class BusinessSeat : Seat
    {

        public string SeatType { get { return "Business"; } }


        public override float GetPriceFactor()
        {
            return 600.0f;
        }
    }
}
