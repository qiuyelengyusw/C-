namespace 方法复习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Add(1, 2)); //静态方法调用           
            Program Addone = new Program(); //非静态方法调用
            Console.WriteLine(Addone.Add1(1, 2)); //非静态方法调用
            Console.ReadKey();
            Program.Print(); //静态方法调用
            Console.ReadKey();
            Addone.Print1(); //非静态方法调用
            Console.ReadKey();
            Console.WriteLine(Max(5, 6));
            Console.ReadKey();
            Console.WriteLine(Addone.Max1(50, 60));
            Console.ReadKey();                            
            Console.WriteLine(Test(3));
            Console.ReadKey();
        }
        /// <summary>
        /// 计算两个整数的和，静态方法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>求两个整数的和</returns>
        public static int Add(int a, int b) //静态方法
        {
            return a + b;
        }
        /// <summary>
        /// 计算两个整数的和，非静态方法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>计算两个整数的和</returns>
        public int Add1(int a, int b) //非静态方法
        {
            return a + b;
        }
        /// <summary>
        /// 打印,静态方法
        /// </summary>
        public static void Print() //静态方法
        {
            Console.WriteLine("静态方法");
        }
        /// <summary>
        /// 打印,非静态方法
        /// </summary>
        public void Print1() //非静态方法
        {
            Console.WriteLine("非静态方法");
        }
        /// <summary>
        /// 静态方法，求两个整数的最大值
        public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        /// <summary>
        /// 非静态方法，求两个整数的最大值
        public int Max1(int a, int b)
        {
            return a > b ? a : b;
        }
        public static int Test(int a) //静态方法,值传递   
        {
           return a = a + 5; //a=8
        }
    }
}
