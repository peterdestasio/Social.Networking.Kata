using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Social.Networking.Kata.BusinessService.Interfaces;
using Social.Networking.Kata.BusinessService.Services;
using Social.Networking.Kata.DAL.Interfaces;
using Social.Networking.Kata.DAL.Model;
using System;
using System.Collections.Generic;

namespace Social.Networking.Kata.BusinessService.Test
{
    [TestClass]
    public class UnitTest1
    {
        private IMessageService _messageService;

        private readonly Mock<IMessageRepository> _messageRepository = new Mock<IMessageRepository>();
        private readonly Mock<ITimeFormatter> _timeFormatter = new Mock<ITimeFormatter>();
        private readonly Mock<IFollowRepository> _followRepository = new Mock<IFollowRepository>();
        [TestInitialize]
        public void Initialize()
        {
            _messageService = new MessageService(_messageRepository.Object, _timeFormatter.Object, _followRepository.Object);
        }


        [TestMethod]
        public void Test_View_Private_Wall()
        {
            var wallList = new List<WallMessage>();
            wallList.Add(new WallMessage { UserId = "Mary", Message = "hey Peter", Time = DateTime.Now });
            _messageRepository.Setup(m => m.getPrivateWall(It.IsAny<string>())).Returns(wallList);
            _timeFormatter.Setup(m => m.elapsedMinutes(It.IsAny<DateTime>())).Returns("10");
            var actual = _messageService.viewPrivateWall("Mary", true);
            var expected = "Mary - hey Peter (10 minutes ago)\r\n";
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_View_Private_Wall_No_Show_Id()
        {
            var wallList = new List<WallMessage>();
            wallList.Add(new WallMessage { UserId = "Mary", Message = "hey Peter", Time = DateTime.Now });
            _messageRepository.Setup(m => m.getPrivateWall(It.IsAny<string>())).Returns(wallList);
            _timeFormatter.Setup(m => m.elapsedMinutes(It.IsAny<DateTime>())).Returns("10");
            var actual = _messageService.viewPrivateWall("Mary", false);
            var expected = "hey Peter (10 minutes ago)\r\n";
            Assert.AreEqual(actual, expected);
        }

    }
}
