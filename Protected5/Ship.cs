using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected5
{
    public class Ship
    {
        public string Name { get; set; }
        public string Destination { get; set; }
        public double Deadweight { get; set; }
        public double EnginePower { get; set; }
        public string FuelType { get; set; }
    }

    public class AircraftCarrier : Ship
    {
        public int AmountOfAircrafts { get; set; }
        public string TypeOfAircrafts { get; set; }
    }

    public class WeaponCarrier : Ship
    {
        public int AmountOfRockets { get; set; }
        public string TypeOfRockets { get; set; }
    }
}
