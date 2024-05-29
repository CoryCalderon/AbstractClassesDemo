using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Driving abstractly...");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Driving virtually...");
        }
    }
}
