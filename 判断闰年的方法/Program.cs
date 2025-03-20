namespace 判断闰年的方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个年份：");
            int year = Convert.ToInt32(Console.ReadLine());
            bool isLeapYear = IsLeapYear(year);
            if (isLeapYear)
            {
                Console.WriteLine("{0}年是闰年",year);
            }
            else
            {
                Console.WriteLine("{0}年不是闰年",year);
            }
            Console.ReadKey();

        }
        
        
        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
