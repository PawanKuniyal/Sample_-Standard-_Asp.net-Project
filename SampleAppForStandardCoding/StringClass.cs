using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAppForStandardCoding
{
    public class StringClass
    {
        public readonly IStringStatistics _iStringStatistics;
        public readonly IStringManipulation _iStringManipulation;
        public StringClass(IStringManipulation iStringManipulation)
        {
            _iStringManipulation = iStringManipulation;
        }
        public StringClass(IStringStatistics iStringStatistics)
        {
            _iStringStatistics = iStringStatistics;
        }
    }
}
