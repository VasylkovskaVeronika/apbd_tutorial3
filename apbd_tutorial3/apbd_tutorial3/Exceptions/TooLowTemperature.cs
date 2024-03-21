using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apbd_tutorial3.Exceptions
{
    class TooLowTemperature: Exception
    {
        public TooLowTemperature()
        { 
            
        }

        public TooLowTemperature(string? message) : base(message)
        {
        }

        public TooLowTemperature(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
