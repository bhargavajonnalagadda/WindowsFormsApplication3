using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication3
{
    interface ITrip
    {
        void CreateAndSaveTrip(Driver driver,TimeSpan start,TimeSpan end,double milesdriven);
        void UpdateTrip();
    }
}
