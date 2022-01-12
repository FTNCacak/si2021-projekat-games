using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shared.Models;
using Shared.Interfaces;
using Moq;
using BusinessLayer;
namespace UserBusinessTests
{
    [TestClass]
    public class UserBusinessTest
    {
        private Mock<IUserRepository> mockUserRepository = new Mock<IUserRepository>();
        private User user = new User
        {
            Name = "John",
            Lastname = "Doe",
            Email = "johndoe@email.com",
            Password = "testpassword123",
            Phone = "060/100-2003",
            Wallet = 100
        };

        private UserBusiness userBusiness;
        [TestMethod]
        public void IsUserInserted()
        {
            // Arrange
            mockUserRepository.Setup(x=> x.InsertUser(user));
            userBusiness = new UserBusiness(mockUserRepository.Object);

            bool result;

            // Act

            try
            {
                userBusiness.InsertUser(user);
                result = true;
            }
            catch (Exception)
            {

                result = false;
            }


            // Assert

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NameAndLastNameTest() {

            // Arrange

            string invalidInputOne = "name";
            string invalidInputTwo = "Nam123n";
            string invalidInputThree = "John@";

            string validInput = "John";

            userBusiness = new UserBusiness(mockUserRepository.Object);

            // Act

            bool resultOne = userBusiness.NameAndLastNameFormatValidation(invalidInputOne);

            bool resultTwo = userBusiness.NameAndLastNameFormatValidation(invalidInputTwo);

            bool resultThree = userBusiness.NameAndLastNameFormatValidation(invalidInputThree);

            bool resultFour = userBusiness.NameAndLastNameFormatValidation(validInput);


            // Assert

            Assert.IsFalse(resultOne);
            Assert.IsFalse(resultTwo);
            Assert.IsFalse(resultThree);

            Assert.IsTrue(resultFour);
        }

        [TestMethod]
        public void PhoneTest()
        {

            // Arrange

            string invalidInputOne = "06/123-123";
            string invalidInputTwo = "0601234134";
            string invalidInputThree = "060/123456";

            string validInputOne = "060/123-123";
            string validInputTwo = "060/123-1234";
            

            userBusiness = new UserBusiness(mockUserRepository.Object);

            // Act

            bool resultOne = userBusiness.PhoneFormatValidation(invalidInputOne);

            bool resultTwo = userBusiness.PhoneFormatValidation(invalidInputTwo);

            bool resultThree = userBusiness.PhoneFormatValidation(invalidInputThree);

            bool resultFour = userBusiness.PhoneFormatValidation(validInputOne);
            bool resultFive = userBusiness.PhoneFormatValidation(validInputTwo);


            // Assert

            Assert.IsFalse(resultOne);
            Assert.IsFalse(resultTwo);
            Assert.IsFalse(resultThree);

            Assert.IsTrue(resultFour);
            Assert.IsTrue(resultFive);
        }


        public void EmailTest()
        {

            // Arrange

            string invalidInputOne = "@example.com";
            string invalidInputTwo = "email.@example.com";
            string invalidInputThree = "email..email@example.com";

            string validInputOne = "email@subdomain.example.com";
            string validInputTwo = "firstname+lastname@example.com";
            string validInputThree = "email@example-one.com";

            userBusiness = new UserBusiness(mockUserRepository.Object);

            // Act

            bool resultOne = userBusiness.EmailFormatValidation(invalidInputOne);

            bool resultTwo = userBusiness.EmailFormatValidation(invalidInputTwo);

            bool resultThree = userBusiness.EmailFormatValidation(invalidInputThree);

            bool resultFour = userBusiness.EmailFormatValidation(validInputOne);
            bool resultFive = userBusiness.EmailFormatValidation(validInputTwo);
            bool resultSix = userBusiness.EmailFormatValidation(validInputThree);


            // Assert

            Assert.IsFalse(resultOne);
            Assert.IsFalse(resultTwo);
            Assert.IsFalse(resultThree);

            Assert.IsTrue(resultFour);
            Assert.IsTrue(resultFive);
            Assert.IsTrue(resultSix);
        }


    }
}
