using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Patterns.Prototype.Interfaces;

namespace Patterns.Prototype.Implementations
{
    [Serializable]
    public class Circle : IPrototype
    {
        public Point Point { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public IPrototype Clone()
        {
            return (IPrototype)this.MemberwiseClone();
        }

        public IPrototype DeepClone()
        {
            object figure = null;
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter(null,new StreamingContext(StreamingContextStates.Clone));
                binaryFormatter.Serialize(stream,this);
                stream.Seek(0, SeekOrigin.Begin);
                figure = binaryFormatter.Deserialize(stream);

            }

            return (IPrototype) figure;

        }
    }
}
