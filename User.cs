using Challenge_ihoo_tests;
namespace Challenge_ihoo
{
    internal class User
    {
        private List<int> score = new List<int>();
        public User(String login, String password)
        {
            this.login = login;
            this.password = password;
        }
        public string login { get; private set; }
        public string password { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int number)
        {
            this.score.Add(number);
        }
        public static void Main(string[] args)
        {
            User user1 = new User("Daniel", "Pass738");
            User user2 = new User("Julia", "Pass738");
            List<User> listofUsers = new List<User>()
            {
                user1, user2
            };
            user1.AddScore(5);
            user1.AddScore(2);
            user2.AddScore(2);
            user2.AddScore(8);
            var result1 = user1.Result;
            Console.WriteLine(result1);
            var result2 = user2.Result;
            Console.WriteLine(result2);
            var allScore = result1 + result2;  
        }
    }
}
