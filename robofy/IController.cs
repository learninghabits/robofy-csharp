using System.Collections.Generic;

namespace robofy
{
    public interface IController
    {
        List<Block> AllSquaresVisited { get; }
        int NoOfLeftTurns { get; }
        int NoOfRightTurns { get; }
        List<Block> UniqueSquaresVisited { get; }
    }
}