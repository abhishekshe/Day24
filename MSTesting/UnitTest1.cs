using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using UserRegistrationProblem;

namespace UserRegistrationMSTest
{
    [TestClass]
    public class MatchingPatternsTest
    {
       
        [TestCategory("First Name")]
        [TestMethod]
        [DataRow("Abhishek")]
       
      
        public void TestingFirstName(string firstNameInput)
        {
            //Arrange
            UserRegistration userRegistration = new UserRegistration();
            try
            {

                //Act
                bool expected = userRegistration.FirstAndLastName(firstNameInput);
                //Arrange
                Assert.IsTrue(expected, firstNameInput);
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual(ex.Message, "invalid name");
            }
        }
       
        [TestCategory("Last Name")]
        [TestMethod]
        [DataRow("garg")]
        public void TestingLastName(string lastNameInput)
        {
            //Arrange
            UserRegistration userRegistration = new UserRegistration();
            try
            {
                //Act
                bool expected = userRegistration.FirstAndLastName(lastNameInput);
                //Arrange
                Assert.IsTrue(expected, lastNameInput);
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual(ex.Message, "invalid name");
            }

        }
       
        [TestMethod]
      
        [DataRow("abhishek.lodhi@gmail.com")]
       
        public void TestingEmail(string emailInput)
        {
            try
            {
                //Arrange
                UserRegistration userRegistration = new UserRegistration();
                //Act
                bool expected = userRegistration.Email(emailInput);
                //Arrange
                Assert.IsTrue(expected, emailInput);
            }
            catch (UserRegistrationCustomException ue)
            {
                Assert.AreEqual(ue.Message, "invalid email");
            }
        }
      
        [TestMethod]
        [DataRow("91 8570912858")]
      
        public void TestingMobileNo(string mobileNoInput)
        {
            try
            {
                //Arrange
                UserRegistration userRegistration = new UserRegistration();
                //Act
                bool expected = userRegistration.MobileNo(mobileNoInput);
                //Arrange
                Assert.IsTrue(expected, mobileNoInput);
            }
            catch (UserRegistrationCustomException ue)
            {
                Assert.AreEqual(ue.Message, "invalid phone");
            }
        }
      
        [TestMethod]
        [DataRow("Abhishek111")]
       
        public void TestingPassword(string passwordInput)
        {
            try
            {
                //Arrange
                UserRegistration userRegistration = new UserRegistration();
                //Act
                bool expected = userRegistration.Password(passwordInput);
                //Arrange
                Assert.IsTrue(expected, passwordInput);
            }
            catch (UserRegistrationCustomException ue)
            {
                Assert.AreEqual(ue.Message, "invalid password");
            }
        }
    }
}