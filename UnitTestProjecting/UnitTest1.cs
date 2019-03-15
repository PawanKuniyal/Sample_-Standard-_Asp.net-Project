using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleAppForStandardCoding;

namespace UnitTestProjecting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sorting_Input()
        {
            var stringStatistics = new StringClass(new FakeStringStatistics());
            stringStatistics._iStringStatistics.SortString("sasfasjdklajs ajksfd asdfjkasdjkf", enumTypes.sortType.AlphabeticAsc);
        }
        public class FakeStringStatistics : IStringStatistics
        {
            public string SortString(string data, Enum @enum)
            {
                return "";
            }
        }
    }
}
