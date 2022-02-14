using NUnit.Framework;
using Teenweb;

namespace Teenweb2
{
    public class Tests
    {
        private UserManager userManager = new UserManager("Server=127.0.0.1;Database=TeenwebTest;UID=root;PWD=Plm19941967", "User");

        [SetUp]
        public void Setup()
        {
            userManager.DeleteAll();
        }

        [TearDown]
        public void TearDown()
        {
            userManager.DeleteAll();
        }

        [Test]
        public void TestCreateUser()
        {
            userManager.Create("Liliffe3", "pass3", "Andrei", "Orlov", 24, "USA", "Moscow", "male", "liberal", "katolic", "7999832843", "programer", "Boston", 4, 2, "OK");
            User u = userManager.Get("Liliffe3");
            Assert.AreEqual(u.Name, "Andrei");
        }
    }
}
