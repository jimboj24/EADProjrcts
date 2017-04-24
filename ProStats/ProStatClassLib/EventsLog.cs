using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProStatClassLib
{
    public static class EventsLog
    {
        static private  int userId;
        static private  string type;
        static private string timeIn;
        static private string timeOut;


        static EventsLog()
        {
            userId = 1234556;
            type = "Student";
            timeIn = "01/08/2016 14:50:50.42";
            timeOut = "01/08/2016 15:50:50.42";
        }
       

        
        public static int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public static string Type
        {
            get { return type; }
            set { type = value; }
        }
        public static string TimeIn
        {
            get { return timeIn; }
            set { timeIn = value; }
        }
        public static string TimeOut
        {
            get { return timeOut; }
            set { timeOut = value; }
        }

    }
}
