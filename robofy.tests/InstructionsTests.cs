using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace robofy.tests
{
    //NAMING STARDARD : Class_Method_Condition_ExpectedResult
       
    [TestClass]    
    public class InstructionTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Instruction_CTOR_ParameterIsNull_ThrowsException()
        {
            new Instruction(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Instruction_CTOR_ParameterIsEmptyString_ThrowsException()
        {
            new Instruction(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Instruction_CTOR_ParameterIsOneCharacter_ThrowsException()
        {
            new Instruction("N");
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Instruction_CTOR_ParameterHasMoreThanTwoCharacters_ThrowsException()
        {
            new Instruction("N44");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Instruction_CTOR_ParametersFirstCharacterIsAnInvalidCardinalPoint_ThrowsException()
        {
            new Instruction("T4");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Instruction_CTOR_ParametersSecondCharacterIsNotAnInteger_ThrowsException()
        {
            new Instruction("NN");
        }

        [TestMethod]
        public void Instruction_CTOR_AValidParameter_AValidInstance()
        {
            var instruction = new Instruction("N4");
            Assert.AreEqual("N", instruction.Direction, "An instruction was constructed with a cardinal point 'N 'but has a value other that 'N'");
            Assert.AreEqual(4, instruction.Steps, "An instruction was constructed with 4 steps but has a value other than 4");
        }
    }
}
