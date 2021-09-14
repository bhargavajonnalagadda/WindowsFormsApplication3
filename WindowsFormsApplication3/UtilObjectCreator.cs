using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication3
{
    class UtilObjectCreator
    {
        private static void createDriverObject(string name)
        {
            Driver d = new Driver(name);
            d.createandsavedriver(d.Name,d);
        }

        private static void createTripObject(string[] values)
        {
            string name = values[1];
            Driver dr = UtilObjectClass.getdriver(name);
            string[] hourmin1 = getvalues(values[2], ':');
            string[] hourmin2 = getvalues(values[3], ':');

            TimeSpan ts1 = new TimeSpan(Convert.ToInt32(hourmin1[0]), Convert.ToInt32(hourmin1[1]), 0);
            TimeSpan ts2 = new TimeSpan(Convert.ToInt32(hourmin2[0]), Convert.ToInt32(hourmin2[1]), 0);
            double hours = ts2.Subtract(ts1).TotalHours;

            Trip t = new Trip(dr, ts1, ts2, Convert.ToDouble(values[4]));
            t.CreateAndSaveTrip(dr, ts1, ts2, Convert.ToDouble(values[4]),t);
        }

        public static void createObject(string[] commands)
        {
            foreach (string s in commands)
            {

                string[] properties = getvalues(s.TrimEnd(), ' ');

                int length = properties.Length;

                if (length > 0 && length < 3)
                {
                    //this is driver class
                    //Driver d = new Driver(properties[1]);
                    createDriverObject(properties[1].ToString());
                }
                else if (length > 2 && length < 6)
                {
                    //this is trip class

                    createTripObject(properties);
                }

            }

            


        }

        /// <summary>
        /// method to calculateandgeneratetripreport
        /// </summary>
        public static List<string> calculateandComputeTripReport()
        {
            DriverTripReportImplementation dtr = new DriverTripReportImplementation();
            return dtr.calculateAndSaveDriverTripResults();

        }
        public static string[] getvalues(string s,char splitchar)
        {
            string[] sarray = s.Split(splitchar);
            return sarray;
        }
    }
}
