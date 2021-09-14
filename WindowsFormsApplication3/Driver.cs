using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication3
{
    public class Driver : IDriver
    {
        private Int64 _id;
        private string name;

        public long Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = UtilObjectClass.generateid();
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Driver(Int64 id,string sname)
        {
            Id = id;
            Name = sname;
        }

        public Driver(string sname)
        {
            Id = UtilObjectClass.generateid();
            Name = sname;
        }

        public Driver()
        {

        }

        
       

        /// <summary>
        /// call to db to ensure if the driver is there in the store
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private object MakeaDatabaseCall(string name)
        {

            throw new NotImplementedException();
        }

        public void updateandsavedriver(string name)
        {
            //not implemented
        }

        public void createandsavedriver(string name,Driver d)
        {
           if(!UtilObjectClass.tripcollection.ContainsKey(d))
            {
                UtilObjectClass.tripcollection.Add(d, new List<Trip>());
            }

            UtilObjectClass.drivercollection.Add(d);
        }
        public void createandsavedriver(string name)
        {

            Driver d = UtilObjectClass.getdriver(name);
            createandsavedriver(name, d);


        }

        private long generateid()
        {
            var a = new System.Random(5);
            return Convert.ToInt64(a);
            

        }
    }
}
