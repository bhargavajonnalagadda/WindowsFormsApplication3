using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication3
{
    public interface IPersistanceConfig
    {
        void GetConnection(string name);
    }
}
