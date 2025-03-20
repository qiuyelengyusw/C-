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
<<<<<<< HEAD

        /// <summary>
        /// 判断是否是闰年
        /// </summary>
        /// <param name="year"></param>
        /// <returns>返回布尔值</returns>
=======
        
        
>>>>>>> origin/master
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
