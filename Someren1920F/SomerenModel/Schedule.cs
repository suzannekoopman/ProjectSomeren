using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Schedule
    {
        public int Activity { get; set; }
        public int SuperVisor { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
    }
}
