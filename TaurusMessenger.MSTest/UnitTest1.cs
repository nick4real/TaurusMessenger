using TaurusMessengerServer;
using TaurusMessengerServer.Service;

namespace TaurusMessenger.MSTest
{
    [TestClass]
    public class Sqlite
    {
        DatabaseService db = new DatabaseService(new MySqlContext());
        [TestMethod]
        public void GetUser1()
        {
            string arg1 = "niko";
            var user = db.GetUser(arg1);
            Assert.IsTrue(user.Login == arg1);
        }
        [TestMethod]
        public void GetUser2()
        {
            string arg1 = "din";
            var user = db.GetUser(arg1);
            Assert.IsTrue(user.Login == arg1);
        }
        [TestMethod]
        public void GetUser3()
        {
            string arg1 = "pyska";
            var user = db.GetUser(arg1);
            Assert.IsTrue(user.Login == arg1);
        }
        [TestMethod]
        public void GetUser4()
        {
            string arg1 = "exxusio";
            var user = db.GetUser(arg1);
            Assert.IsTrue(user.Login == arg1);
        }
        [TestMethod]
        public void GetUser5()
        {
            string arg1 = "romchik";
            var user = db.GetUser(arg1);
            Assert.IsTrue(user.Login == arg1);
        }
    }
}