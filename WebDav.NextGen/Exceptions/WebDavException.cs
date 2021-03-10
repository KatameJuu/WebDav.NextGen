using System;
using System.Net;

namespace WebDav.NextGen.Exceptions
{
    public class WebDavException : Exception
    {
        public HttpStatusCode? Code { get; }

        public WebDavException(string message, HttpStatusCode? code)
            : base(message)
        {
            Code = code;
        }

        public override string Message => $"{Code?.ToString() ?? "N/A"}: \"{base.Message}\"";
    }
}