﻿using System;
using System.Collections.Generic;
using System.Linq;
using LinqTutorial.MethodSyntax;

namespace LinqTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //METHOD SYNTAX

            //Any.Run();
            //All.Run();
            //Count.Run();
            //Contains.Run();
            //OrderBy.Run();
            //MinMax.Run();
            //Average.Run();
            //Sum.Run();
            //ElementAt.Run();
            //FirstLast.Run();
            //SingleElement.Run();
            //Where.Run();
            //Take.Run();
            //Skip.Run();
            //OfType.Run();
            //Distinct.Run();
            //PrependAppend.Run();
            //ConcatUnion.Run();
            //TypeSwitching.Run();           
            //Select.Run();
            //SelectMany.Run();
            //GeneratingNewCollection.Run();
            //GroupBy.Run();
            //IntersectExcept.Run();
            //Joins.Run();
            //Aggregate.Run();
            //Zip.Run();

            //QUERY SYNTAX

            //OrderBy.QuerySyntax.Run();
            //Where.QuerySyntax.Run();
            //Select.QuerySyntax.Run();
            //SelectMany.QuerySyntax.Run();
            //GroupBy.QuerySyntax.Run();
            //Joins.QuerySyntax.Run();

            Console.ReadKey();

            var numbers = new[] { 1, 45, 56, 789, 34, 234, 567 };

            var even = isAny(numbers,  x => x % 2 == 0);
            var large = isAny(numbers, x => x >100);
            var totEven = numbers.Count(x => x % 2 == 0);

            var words = new List<String> { "aaa", "duele", "oooo","i","o" };
            var isAnyLength = isAny(words, word => word.Length == 4);
            var shortWords = words.Where(word => word.Length < 3);

            foreach(var word in shortWords)
            {
                Console.WriteLine(shortWords);
            }

            words.Add("ay");
            foreach (var word in shortWords)
            {
                Console.WriteLine(shortWords);
            }
        }

        static bool isAny<T>(IEnumerable<T> collection, Func<T,bool> function)
        {
            foreach(T n in collection)
            {
                if(function(n))
                {
                    return true;
                }
            }
            return false;
        }
        //returns true if any of the words if only uppercase
        static bool isAnyWordUppercase(IEnumerable<string> words)
        {
            return words.Any(word => word.All(c => char.IsUpper(c)));
        }

        static bool isAnyLargerThanN(int[] numbers, int max)
        {
            return numbers.Any(n => n > max);
        }

        static bool isAnyEven(int[] numbers)
        {
            return numbers.Any(n => n % 2 == 0);
        }

    }
}
