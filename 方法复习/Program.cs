namespace 方法复习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Add(1, 2));   
            Console.ReadKey();  
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
