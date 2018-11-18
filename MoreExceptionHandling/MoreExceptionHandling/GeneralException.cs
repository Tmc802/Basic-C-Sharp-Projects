using System;
namespace MoreExceptionHandling
{
    public class GeneralException : Exception
    {
        public GeneralException()
            : base() { }
        public GeneralException(string message)
            : base(message) { }
       
    }
}
