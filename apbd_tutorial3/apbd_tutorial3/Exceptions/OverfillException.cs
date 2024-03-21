using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apbd_tutorial3.Exceptions
{
    internal class OverfillException: Exception
    {
        public OverfillException(Container container) { }

        public OverfillException(string? message) : base(message)
        {
        }

        public OverfillException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
