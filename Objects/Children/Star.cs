using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_nich2072.Objects
{
    public enum StarType { YellowDwarf, White, BlueNeutron, RedGiant };
    public class Star : SpaceObjects
    {
        public StarType Type { get; set; }
        public float Temperature { get; set; }
        public List<Planet> Planets{ get; set; }
        public override Position position
        {
            get { return new Position() { x = 0, y = 0 }; }
        }
    }
}
