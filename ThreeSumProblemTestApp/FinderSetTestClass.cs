using System;
using System.Collections.Generic;
using System.Linq;
using ThreeSumProblem;
using Xunit;

namespace ThreeSumProblemTestApp
{
    public class FinderSetTestClass
    {
        [Fact]
        public void GetListOfSetThreeDuplicateNumbersWithDistinct()
        {
            FinderSet set = new FinderSet(new List<int> { 0, 0, 0, 0, 0 -1, 1, 5, 8, 10, 11, -11 });
            var result = set.GetListOfSetThree();
            Assert.Equal(4, result.Count());
        }

        [Fact]
        public void GetListOfSetThreeEmptyTestMethod()
        {
            FinderSet set = new FinderSet(new List<int> {  });
            var result = set.GetListOfSetThree();
            Assert.Empty(result);
        }

        [Fact]
        public void GetListOfSetThreeTwoElements()
        {
            FinderSet set = new FinderSet(new List<int> {1,2 });
            var result = set.GetListOfSetThree();
            Assert.Empty(result);
        }

    }
}
