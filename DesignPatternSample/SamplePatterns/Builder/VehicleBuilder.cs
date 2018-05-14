using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePatterns.Builder
{
   abstract class VehicleBuilder
    {
        protected Vehicle NewVehicle;
        public Vehicle GetVehicle()
        {
            return NewVehicle;
        }
        public abstract void BuildFrame();
        public abstract void BuildDoor();
        public abstract void BuildEngine();
        public abstract void BuildWheel();

    }
}
