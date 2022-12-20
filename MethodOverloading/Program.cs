namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = Methods.Add(0, 1, true);
            Console.WriteLine(answer);
        }
    }
}
