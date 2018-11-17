using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_training.Exceptions
{
    [Serializable]
    public class TeamException : Exception
    {
        public TeamException() { }
        public TeamException(string message) : base(message) {
        }
        public TeamException(string message, Exception inner) : base(message, inner) { }
        protected TeamException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
