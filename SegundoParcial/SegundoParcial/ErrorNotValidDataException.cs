using System;

namespace SegundoParcial
{
    public class ErrorNotValidDataException : Exception
    {
        public ErrorNotValidDataException(string message) : base(message)
        {
        }
    }
}