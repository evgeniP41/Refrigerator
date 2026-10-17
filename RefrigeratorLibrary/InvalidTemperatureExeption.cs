using System;
using System.Collections.Generic;
using System.Text;

namespace RefrigeratorLibrary
{
    public class InvalidTemperatureException : Exception
    {
        public double AttemptedTemperature { get; }

        public InvalidTemperatureException() { }
        public InvalidTemperatureException(string message) : base(message) { }
        public InvalidTemperatureException(string message, Exception inner) : base(message, inner) { }
        public InvalidTemperatureException(string message, double attemptedTemp) : base(message)
        {
            AttemptedTemperature = attemptedTemp;
        }
    }
}
