using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePatterns.Builder
{
    class Shop
    {
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildDoor();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildWheel();
        }
    }
}
