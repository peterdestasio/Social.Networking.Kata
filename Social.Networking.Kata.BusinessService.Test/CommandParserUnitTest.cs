using Microsoft.VisualStudio.TestTools.UnitTesting;
using Social.Networking.Kata.BusinessService.Interfaces;
using Social.Networking.Kata.BusinessService.Services;

namespace Social.Networking.Kata.BusinessService.UnitTest
{
    [TestClass]
    public class CommandParserUnitTest
    {
        private ICommandParser _commandParser;

        [TestInitialize]
        public void Initialize()
        {
            _commandParser = new CommandParser();
        }


        [TestMethod]
        public void Test_Follow_Command()
        {
            //arrange
            var input = "Peter follows Mary Poppins";
            string[] expected = { "Peter", "follows", "Mary Poppins" };

            //act
            var result = _commandParser.parse(input);

            //assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        [TestMethod]
        public void Test_Post_To_Wall_Command()
        {
            //arrange
            var input = "Peter -> hey this is My wall";
            string[] expected = { "Peter", "->", "hey this is My wall" };

            //act
            var result = _commandParser.parse(input);            

            //assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
        }

        [TestMethod]
        public void Test_View_Wall_Command()
        {
            //arrange
            var input = "Peter";
            string[] expected = { "Peter", "" };

            //act
            var result = _commandParser.parse(input);
            
            //assert
            Assert.AreEqual(result[0], expected[0]);
        }


        [TestMethod]
        public void Test_View_Wall_By_Id_Command()
        {
            //arrange
            var input = "Peter wall";
            string[] expected = { "Peter", "wall" };

            //act
            var result = _commandParser.parse(input);

            //assert
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
        }
    }
}
