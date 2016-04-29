using System;
using System.Diagnostics;
using Google.GData.Calendar;
using Google.GData.Client;
using Google.GData.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final_Project.DAO
{
   public class GoogleCalendarUtils
    {

        //try creating calendar updates in gmail....
        private static Uri calendarUri = new Uri("https://www.google.com/calendar/feeds/calendar@thistlesociety.org.uk/private/full");
        private static string appName = "ThistleSoc-EventManager-0.0.1";
        private static string userName = "calendar@thistlesociety.org.uk ";
        private static string password = "password";
    }
}
