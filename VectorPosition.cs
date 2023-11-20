using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EG_Simulator
{

    // 3D position vector; 
    internal class VectorPosition
    {
        public float X { get; set; }    // position along X axis
        public float Y { get; set; }    // position along Y axis
        public float Z { get; set; }    // position along Z axis

        public VectorPosition(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
