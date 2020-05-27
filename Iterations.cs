using System;
using System.Collections.Generic;
using System.Linq;
using DotnetIteration.Models;

namespace DotnetIteration
{

    public static class Iteration
    {


        /*
Welcome to Interation
Down below you will find instructions for code to write.
As you write and save your code, you can look in your terminal where you
ran `dotnet watch test` to see if your code is working. The tests continuously check
your work each time you save. If a test is failing you have not yet completed that method
Once you finish a method and have it correct, the test will tell you how
the next method is working.
*/


        //  
        // 1) Complete the method named `yelling` that takes an list of
        //    words as an argument and returns a new list with all
        //    the words forced to uppercase.
        //
        public static IEnumerable<string> Yelling(List<string> words)
        {
            var newList = words.Select(word => word.ToUpper());
            return newList;
        }


        // 
        // 2) Complete the method named `Double` that takes an list of
        //    numbers as an argument and returns a new list with all
        //    the numbers multiplied by 2.
        // 
        public static IEnumerable<int> Double(List<int> numbers)
        {


            var newScores = numbers.Select(score => score * 2);
            return newScores;






        }



        // 
        // 3) Complete the method `StringyIndexes` that takes an list of
        //    strings as an argument and returns a new list with each
        //    string suffixed with " is at index X" where X is the index
        //    of the element.
        // 
        public static IEnumerable<string> StringyIndexes(List<string> data)

        {


            var query =
                data.Select((itsLate) => $"{itsLate} is at index {data.IndexOf(itsLate)}");

            return query;
        }





        // 
        // 4) Complete the method OnlyTheEvenSurvive that accepts an list of
        //    numbers and returns only the elements that are even.
        // 

        public static IEnumerable<int> OnlyTheEvenSurvive(List<int> numbers)



        {
            var evenNumbers = numbers.Where((number) => number % 2 == 0);


            return evenNumbers;



        }




        // 
        // 5) Complete the method OnlyTheEvenIndexedSurvive that accepts an
        //    list of numbers and returns only the elements at indexes that
        //    are even.
        // 
        public static IEnumerable<int> OnlyTheEvenIndexedSurvive(List<int> data)
        {
            int IndexOf(string value, int startIndex, StringComparison comparisonType);

            var evenNumbers = data.Where((number) => number % 2 == 0);


            return evenNumbers;
        }

        private static void NotFiniteNumberException(IEnumerable<int> enumerable1)
        {
            throw new NotImplementedException();
        }


        // 
        // 6) Complete the method BestMoviesOfTheYear that accepts an list of
        //    movie objects AND a year and returns the names of movies that are
        //    from that year AND have a score more than 90.
        // 
        // A movie object looks like this:
        // 
        // {
        //   name: "Get Out",
        //   year: "2017",
        //   score: 99
        // }
        // 
        public static IEnumerable<string> BestMovieOfTheYear(List<Movie> data, int year)
        {
            throw new System.NotImplementedException();
        }


        // 
        // 7) Complete the method EveryoneIsOdd that accepts an list of
        //    numbers and returns true if every element of the list is odd.
        // 
        public static bool EveryoneIsOdd(List<int> data)
        {
            throw new System.NotImplementedException();
        }


        // 
        // 8) Complete the method FindTheNeedle that accepts an list of
        //    strings and returns the one string that contains the word
        //    `needle`.
        // 
        public static string FindTheNeedle(List<string> data)
        {
            throw new System.NotImplementedException();
        }


        // 
        // 9) Complete the method FindTheNeedleIndex that accepts an list of
        //    strings and returns the index of the string that contains
        //    the word `needle` inside.
        // 
        public static int FindTheNeedleIndex(List<string> data)
        {
            throw new System.NotImplementedException();
        }


        // 
        // 10) Complete the method SomeoneToLove that accepts an list of
        //     strings and returns true if at least one string is exactly
        //     four characters long.
        // 
        public static bool SomeoneToLove(List<string> data)
        {
            throw new System.NotImplementedException();
        }
    }

    internal class NewClass
    {
        public int Index { get; }
        public object Str { get; }

        public NewClass(int index, object str)
        {
            Index = index;
            Str = str;
        }

        public override bool Equals(object obj)
        {
            return obj is NewClass other &&
                   Index == other.Index &&
                   EqualityComparer<object>.Default.Equals(Str, other.Str);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Index, Str);
        }
    }
}