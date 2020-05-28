using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Social.Networking.Kata.DAL.Interfaces;
using Social.Networking.Kata.DAL.Model;
using Social.Networking.Kata.DAL.Repositories;
using System.Collections.Generic;

namespace Social.Networking.Kata.DAL.Test.Repositories
{
    [TestClass]
    public class FollowRepositoryUnitTest
    {
        private IFollowRepository _followRepository;
        private readonly Mock<IDBHandler> _dbHandler = new Mock<IDBHandler>();
        [TestInitialize]
        public void Initialize()
        {

            _followRepository = new FollowRepository(_dbHandler.Object);

        }

        [TestMethod]
        public void Test_Get_Followed_List()
        {
            //arrange
            string[] lines = { "{\"FollowerId\":\"Mary\",\"FollowedId\":\"Poppins\"}" };
            _dbHandler.Setup(m => m.ReadAllData()).Returns(lines);
            var expected = new List<Follow>();
            expected.Add(new Follow { FollowerId = "Mary", FollowedId = "Poppins" });

            //act
            var actual = _followRepository.getFollowedList("Mary");

            //assert
            Assert.AreEqual(actual[0].FollowerId, expected[0].FollowerId);
            Assert.AreEqual(actual[0].FollowedId, expected[0].FollowedId);
        }
    }
}
