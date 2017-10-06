using System;
using System.Linq;

namespace robofy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**ROBOFY HAS STARTED**");
            Console.WriteLine("PLEASE INPUT INSTRUCTIONS");
            Console.WriteLine("       INPUT 'X' TO TERMINATE");

            var input = Console.ReadLine();

            IController controller;

            while (input != "X")
            {
                var instructions = input.Split(',')
                                        .Where(element => !string.IsNullOrEmpty(element))
                                        .ToList();

                controller = new Controller(instructions);
                var uniqueSquares = controller.UniqueSquaresVisited;
                Console.WriteLine($"total number of unique squares = {uniqueSquares.Count}");
                var allSquares = controller.AllSquaresVisited;
                Console.WriteLine($"total number of visited squares = {allSquares.Count}");
                var noOfLeftTurns = controller.NoOfLeftTurns;
                Console.WriteLine($"total number of left turns = {noOfLeftTurns}");
                var noOfRightTurns = controller.NoOfRightTurns;
                Console.WriteLine($"total number of right turns = {noOfRightTurns}");
                input = Console.ReadLine();
            }
        }
    }
}
