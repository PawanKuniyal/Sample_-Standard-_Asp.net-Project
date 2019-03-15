using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAppForStandardCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            //getting input from user for which function he needs to perform
            System.Console.WriteLine("Please select for 1-statistic, 2-Sorting");
            string input = Console.ReadLine();
            int validinput = 0;
            //validating input is correct
            int.TryParse(input, out validinput);
            while (validinput <= 0 || validinput > 2)
            {
                System.Console.WriteLine("Please select for 1-statistic, 2-Sorting");
                input = Console.ReadLine();
                int.TryParse(input, out validinput);
                if (validinput <= 0 || validinput > 2)
                    continue;
                else
                    break;
            }
            //call appropriate method for input
            if (validinput == 2)
                Sorting();
            else if (validinput == 1)
                Statistic();
        }
        static void Sorting()
        {
            //taking input to sort a string
            System.Console.WriteLine("Please enter string to sort");
            string datatosort = System.Console.ReadLine();
            //validating input to sort a string
            while (string.IsNullOrEmpty(datatosort))
            {
                System.Console.WriteLine("Please enter string to sort");
                datatosort = Console.ReadLine();
                if (string.IsNullOrEmpty(datatosort))
                    continue;
                else
                    break;
            }
            //taking input to sort type
            System.Console.WriteLine("Please enter sort type 1-AlphabeticAsc, 2-AlphabeticDesc, 3-LenghtAsc");
            string sortingtype = Console.ReadLine();
            int sorttype = 0;
            int.TryParse(sortingtype, out sorttype);
            //validating input to sort type
            while (sorttype == 0 || sorttype > 3 || sorttype < 0)
            {
                System.Console.WriteLine("Please enter sort type 1-AlphabeticAsc, 2-AlphabeticDesc, 3-LenghtAsc");
                sortingtype = Console.ReadLine();
                int.TryParse(sortingtype, out sorttype);
                if (sorttype == 0 || sorttype > 3 || sorttype < 0)
                    continue;
                else
                    break;
            }
            //calling method to perform sotring on string
            if (Enum.IsDefined(typeof(enumTypes.sortType), sorttype))
            {
                enumTypes.sortType sorting = (enumTypes.sortType)sorttype;
                var stringStatistics = new StringClass(new StringStatistics());
                Console.WriteLine(stringStatistics._iStringStatistics.SortString(datatosort, sorting));
                Console.ReadLine();
            }
        }
        static void Statistic()
        {
            //taking input to perform statistic on a string
            System.Console.WriteLine("Please enter string to get statistic");
            string datatosort = System.Console.ReadLine();
            //validating input to perform statistic on a string
            while (string.IsNullOrEmpty(datatosort))
            {
                System.Console.WriteLine("Please enter string to sort");
                datatosort = Console.ReadLine();
                if (string.IsNullOrEmpty(datatosort))
                    continue;
                else
                    break;
            }
            //calling function to perform statistic on string
            var stringManipulation = new StringClass(new StringManipulation());
            Console.WriteLine(stringManipulation._iStringManipulation.StatisticsOfString(datatosort));
            Console.ReadLine();
        }
    }
}
