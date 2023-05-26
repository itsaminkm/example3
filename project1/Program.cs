// See https://aka.ms/new-console-template for more information

namespace project1
{
    class program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Enter any key to exit");
            Console.ReadKey();
        }
    }
}