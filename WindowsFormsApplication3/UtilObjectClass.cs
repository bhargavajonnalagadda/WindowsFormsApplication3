using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication3
{
   public static class UtilObjectClass
    {
        public static List<Driver> drivercollection = new List<Driver>();
        public static Dictionary<Driver,List<Trip>> tripcollection = new Dictionary<Driver,List<Trip>>();

        public static long generateid()
        {
            var a = new System.Random(5).Next();
            return Convert.ToInt64(a.ToString());


        }

        public static Driver getdriver(string name)
        {

            // var driver = MakeaDatabaseCall(name);

            foreach (Driver driver in UtilObjectClass.drivercollection)
            {
                if (driver.Name.ToUpper().Equals(name.ToUpper()))
                {
                    return driver;
                    break;
                }
            }
            return null;
        }
    }
}
