using System;
using System.Diagnostics;
using MainApp.DataManager;
using MainApp.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppTest
{
    [TestClass]
    public class UserModuleTest
    {
        private User _user;

        [TestInitialize]
        public void StartUp()
        {
            _user = new User();
        }

        [TestMethod("User can generate random user")]
        public void Test_User_CreateNewRandomUser()
        {
            User newUser = _user.CreateNewRandomUser();
            Assert.IsNotNull(newUser);
        }

        [TestMethod]
        public void Test_User_CreateNewRandomUser_NotReturnsNull()
        {
            User newUser = _user.CreateNewRandomUser();
            Debug.Print($"Name: {newUser.Name}\n Age: {newUser.Age}\n Salary: {newUser.Salary}$");
            Assert.IsTrue(newUser.Age > 0 && newUser.Salary > 0 && !newUser.Name.Equals("Name"));
        }

        [TestMethod]
        public void Test_User_CreateNewRandom_Equals()
        {
            User expected = _user.CreateNewRandomUser();
            User actual = _user.CreateNewRandomUser();
            Assert.IsTrue(!expected.Equals(actual));
        }

        [TestMethod]
        public void Test_User_Equals_Works()
        {
            var Id = Guid.NewGuid();
            User expected = new User() {Name = "Name", Age = 18, Salary = 20.00, Surname = "Sname", Id = Id};
            User actual = new User() {Name = "Name", Age = 18, Salary = 20.00, Surname = "Sname", Id = Id};
            Assert.IsTrue(expected.Equals(actual));
        }

        
}
}
