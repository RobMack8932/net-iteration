using System.Collections.Generic;
using Xunit;
using DotnetIteration.Models;


namespace DotnetIteration
{

    public class TestClass
    {
        [Fact]
        public void Yelling()
        {
            var expected = new List<string> { "NOW", "IS", "THE", "BEST", "TIME" };
            var data = new List<string> { "now", "is", "the", "best", "time" };
            Assert.Equal(expected, Iteration.Yelling(data));
        }

        [Fact]
        public void Double()
        {
            var expected = new List<int> { 2, 4, 6, 8, 10 };
            var data = new List<int> { 1, 2, 3, 4, 5 };
            Assert.Equal(expected, Iteration.Double(data));
        }

        [Fact]
        public void StringyIndexes()
        {
            var data = new List<string> { "how", "now", "brown", "cow" };
            var expected = new List<string> {    "how is at index 0",
        "now is at index 1",
        "brown is at index 2",
        "cow is at index 3" };
            Assert.Equal(expected, Iteration.StringyIndexes(data));
        }



        [Fact]
        public void OnlyTheEvenSurvive()
        {
            var data = new List<int> { 42, 50, 100, 5, -43, 17, 44 };
            var expected = new List<int> { 42, 50, 100, 44 };
            Assert.Equal(expected, Iteration.OnlyTheEvenSurvive(data));
        }


        [Fact]
        public void OnlyTheEvenIndexedSurvive()
        {
            var data = new List<int> { 31, 67, 64, 96, 14, 24, 43, 51, 48, 80, 58, 43, 64, 84, 98, 99, 69, 93, 5, 32, 29, 4, 28, 18, 86, 22, 20, 74, 35, 27, 85, 79, 65, 32, 56, 94, 93, 20, 29, 22, 72 };
            var expected = new List<int> { 31, 64, 14, 43, 48, 58, 64, 98, 69, 5, 29, 28, 86, 20, 35, 85, 65, 56, 93, 29, 72 };
            Assert.Equal(expected, Iteration.OnlyTheEvenIndexedSurvive(data));
        }


        [Fact]
        public void BestMovieOfTheYear()
        {
            var data = new List<Movie> {
       new Movie { Name= "The Grand Budapest Hotel", Year = 2014, Score= 91 },
       new Movie { Name= "Birdman", Year = 2014, Score= 91 },
       new Movie { Name= "Transformers: Age of Extinction", Year = 2014, Score= 18 },
       new Movie { Name= "Rage", Year = 2014, Score= 14 },
       new Movie { Name= "Get Out", Year = 2017, Score= 99 },
       new Movie { Name= "Justice League", Year = 2017, Score= 40 },
       new Movie { Name= "Ghost in the Shell", Year = 2017, Score= 46 },
       new Movie { Name= "The Big Sick", Year = 2017, Score= 98 }

       };
            var movies2014 = new List<string> { "The Grand Budapest Hotel", "Birdman" };
            var movies2017 = new List<string> { "Get Out", "The Big Sick" };
            var movies2001 = new List<string> { };
            Assert.Equal(movies2014, Iteration.BestMovieOfTheYear(data, 2014));
            Assert.Equal(movies2017, Iteration.BestMovieOfTheYear(data, 2017));
            Assert.Equal(movies2001, Iteration.BestMovieOfTheYear(data, 2001));
        }



        [Fact(Skip = "Remove to run test")]
        public void EveryoneIsOdd()
        {
            var trueData = new List<int> { 9, 15, 27, 101, 33 };
            var falseData = new List<int> { 9, 23, 3, 4, 77 };
            Assert.True(Iteration.EveryoneIsOdd(trueData));
            Assert.False(Iteration.EveryoneIsOdd(falseData));
        }

        [Fact(Skip = "Remove to run test")]
        public void FindTheNeedle()
        {
            var data = new List<string> { "one", "time", "there was a needle at", "the market" };
            var expected = "there was a needle at";
            Assert.Equal(expected, Iteration.FindTheNeedle(data));
        }


        [Fact(Skip = "Remove to run test")]
        public void FindTheNeedleIndex()
        {
            var data = new List<string> { "one", "time", "there was a needle at", "the market" };
            var expected = 2;
            Assert.Equal(expected, Iteration.FindTheNeedleIndex(data));
        }


        [Fact(Skip = "Remove to run test")]
        public void SomeoneToLove()
        {
            var falseData = new List<string> { "how", "now", "brown", "cow" };
            var trueData = new List<string> { "how", "now", "blue", "cow" };
            Assert.True(Iteration.SomeoneToLove(trueData));
            Assert.False(Iteration.SomeoneToLove(falseData));
        }

    }
}