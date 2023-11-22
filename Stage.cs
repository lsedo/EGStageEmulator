using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EG_Simulator
{
    internal class Stage
    {
        private string? identifier;
        private string? next;
        private string? prev;

        private VectorPosition? position;
        private VectorRotation? rotation;
        private float? temperature;

        [JsonConstructor]
        public Stage(string identifier, string next, string prev, VectorPosition position, VectorRotation rotation, float temperature)
        {
            this.Identifier = identifier;
            this.Next = next;
            this.Prev = prev;
            this.Position = position;
            this.Rotation = rotation;
            this.Temperature = temperature; 
        }
        public Stage()
        {
            this.Identifier = null;
            this.Next = null;
            this.Prev = null;
            this.Position = null;
            this.Rotation = null;
            this.Temperature = null;
        }
        public string? Identifier
        {
            get { return identifier; }   // get method
            set { identifier = value; }  // set method
        }
        public string? Next
        {
            get { return next; }   // get method
            set { next = value; }  // set method
        }
        public string? Prev
        {
            get { return prev; }   // get method
            set { prev = value; }  // set method
        }
        public VectorPosition? Position
        {
            get { return position; }   // get method
            set { position = value; }  // set method
        }
        public VectorRotation? Rotation
        {
            get { return rotation; }   // get method
            set { rotation = value; }  // set method
        }
        public float? Temperature
        {
            get { return temperature; }   // get method
            set { temperature = value; }  // set method
        }
        
    }
}
