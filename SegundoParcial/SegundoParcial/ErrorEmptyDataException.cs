using System;

namespace SegundoParcial
{
    public class ErrorEmptyDataException : Exception
    {
        public ErrorEmptyDataException(string message) : base(message)
        {
        }
    }
}