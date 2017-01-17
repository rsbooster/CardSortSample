using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardSortSample.Tests
{
    [TestClass]
    public class SorterTests
    {
        [TestMethod]
        public void Sorter_Normally_Sorts()
        {
            var firstCard = new Card("1", "2");
            var secondCard = new Card("2", "3");
            var thirdCard = new Card("3", "4");

            var sortedList = new[]
            {
                firstCard,
                secondCard,
                thirdCard,
            };

            var unsortedList = new[]
            {
                thirdCard,
                secondCard,
                firstCard
            };

            var sortResult = Sorter.Sort(unsortedList);

            Assert.IsTrue(sortResult.SequenceEqual(sortedList));
        }

        [TestMethod]
        [ExpectedException(typeof(SequenceInconsistentException))]
        public void Sorter_InconsistentSequence_Throws()
        {
            var firstCard = new Card("1", "2");
            var thirdCard = new Card("3", "4");

            var unsortedList = new[]
            {
                thirdCard,
                firstCard
            };

            var sortResult = Sorter.Sort(unsortedList);
        }
    }
}
