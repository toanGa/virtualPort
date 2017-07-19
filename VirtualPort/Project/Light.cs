using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace VirtualPort.Project
{
    class Light:Device1
    {
        public Light()
        {
            name = "Đèn điện";
            power = (float)0.025;
        }
    }
}
