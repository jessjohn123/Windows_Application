using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5_Exceptions
{
    [Serializable]
    public class NaughtyWordException : Exception
    {
        public NaughtyWordException() { }
        public NaughtyWordException(string message) : base(message) { }
        public NaughtyWordException(string message, Exception inner) : base(message, inner) { }
        protected NaughtyWordException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    public class Sentence
    {
        string text;

        public string Text
        {
            get { return text; }
            set 
            {
                if (value.Contains("pee")) throw new NaughtyWordException("Pee is a naughty word!");

                text = value; 
            }
        }

        public override string ToString()
        {
            return text;
        }
    }
}
