using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DataLayer;
using Shared.Models;

namespace UserRepositoryTests
{
    [TestClass]
    public class UserRepositoryTest
    {
        public User user;
        public UserRepository userRepository;

        [TestInitialize]
        public void init() {
            user = new User {
                Name = "John",
                Lastname = "Doe",
                Email = "johndoe@email.com",
                Password = "testpassword123",
                Phone = "060/100-2003",
                Wallet = 100
            };
            userRepository = new UserRepository();
        }


        [TestMethod]
        public void IsUserInserted()
        {
            bool result = false;

            try
            {
                userRepository.InsertUser(user);
                result = true;
            }
            catch (Exception)
            {
                result = false;
              
            }

            Assert.IsTrue(result);

        }
        [TestMethod]
        public void GetAllEmailsTest()
        {
            int result = userRepository.GetAllEmails().Count;
           

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void GetPasswordTest()
        {
            string result = userRepository.GetUserPasswordByEmail(user.Email);

            Assert.IsNotNull(result);
        }
    }
}
