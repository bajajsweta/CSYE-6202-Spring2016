using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    public abstract class Seat : ISeat
    {
        int ID { get; set; }

        public float CalculatePrice(FlightSchedule fs)
        {
            return this.GetPriceFactor() * fs.FlightDuration;
        }

        public abstract float GetPriceFactor();

    }
}
