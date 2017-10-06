using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{//Klassen ärver Exception klassens funktioner.
    class AgeException : Exception
    {
        public AgeException()
        {
        }
        //detta är konstruktorn som kommer användas i detta program. Stringen som sätts som argument i parametern matas ut som meddelande i tillhörande catch metod.
        public AgeException(string message) : base(message)
        {
        }

        public AgeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AgeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
