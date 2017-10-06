using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace robofy.tests
{
    //NAMING STARDARD : Class_Method_Condition_ExpectedResult

    [TestClass]
    public class ControllerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Controller_CTOR_ParameterIsNull_ThrowsException()
        {
            new Controller(null);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterIsAnEmptyInstructionsArray_UniqueSquaresCountIsZero()
        {
            var controller = new Controller(new List<string>());
            Assert.AreEqual(0, controller.UniqueSquaresVisited.Count);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterIsAnEmptyInstructionsArray_AllVisitedSquaresCountIsZero()
        {
            var controller = new Controller(new List<string>());
            Assert.AreEqual(0, controller.AllSquaresVisited.Count);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterIsAnEmptyInstructionsArray_NoOfLeftTurnsIsZero()
        {
            var controller = new Controller(new List<string>());
            Assert.AreEqual(0, controller.NoOfLeftTurns);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterIsAnEmptyInstructionsArray_NoOfRightTurnsIsZero()
        {
            var controller = new Controller(new List<string>());
            Assert.AreEqual(0, controller.NoOfRightTurns);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterHasOneInstructionAsN4_UniqueSquaresCountIsFour()
        {
            var controller = new Controller(new List<string> { "N4" });
            Assert.AreEqual(4, controller.UniqueSquaresVisited.Count);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterHasOneInstructionAsN4_AllVisitedSquaresCountIsFour()
        {
            var controller = new Controller(new List<string> { "N4" });
            Assert.AreEqual(4, controller.AllSquaresVisited.Count);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterHasOneInstructionAsN4_NoOfLeftTurnsIsZero()
        {
            var controller = new Controller(new List<string> { "N4" });
            Assert.AreEqual(0, controller.NoOfLeftTurns);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterHasOneInstructionAsN4_NoOfRightTurnsIsZero()
        {
            var controller = new Controller(new List<string> { "N4" });
            Assert.AreEqual(0, controller.NoOfRightTurns);
        }


        [TestMethod]
        public void Controller_CTOR_ParameterHasTwoInstructionsAsN4E2_UniqueSquaresCountIsSix()
        {
            var controller = new Controller(new List<string> {"N4","E2"});
            Assert.AreEqual(6, controller.UniqueSquaresVisited.Count);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterHasTwoInstructionsAsN4E2_AllVisitedSquaresCountIsSix()
        {
            var controller = new Controller(new List<string> {"N4","E2"});
            Assert.AreEqual(6, controller.AllSquaresVisited.Count);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterHasTwoInstructionsAsN4E2_NoOfLeftTurnsIsZero()
        {
            var controller = new Controller(new List<string> {"N4","E2"});
            Assert.AreEqual(0, controller.NoOfLeftTurns);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterHasTwoInstructionsAsN4E2_NoOfRightTurnsIsOne()
        {
            var controller = new Controller(new List<string> {"N4","E2"});
            Assert.AreEqual(1, controller.NoOfRightTurns);
        }


        [TestMethod]
        public void Controller_CTOR_ParameterHasThreeInstructionsAsN4E2S2_UniqueSquaresCountIsEight()
        {
            var controller = new Controller(new List<string> { "N4", "E2", "S2" });
            Assert.AreEqual(8, controller.UniqueSquaresVisited.Count);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterHasThreeInstructionsAsN4E2S2_AllVisitedSquaresCountIsEight()
        {
            var controller = new Controller(new List<string> { "N4", "E2", "S2" });
            Assert.AreEqual(8, controller.AllSquaresVisited.Count);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterHasThreeInstructionsAsN4E2S2_NoOfLeftTurnsIsZero()
        {
            var controller = new Controller(new List<string> { "N4", "E2", "S2" });
            Assert.AreEqual(0, controller.NoOfLeftTurns);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterHasThreeInstructionsAsN4E2S2_NoOfRightTurnsIsOne()
        {
            var controller = new Controller(new List<string> { "N4", "E2", "S2" });
            Assert.AreEqual(2, controller.NoOfRightTurns);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterHasFourInstructionsAsN4E2S2W4_UniqueSquaresCountIsEleven()
        {
            var controller = new Controller(new List<string> { "N4", "E2", "S2", "W4" });
            Assert.AreEqual(11, controller.UniqueSquaresVisited.Count);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterHasFourInstructionsAsN4E2S2W4_AllVisitedSquaresCountIsTwelve()
        {
            var controller = new Controller(new List<string> { "N4", "E2", "S2", "W4" });
            Assert.AreEqual(12, controller.AllSquaresVisited.Count);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterHasFourInstructionsAsN4E2S2W4_NoOfLeftTurnsIsZero()
        {
            var controller = new Controller(new List<string> { "N4", "E2", "S2", "W4" });
            Assert.AreEqual(0, controller.NoOfLeftTurns);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterHasFourInstructionsAsN4E2S2W4_NoOfRightTurnsIsThree()
        {
            var controller = new Controller(new List<string> { "N4", "E2", "S2", "W4" });
            Assert.AreEqual(3, controller.NoOfRightTurns);
        }
        
        [TestMethod]
        public void Controller_CTOR_ParameterHasFiveInstructionsAsN4E2S2W4S3_UniqueSquaresCountIsFourteen()
        {
            var controller = new Controller(new List<string> { "N4", "E2", "S2", "W4", "S3" });
            Assert.AreEqual(14, controller.UniqueSquaresVisited.Count);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterHasFiveInstructionsAsN4E2S2W4S3_AllVisitedSquaresCountIsFifteen()
        {
            var controller = new Controller(new List<string> { "N4", "E2", "S2", "W4", "S3" });
            Assert.AreEqual(15, controller.AllSquaresVisited.Count);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterHasFiveInstructionsAsN4E2S2W4S3_NoOfLeftTurnsIsOne()
        {
            var controller = new Controller(new List<string> { "N4", "E2", "S2", "W4", "S3" });
            Assert.AreEqual(1, controller.NoOfLeftTurns);
        }

        [TestMethod]
        public void Controller_CTOR_ParameterHasFiveInstructionsAsN4E2S2W4S3_NoOfRightTurnsIsThree()
        {
            var controller = new Controller(new List<string> { "N4", "E2", "S2", "W4", "S3" });
            Assert.AreEqual(3, controller.NoOfRightTurns);
        }
    }
}
