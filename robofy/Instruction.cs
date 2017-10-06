using System;
using System.Collections.Generic;

namespace robofy
{
    public class Instruction : IInstruction
    {
        List<string> _validCardinalPoints = new List<string> {"N","E","W","S"};

        public Instruction(string instruction)
        {
            if (string.IsNullOrEmpty(instruction))
            {
                throw new ArgumentNullException("instruction");
            }

            if (instruction.Length != 2)
            {
                throw new ArgumentException("An instruction must consist of exactly two characters");
            }

            var parts = instruction.ToCharArray();

            var direction = parts[0].ToString().ToUpper();

            if (!_validCardinalPoints.Contains(direction))
            {
                throw new Exception("Invalid instruction, the first character must be a cardinal point");
            }

            Direction = direction;

            int noOfSteps;
            if (!int.TryParse(parts[1].ToString(), out noOfSteps))
            {
                throw new Exception("Invalid instruction, the second character must be an integer");
            }

            Steps = noOfSteps;
        }

        public string Direction { get; private set; }
        public int Steps { get; private set; }
    }
}
