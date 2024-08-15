using System;

namespace CarFactory
{
    // Custom exception class
    public class InvalidDoorCountException : Exception
    {

        public InvalidDoorCountException(string message)
            : base(message)
        {
        }

    }
}
