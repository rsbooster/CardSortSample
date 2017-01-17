using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardSortSample
{
    public static class Sorter
    {
        public static IEnumerable<Card> Sort(IEnumerable<Card> cardList)
        {
            if (!cardList.Any())
                return Enumerable.Empty<Card>();

            var unsortedList = cardList.ToList();
            var sortedList = new List<Card>(unsortedList.Count);

            string start = null;
            string end = null;

            var firstCard = unsortedList.First();
            unsortedList.Remove(firstCard);
            sortedList.Add(firstCard);

            while (unsortedList.Count > 0)
            {
                var startUnsortedCount = unsortedList.Count;

                start = sortedList[0].Departure;
                end = sortedList[sortedList.Count-1].Destination;

                foreach (var card in unsortedList)
                {
                    if (card.Destination == start)
                    {
                        unsortedList.Remove(card);
                        sortedList.Insert(0, card);
                        start = card.Departure;
                        break;
                    }
                    if (card.Departure == end)
                    {
                        unsortedList.Remove(card);
                        sortedList.Add(card);
                        end = card.Destination;
                        break;
                    }
                }

                if (unsortedList.Count == startUnsortedCount)
                    throw new SequenceInconsistentException("Card sequence is inconsistent");
            }

            return sortedList;
        }
    }
}
