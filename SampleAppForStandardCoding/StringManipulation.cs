using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAppForStandardCoding
{
    public class StringManipulation : IStringManipulation
    {
        public string StatisticsOfString(string data)
        {
            if (string.IsNullOrWhiteSpace(data))
            {
                return "string cannot be empty.";
            }
            string res = "";
            //count hyphens in a input string
            int coutHyphes = data.Count(x => x == '-');
            //count spaces in a input string
            int coutSpace = data.Count(x => x == ' ');
            //count words in a input string
            int wordCount = 0, index = 0;
            while (index < data.Length)
            {
                // check if current char is part of a word
                while (index < data.Length && !char.IsWhiteSpace(data[index]))
                    index++;
                wordCount++;

                // skip whitespace until next word
                while (index < data.Length && char.IsWhiteSpace(data[index]))
                    index++;
            }
            //generating response
            res = "data: " + data + Environment.NewLine;
            res += "Text Statistics:" + Environment.NewLine;
            res += "Hyphens : " + coutHyphes + Environment.NewLine;
            res += "Spaces : " + coutSpace + Environment.NewLine;
            res += "Words : " + wordCount;
            return res;
        }
    }
}
