using System;
using System.Runtime.Serialization;

namespace Doppler.Core.Exceptions
{
    [Serializable]
    public class DopplerConfigException : Exception
    {
        public DopplerConfigException()
        {
        }

        public DopplerConfigException(string message)
            : base(message)
        {
        }

        public DopplerConfigException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected DopplerConfigException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
