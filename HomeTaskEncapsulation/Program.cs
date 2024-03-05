namespace HomeTaskEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Bakhshalievv","Kamran123",25);
            //user.Age = 25;
            //Console.WriteLine(user.Age);
            Console.WriteLine(user.Name);
            Console.WriteLine(user.Password);
            Console.WriteLine(user.Age);



        }
    }
}
