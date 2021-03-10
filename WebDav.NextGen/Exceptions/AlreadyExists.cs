using System.Net;

namespace WebDav.NextGen.Exceptions
{
    public class AlreadyExists : WebDavException
    {
        public AlreadyExists(string message)
            : base(message, null)
        {
        }
    }
}