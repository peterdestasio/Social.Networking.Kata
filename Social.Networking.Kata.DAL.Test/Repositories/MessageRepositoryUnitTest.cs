using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Social.Networking.Kata.DAL.Interfaces;
using Social.Networking.Kata.DAL.Model;
using Social.Networking.Kata.DAL.Repositories;

namespace Social.Networking.Kata.DAL.Test.Repositories
{
    [TestClass]
    public class MessageRepositoryUnitTest
    {
        private IMessageRepository _messageRepository;
        private readonly Mock<IDBHandler> _dbHandler = new Mock<IDBHandler>();
        [TestInitialize]
        public void Initialize()
        {
            _messageRepository = new MessageRepository(_dbHandler.Object);
        }

        [TestMethod]
        public void Test_Get_Wall()
        {
            //arrange
            string[] lines = { "{\"UserId\":\"Mary\",\"Message\":\"hey Peter\",\"Time\":\"2020-05-27T21:52:57.66845-04:00\"}" };
            _dbHandler.Setup(m => m.ReadAllData()).Returns(lines);
            var expected = new List<WallMessage>();
            expected.Add(new WallMessage { UserId = "Mary", Message = "hey Peter" });

            //act
            var actual = _messageRepository.getWall("Mary");

            //assert
            Assert.AreEqual(actual[0].UserId, expected[0].UserId);
            Assert.AreEqual(actual[0].Message, expected[0].Message);
        }

        [TestMethod]
        public void Test_Get_Private_Wall()
        {
            //arrange
            string[] lines = { "{\"UserId\":\"Mary\",\"Message\":\"hey Peter\",\"Time\":\"2020-05-27T21:52:57.66845-04:00\"}" };
            _dbHandler.Setup(m => m.ReadAllData()).Returns(lines);
            var expected = new List<WallMessage>();
            expected.Add(new WallMessage { UserId = "Mary", Message = "hey Peter" });

            //act
            var actual = _messageRepository.getPrivateWall("Mary");

            //assert
            Assert.AreEqual(actual[0].UserId, expected[0].UserId);
            Assert.AreEqual(actual[0].Message, expected[0].Message);
        }
    }
}
