using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EG_Simulator
{
    internal class VectorRotation
    {
        private float pitch;    // position along X axis
        private float yaw;    // position along Y axis
        private float roll;    // position along Z axis

        [JsonConstructor]
        public VectorRotation(int pitch, int yaw, int roll)
        {
            this.Pitch = pitch;
            this.Yaw = yaw;
            this.Roll = roll;
        }
        public VectorRotation()
        {
            this.Pitch = 0;
            this.Yaw = 0;
            this.Roll = 0;
        }
        public float Pitch
        {
            get { return pitch; }   // get method
            set { pitch = value; }  // set method
        }
        public float Yaw
        {
            get { return yaw; }   // get method
            set { yaw = value; }  // set method
        }
        public float Roll
        {
            get { return roll; }   // get method
            set { roll = value; }  // set method
        }
    }
}
