using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication3
{
    class DataFactory :IPersistanceConfig
    {
        private string connectionstring;

        public DataFactory(string name)
        {
            name = connectionstring;
        }

        public void MakeConnection(string name)
        {
            //open sql connection 
        }
    }
}
