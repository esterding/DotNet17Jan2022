using NUnit.Framework;
using SampleMVC.Models;
using SampleMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace SampleMVCTest
{
    public class UserActionTest
    {
        [Test]
        public void SimpleTest()
        {
            //Arrange 
            Mock<UserRepo> mockRepo = new Mock<UserRepo>();
            mockRepo.Setup(x => x.GetT("Simsim")).Returns(new User { Username = "Simsim", Password = "sim123" });
            LoginService service = new LoginService(mockRepo.Object);
            User user = new User() { Username = "Simsim", Password = "sim123" };
            //Act
            var resultuser = service.LoginCheck(user);
            //Assert
            Assert.IsNotNull(resultuser);
        }
    }
}
