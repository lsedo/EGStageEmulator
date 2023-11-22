using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EG_Simulator
{

    // 3D position vector; 
    internal class VectorPosition
    {
        private float x;    // position along X axis
        private float y;    // position along Y axis
        private float z;    // position along Z axis

        [JsonConstructor]
        public VectorPosition(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public VectorPosition()
        {
            this.X = -1;
            this.Y = -1;
            this.Z = -1;
        }
        public float X
        {
            get { return x; }   // get method
            set { x = value; }  // set method
        }
        public float Y
        {
            get { return y; }   // get method
            set { y = value; }  // set method
        }
        public float Z
        {
            get { return z; }   // get method
            set { z = value; }  // set method
        }
    }
}
