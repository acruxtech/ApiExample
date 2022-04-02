using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExample.Shared.Exceptions
{
    public class NotFound : Exception
    {
        public NotFound(string message) : base(message)
        {
        }
    }
}
