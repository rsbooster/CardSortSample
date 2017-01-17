using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardSortSample
{
    public class SequenceInconsistentException : ApplicationException
    {
        public SequenceInconsistentException(string message) : base(message)
        {
        }
    }
}
