using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_nich2072.Objects
{
    sealed public class Moon : Planet
    {
        public Planet Orbiting { get; set; }
        public double Distance()
        {
            return Math.Sqrt((Math.Pow(position.x - Orbiting.position.x, 2) +
                              Math.Pow(position.y - Orbiting.position.y, 2)));
        }
    }
}
