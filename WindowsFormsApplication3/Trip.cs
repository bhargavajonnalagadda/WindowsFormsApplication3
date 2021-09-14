using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication3
{
    public class Trip:ITrip
    {
        private Driver tripDriver;
        private TimeSpan starttimeoftrip;
        private TimeSpan endtimeoftrip;
        private Int64 tripid;
        private bool tripinsametimezone;
        private double milesdriven;
        private double totalhoursfortrip;

        

        public Driver TripDriver
        {
            get
            {
                return tripDriver;
            }

            set
            {
                tripDriver = value;
            }
        }

        public TimeSpan Starttimeoftrip
        {
            get
            {
                return starttimeoftrip;
            }

            set
            {
                starttimeoftrip = value;
            }
        }

        public TimeSpan Endtimeoftrip
        {
            get
            {
                return endtimeoftrip;
            }

            set
            {
                endtimeoftrip = value;
            }
        }

        public long Tripid
        {
            get
            {
                return tripid;
            }

            set
            {
                tripid = value;
            }
        }

        public bool Tripinsametimezone
        {
            get
            {
                return tripinsametimezone;
            }

            set
            {
                tripinsametimezone = true;
            }
        }

        public double Milesdriven
        {
            get
            {
                return milesdriven;
            }

            set
            {
                milesdriven = value;
            }
        }

        public double Totalhoursfortrip
        {
            get
            {
                return totalhoursfortrip;
            }

            set
            {
                totalhoursfortrip = value;
            }
        }

        public Trip(Driver tdriver,TimeSpan stime,TimeSpan etime,Int64 id,bool sametimezone,Double miles)
        {
            TripDriver=tdriver ;
            Starttimeoftrip= stime;
            Endtimeoftrip =etime;
            Tripid=id;
            Tripinsametimezone=sametimezone;
            Milesdriven=miles;
            Totalhoursfortrip = Endtimeoftrip.Subtract(Starttimeoftrip).TotalHours;
        }
        public Trip(Driver tdriver,TimeSpan stime,TimeSpan etime,double miles)
        {
            TripDriver = tdriver;
            Starttimeoftrip=stime;
            Endtimeoftrip=etime;
            Milesdriven=miles;
            Tripid = UtilObjectClass.generateid();
            Tripinsametimezone = true;
            Totalhoursfortrip = Endtimeoftrip.Subtract(Starttimeoftrip).TotalHours;
        }
        public Trip()
        {

        }

        public void CreateAndSaveTrip(Driver driver,TimeSpan stime,TimeSpan etime,double miles,Trip _trip)
        {
            if (UtilObjectClass.tripcollection.Count > 0)
            {

               
                    if (UtilObjectClass.tripcollection.ContainsKey(driver))
                    {
                        var list = UtilObjectClass.tripcollection[driver];
                        list.Add(_trip);
                        
                    }
                    else
                    {
                        List<Trip> triplist = new List<Trip>();
                        triplist.Add(_trip);
                        UtilObjectClass.tripcollection.Add(driver, triplist);
                        
                    }
                
            }
            else
            {
                List<Trip> triplist = new List<Trip>();
                triplist.Add(_trip);
                UtilObjectClass.tripcollection.Add(driver, triplist);
            }
            

        }

        public void CreateAndSaveTrip(Driver driver,TimeSpan starttime,TimeSpan endtime,double milesdriven)
        {

            Trip _trip = new Trip(driver, starttime, endtime, milesdriven);

            CreateAndSaveTrip(driver, starttime, endtime, milesdriven, _trip);

            
        }

        public void UpdateTrip()
        {
            //not implemented
        }

    }
}

