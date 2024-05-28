using Challenge_ihoo;
namespace Challenge_ihoo_tests
{
    public class Tests
    {

        public void TestingUserLogin()
        {
            // arrange
            var user1 = new User("Daniel", "Pass738");

            // act
            var result = user1.login;

            // assert
            Assert.AreEqual("Daniel", result);
            //Assert.AreEqual("Daniel", result);
        }
    }
}