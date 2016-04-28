using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    public class EconomySeat  : Seat
    {
        public string SeatType {get { return "Economy"; } }

        public override float GetPriceFactor()
        {
            return 300.0f;
        }
    }
}
