using System.Net;

namespace WebDav.NextGen.Exceptions
{
    public class AccessDenied : WebDavException
    {
        public AccessDenied(string message)
            : base(message, null)
        {
        }
    }
}