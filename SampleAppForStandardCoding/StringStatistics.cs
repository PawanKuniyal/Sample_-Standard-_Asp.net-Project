using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAppForStandardCoding
{
    public class StringStatistics : enumTypes, IStringStatistics
    {
        public string SortString(string data, Enum type)
        {
            //checking input string should not be empty
            if (string.IsNullOrWhiteSpace(data))
            {
                return "string cannot be empty.";
            }
            //sort by alphabetic in ascending order
            string res = "";
            if (type.Equals(sortType.AlphabeticAsc))
            {
                res += "Input String: " + data + Environment.NewLine;
                res += "Sorted by AlphabeticAsc: " + String.Concat(data.OrderBy(c => c));
            }
            //sort by alphabetic in descending order
            if (type.Equals(sortType.AlphabeticDesc))
            {
                res += "Input String: " + data + Environment.NewLine;
                res += "Sorted by AlphabeticDesc: " + String.Concat(data.OrderByDescending(c => c));
            }
            //sort by lenght of word in ascending order
            if (type.Equals(sortType.LenghtAsc))
            {
                string[] strlst = data.Split(' ');
                Array.Sort(strlst, (x, y) => x.Length.CompareTo(y.Length));
                res += "Input String: " + data + Environment.NewLine;
                res += "Sorted by LenghtAsc: ";
                foreach (string s in strlst)
                {
                    res += (s + " ");
                }
            }
            return res;
        }        
    }
}
