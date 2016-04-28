using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    public interface ISeat
    {

        float CalculatePrice(FlightSchedule fs);
    }

}
