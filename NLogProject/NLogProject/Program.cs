namespace NLogProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition Problem");
            AddNumbers addNumbers = new AddNumbers();
            Console.WriteLine("Result is " + addNumbers.Sum(0, 1));
        }
    }
}