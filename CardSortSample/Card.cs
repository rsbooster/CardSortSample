using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardSortSample
{
    public class Card
    {
        public string Departure { get; private set; }
        public string Destination { get; private set; }

        public Card(string departure, string destination)
        {
            Departure = departure;
            Destination = destination;
        }
    }
}
