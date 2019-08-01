﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var something1 = "Something";
            var something2 = "Something";

            #region string compare
            if (something1.Equals(something2, StringComparison.CurrentCulture))
            {
                Console.WriteLine("Both are same");
            }
            else
            {
                Console.WriteLine("Both are not same");
            }
            #endregion

            #region indexing and string Length.....
            Console.WriteLine(something2[4]);
            for (int i = 0; i < something1.Length; i++)
            {
                Console.Write(something1[i]);
            }

            #endregion

            #region Lower&&Substring

            Console.WriteLine();
            var subStringSomething1 = something1.Substring(0, 4).ToLower();
            Console.WriteLine(subStringSomething1);
            #endregion

            #region Upper
            var subStringSomething2 = something2.Substring(0, 4).ToUpper();
            Console.WriteLine(subStringSomething2);
            #endregion


            #region stringEmpty
            string sampleEmptyString = string.Empty;
            if(string.IsNullOrWhiteSpace(sampleEmptyString))
                Console.WriteLine("string is empty...");
            else
                Console.WriteLine("string is not empty...");
            #endregion

            #region Trim
            var sampleTrim = "   sampleTrim  ";
            Console.WriteLine(sampleTrim.Trim());
            #endregion

            #region Replace

            var stringReplace = "somestring";
            Console.WriteLine(stringReplace.Replace("some","apple"));

            #endregion

            #region Split
            var sampleWords = "some1,some2,some3,some4,some5";
            var words = sampleWords.Split(',');
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            #endregion

            #region join

            var stringJoin = string.Join(",", words);
            Console.WriteLine(stringJoin);

            #endregion
        }
    }
}
