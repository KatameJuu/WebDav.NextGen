using System.Net;

namespace WebDav.NextGen.Exceptions
{
    public class InsufficientSpace : WebDavException
    {
        public InsufficientSpace(string message)
            : base(message, null)
        {
        }
    }
}