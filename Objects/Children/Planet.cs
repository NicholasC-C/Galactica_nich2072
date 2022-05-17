using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_nich2072.Objects
{
    public enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant}
    public class Planet : SpaceObjects
    {
        public PlanetType Type { get; set; }
        public float Diameter { get; set; }
        public int RotationPeriod{ get; set; } // Hours
        public int RevolutionPeriod { get; set; } // Days
        public List<Moon> Moons { get; set; }
        public double Distance(Star star)
        {
            return Math.Sqrt((Math.Pow(position.x - star.position.x, 2) + 
                              Math.Pow(position.y - star.position.y, 2)));
        }
    }
}
