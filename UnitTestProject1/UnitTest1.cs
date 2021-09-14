using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication3;
using System.Text;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            string name = "Jon";
            Driver d = new Driver("Jon");
            
            
            Assert.IsNotNull(d);
            Assert.IsNotNull(UtilObjectClass.drivercollection);

        }

        [TestMethod]
        public void TestMethod2()
        {
            
            string name = "Jon";
            TimeSpan ts1 = new TimeSpan(12, 10, 10);
            TimeSpan ts2 = new TimeSpan(12, 12, 0);
            double hours = ts2.Subtract(ts1).TotalHours;
            double miles = 10.5;
            int speed = Convert.ToInt32(miles / hours);

            StringBuilder sb = new StringBuilder();
            sb.Append("Jon");
            sb.Append(": ");
            sb.Append(miles);
            sb.Append(" miles @");
            sb.Append(speed);
            sb.Append(" mph");


            
            Driver d = new Driver(name);
            d.createandsavedriver(name,d);

            
            Assert.IsNotNull(d);
            Assert.IsNotNull(UtilObjectClass.drivercollection);

            
            Trip tr = new Trip(d, ts1, ts2, miles);
            tr.CreateAndSaveTrip(d, ts1, ts2, miles, tr);
            DriverTripReportImplementation dtr = new DriverTripReportImplementation();
            List<string> list = dtr.calculateAndSaveDriverTripResults();
            StringBuilder sb2 = new StringBuilder();
            foreach (string s in list)
            {
                sb2.Append(s);
                sb2.Append(Environment.NewLine);


            }


            //assert
            Assert.AreNotEqual(sb.ToString(), sb2.ToString());



        }
    }
}
