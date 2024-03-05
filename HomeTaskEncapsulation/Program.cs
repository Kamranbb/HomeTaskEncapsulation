namespace HomeTaskEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            //user.Age = 25;
            //Console.WriteLine(user.Age);
            user.Password = "kamran12";
            Console.WriteLine(user.Password);
        }
    }
}
