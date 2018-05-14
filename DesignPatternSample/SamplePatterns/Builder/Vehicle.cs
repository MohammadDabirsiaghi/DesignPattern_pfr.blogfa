using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePatterns.Builder
{
    class Vehicle
    {
        public VehicleType VehicleType;
        public Frame Frame;
        public Door Door;
        public Engine Engine;
        public Wheels Wheels;
        public Vehicle(VehicleType vType)
        {
            VehicleType = vType;

        }

    }
}
