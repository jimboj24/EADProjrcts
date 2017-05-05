using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ProStatClassLib
{
    public class Student : Person
    {
        private const int TYPE = 0; //Constant type student

        private DateTime enrolled;
        

        //Getters and Setters
        public DateTime Enrolled
        {
            get
            {
                return enrolled;
            }
            set
            {
                enrolled = value;
            }
        }
        public int Type
        {
            get
            {
                return TYPE;
            }
           

        }
    }

}