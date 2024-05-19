using System;
using System.Net;
using System.Runtime.Serialization;

namespace PixDotNet.Requests
{
    [Serializable]
    internal class PixRequestException : Exception
    {
        private string _v;
        private HttpStatusCode _statusCode;

        public PixRequestException()
        {
        }

        public PixRequestException(string message) : base(message)
        {
        }

        public PixRequestException(string v, HttpStatusCode statusCode)
        {
            _v = v;
            _statusCode = statusCode;
        }

        public PixRequestException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PixRequestException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}