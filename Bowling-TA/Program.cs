using System;
using System.Collections.Generic;

namespace Bowling_TA
{
    class Program
    {

        static int Bowl1Game(Random rnd)
        {
            var game = new List<int>(10);
            for (var idx = 0; idx < 10; idx++)
            {
                var score = rnd.Next(0, 31);
                game.Add(score);
            }

            var Total = 0;

            foreach (var score in game)
            {
                Total += score;
            }
            Console.WriteLine($"Score is {Total}.");
            return Total;
        }
        static void Main(string[] args)
        {
            var rnd = new Random();
            var series = 0;
            for (var idx = 0; idx < 3; idx++)
            {
                var score = Bowl1Game(rnd);
                series += score;
            }
            Console.WriteLine($"Series score: {series}");


        }
    }
}
