using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EG_Simulator
{
    internal class VectorRotation
    {
        public float Pitch { get; set; } // Rotation around the X-axis
        public float Yaw { get; set; }   // Rotation around the Y-axis
        public float Roll { get; set; }  // Rotation around the Z-axis

        public VectorRotation(int pitch, int yaw, int roll)
        {
            this.Pitch = pitch;
            this.Yaw = yaw;
            this.Roll = roll;
        }

    }
}
