using System;
using System.Collections.Generic;
using System.Linq;

namespace robofy
{
    public class Controller : IController
    {
        List<Instruction> instructions;
        public Controller(List<string> instructions)
        {
            if (instructions == null)
            {
                throw new ArgumentNullException("instructions");
            }

            this.instructions = instructions.Select(instr => new Instruction(instr))
                                            .ToList();
        }

        string GetTurn(string previousDirection, string currentDirection)
        {
            if (previousDirection == currentDirection)
            {
                return "straight";
            }

            var turn = "";

            switch (previousDirection)
            {
                case "N":
                    {
                        turn = currentDirection == "W" ? "left" : "right";
                        break;
                    }
                case "W":
                    {
                        turn = currentDirection == "S" ? "left" : "right";
                        break;
                    }
                case "E":
                    {
                        turn = currentDirection == "N" ? "left" : "right";
                        break;
                    }
                case "S":
                    {
                        turn = currentDirection == "E" ? "left" : "right";
                        break;
                    }
            }

            return turn;
        }

        List<Block> getVisitedSquares()
        {
            var squares = new List<Block>();
            var me = this;

            Action<Instruction> processInstruction = (instruction) =>
            {
                for (var index = 0; index < instruction.Steps; index++)
                {
                    if (squares.Count == 0)
                    {
                        squares.Add(new Block
                        {
                            X = 0,
                            Y = 0,
                            Turn = "straight",
                            Directory = instruction.Direction
                        });
                    }
                    else
                    {
                        var previousBlock = squares[squares.Count - 1];
                        var x = previousBlock.X;
                        var y = previousBlock.Y;
                        var turn = me.GetTurn(previousBlock.Directory, instruction.Direction);
                        switch (instruction.Direction)
                        {
                            case "N":
                                {
                                    y += 1;
                                    break;
                                }
                            case "W":
                                {
                                    x += 1;
                                    break;
                                }
                            case "E":
                                {
                                    x -= 1;
                                    break;
                                }
                            case "S":
                                {
                                    y -= 1;
                                    break;
                                }
                        }
                        squares.Add(new Block
                        {
                            X = x,
                            Y = y,
                            Turn = turn,
                            Directory = instruction.Direction
                        });
                    }
                }
            };

            instructions.ForEach(instruction =>
            {
                processInstruction(instruction);
            });

            return squares;
        }

        public List<Block> UniqueSquaresVisited
        {
            get
            {
                var uniqueSquares = new List<Block>();
                AllSquaresVisited.ForEach(block =>
                {
                    var i = uniqueSquares.SingleOrDefault(ub => ub.X == block.X && ub.Y == block.Y);
                    if (i == null)
                    {
                        uniqueSquares.Add(block);
                    }
                });
                return uniqueSquares;
            }
        }

        List<Block> _visitedSquares;
        public List<Block> AllSquaresVisited
        {
            get
            {
                return _visitedSquares ?? (_visitedSquares = getVisitedSquares());
            }
        }

        public int NoOfLeftTurns
        {
            get
            {
                return AllSquaresVisited.Count(b => b.Turn == "left");
            }
        }

        public int NoOfRightTurns
        {
            get
            {
                return AllSquaresVisited.Count(b => b.Turn == "right");
            }
        }
    }
}
