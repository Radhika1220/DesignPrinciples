using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples
{
    //Declaring getter and setter methods
    public class ScheduleTask
    {
        public int TaskId { get; set; }
        public string Content { get; set; }
        public DateTime ExecuteOn { get; set; }
    }
}

