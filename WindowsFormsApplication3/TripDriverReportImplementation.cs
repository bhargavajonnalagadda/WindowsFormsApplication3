using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication3
{
   public class DriverTripReportImplementation :IDriverTripReport
    {
        
        private List<string> _tripdetails;

        public List<string> Tripdetails
        {
            get
            {
                return _tripdetails;
            }

            set
            {
                _tripdetails = calculateAndSaveDriverTripResults();
            }
        }

        

        
        


       public DriverTripReportImplementation(List<string> details)
        {
            
            details = _tripdetails;
        }
        public DriverTripReportImplementation()
        {

        }

        public List<string> calculateAndSaveDriverTripResults()
        {
            List<String> report = new List<string>();
            foreach (KeyValuePair<Driver, List<Trip>> kvp in UtilObjectClass.tripcollection)
            {
                Driver d = kvp.Key;
                List<Trip> tlist = kvp.Value;
                double totaltripmiles = 0;
                int avgtripspeed = 0;
                double totaltime = 0;
                foreach (Trip t in tlist)
                {
                    if (t.Milesdriven > 0 && t.Totalhoursfortrip > 0)
                    {
                        int tspeed = Convert.ToInt32(t.Milesdriven / t.Totalhoursfortrip);
                        if (tspeed > 5 || tspeed < 100)
                        {
                            totaltripmiles += Convert.ToDouble(t.Milesdriven);
                            totaltime += t.Totalhoursfortrip;


                        }
                    }
                }

                if (totaltime > 0 && totaltripmiles > 0)
                {
                    avgtripspeed = Convert.ToInt32(totaltripmiles / totaltime);
                }

                StringBuilder sb = new StringBuilder();
                sb.Append(d.Name);
                sb.Append(": ");
                sb.Append(totaltripmiles);
                sb.Append(" miles @");
                sb.Append(avgtripspeed);
                sb.Append(" mph");


                report.Add(sb.ToString());
            }
            return report;

        }
    
        

        private string CalculateTotalMIlesandSpeed(List<Trip> tlist,Driver driver)
        {
            List<double> slist = new List<double>();
            List<double> mlist = new List<double>();
            foreach (Trip t in tlist)
            {
                
                TimeSpan _ts = t.Endtimeoftrip.Subtract(t.Starttimeoftrip);
                double speed = 0;
                if (t.Milesdriven > 0 && _ts.TotalHours > 0)
                {
                    speed = t.Milesdriven / (_ts.TotalHours);
                slist.Add(speed);
                    mlist.Add(t.Milesdriven);
                }


            }

            int capacity = slist.Count;
            int avgspeed = 0;
            int total = 0;

            foreach(double d in slist)
            {
                total += Convert.ToInt32(d);
                
            }

            avgspeed = total / capacity;

            total = 0;

            foreach(double d in mlist)
            {
                total += Convert.ToInt32(d);
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(driver.Name);
            sb.Append(": ");
            sb.Append(total);
            sb.Append(" miles @ ");
            sb.Append(avgspeed);
            sb.Append(" mph");
            string temp = sb.ToString();
            return temp;
            
        }
    }
}
