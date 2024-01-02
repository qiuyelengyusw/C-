using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 飞行棋
{
    internal class Program
    {
        public static int[] Maps = new int[100];
        //声明一个静态字段，存储玩家的坐标
        public static int[] PlayerPos = new int[2];
        static void Main(string[] args)
        {
            GameShow();
            InitailMap();
            DrawMaps();
            Console.ReadKey();
        }
        /// <summary>
        /// 画游戏头
        /// </summary>
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("******************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("******************************");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("************飞行旗************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("******************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("******************************");
        }
        /// <summary>
        /// 初始化地图
        /// </summary>
        public static void InitailMap()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 }; //幸运轮盘的下标
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 }; //地雷
            int[] pause = { 9, 27, 60, 93 };//暂停图标所在maps中的下标
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };
            //将Maps[]数组中下标为luckturn[]中的元素中的值赋值为1
            for (int i = 0; i < luckyturn.Length; i++)
            {
                Maps[luckyturn[i]] = 1;
            }
            for (int i = 0; i < landMine.Length; i++)
            {
                Maps[landMine[i]] = 2;
            }
            for (int i = 0; i < pause.Length; i++)
            {
                Maps[pause[i]] = 3;
            }
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                Maps[timeTunnel[i]] = 4;
            }
        }
        /// <summary>
        /// 画图的方法
        /// </summary>
        /// <param name="i"></param>
        public static void DrawStringMap(int i)
        {
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[1] == i)
            {
                //如果玩家A跟玩家B的坐标相同，画一个“$”
                Console.Write(" $ ");
            }
            else if (PlayerPos[0] == i)
            {
                Console.Write("Ａ");
            }
            else if (PlayerPos[1] == i)
            {
                Console.Write("Ｂ");
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" # ");
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" @ ");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" G ");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(" P ");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" T ");
                        break;
                }
            }
        }
        /// <summary>
        /// 画地图
        /// </summary>
        public static void DrawMaps()
        {
            Console.WriteLine("图例:幸运轮盘:@ 地雷:G 暂停:P 时空隧道:T");
            #region 第一横行
            for (int i = 0; i < 30; i++)
            {
                DrawStringMap(i);             
               
            }
            #endregion
            Console.WriteLine();
            #region 第一竖行
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("   ");                   
                }
                DrawStringMap(i);
                Console.WriteLine();
            }
            #endregion
            #region 第二横行
            for (int i = 64; i >= 35; i--)
            {
                DrawStringMap(i);
            }
            #endregion
            Console.WriteLine();
            #region 第二竖行
            for (int i = 65; i <= 69; i++)
            {
                DrawStringMap(i);
                Console.WriteLine();
            }
            #endregion
            #region 第三横行
            for (int i = 70; i < 100; i++)
            {
                DrawStringMap(i);
            }
            Console.WriteLine();
            #endregion
        }
    }
}
