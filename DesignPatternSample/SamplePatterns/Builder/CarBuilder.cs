using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePatterns.Builder
{
    class CarBuilder:VehicleBuilder
    {
        public CarBuilder()
        {
            NewVehicle = new Vehicle(VehicleType.Car);

        }
        public override void BuildDoor()
        {
            NewVehicle.Door = Door.Door_4;
        }
        public override void BuildWheel()
        {
            NewVehicle.Wheels = Wheels.Wheels_4;
        }
        public override void BuildEngine()
        {
            NewVehicle.Engine = Engine.Car_Engine_5000CC;
        }
        public override void BuildFrame()
        {
            NewVehicle.Frame = Frame.Car_Frame;
        }
    }
}
