using System.Net;

namespace WebDav.NextGen.Exceptions
{
    public class DoesNotExists : WebDavException
    {
        public DoesNotExists(string message)
            : base(message, null)
        {
        }
    }
}