using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePatterns.Builder
{
    class MotorCycle:VehicleBuilder
    {
        public MotorCycle()
        {
            NewVehicle = new Vehicle(VehicleType.MotorCycle);
        }
        public override void BuildDoor()
        {
            NewVehicle.Door = Door.Door_0;
        }
        public override void BuildWheel()
        {
            NewVehicle.Wheels = Wheels.Wheels_2;
        }
        public override void BuildEngine()
        {
            NewVehicle.Engine = Engine.MotorCycle_Engine_2000CC;
        }
        public override void BuildFrame()
        {
            NewVehicle.Frame = Frame.MotorCycle_Frame;
        }
    }
}
