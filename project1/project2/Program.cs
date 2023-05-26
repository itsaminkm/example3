// See https://aka.ms/new-console-template for more information
namespace project2
{
    internal class program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("pleas enter your number : ");
            num = int.Parse(Console.ReadLine());
            num *= 3;
            Console.WriteLine(num);
            Console.WriteLine("enter any key to exit");
            Console.ReadKey();
        }
    }
}