using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 飞行棋二
{
    internal class Program
    {
        //用静态字段模拟全局变量。
        static int[] Maps = new int[100];
        //声明一个静态数组存储玩家A玩家B的坐标
        static int[] PlayerPos = new int[2];
        //声明一个静态数组存储玩家的姓名
        static string[] playNames = new string[2];
        //两个玩家的标记
        static bool[] Flags = new bool[2];//Flags[0]玩家一的状态，默认是false,Flags[1]玩家二的状态，默认也是false
        static void Main(string[] args)
        {
            GameShow();
            #region 输入玩家姓名
            Console.WriteLine("请输入玩家A的姓名:");
            playNames[0] = Console.ReadLine();
            while (playNames[0] == "")
            {
                Console.WriteLine("输入错误！玩家A的姓名不能为空！请重新输入:");
                playNames[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名:");
            playNames[1] = Console.ReadLine();
            while (playNames[1] == "" || playNames[1] == playNames[0])
            {
                if (playNames[1] == "")
                {
                    Console.WriteLine("输入错误！玩家B的姓名不能为空！请重新输入:");
                }
                else
                {
                    Console.WriteLine("输入错误！玩家B的姓名不能与玩家A的姓名相同！请重新输入:");
                }
                playNames[1] = Console.ReadLine();
            }
            #endregion 
            //玩家输入姓名后首先清空屏幕
            Console.Clear();
            GameShow();//重新调用游戏头
            Console.WriteLine("{0}的士兵用A来表示", playNames[0]);
            Console.WriteLine("{0}的士兵用B来表示", playNames[1]);
            InitailMap();//清空屏幕后，初始化地图         
            DrawMap();
            //当玩家A与玩家B，没有一个在终点时候,游戏可以玩
            while (PlayerPos[0] < 99 && PlayerPos[1] < 99)
            {
                if (Flags[0] == false)
                {
                    PlayGame(0);
                }
                else
                {
                    Flags[0] = false;
                }
                if (PlayerPos[0] >= 99)
                {
                    Console.WriteLine("玩家{0}无耻的赢了玩家{1}", playNames[0], playNames[1]);
                    Win();                    
                    break;
                }
                Console.Clear();
                GameShow();//重新调用游戏头
                InitailMap();//清空屏幕后，初始化地图         
                DrawMap();
                if (Flags[1] == false)
                {
                    PlayGame(1);
                }
                else
                {
                    Flags[1] = false;
                }
                if (PlayerPos[1] >= 99)
                {
                    Console.WriteLine("玩家{0}无耻的赢了玩家{1}", playNames[1], playNames[0]);
                    Win();                   
                    break;
                }
                Console.Clear();
                GameShow();//重新调用游戏头
                InitailMap();//清空屏幕后，初始化地图         
                DrawMap();
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 输出游戏头部
        /// </summary>
        private static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**************飞行棋***************");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("***********************************");
        }
        /// <summary>
        /// 初始化地图
        /// </summary>
        private static void InitailMap()
        {
            //将Maps数组中的第6,23,40,55,69,83个元素赋值为1，用来代表幸运轮盘
            int[] luckytrun = { 6, 23, 40, 55, 69, 83 };
            for (int i = 0; i < luckytrun.Length; i++)
            {
                Maps[luckytrun[i]] = 1;
            }
            int[] mine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//地雷地图
            for (int i = 0; i < mine.Length; i++)
            {
                Maps[mine[i]] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };//暂停地图
            for (int i = 0; i < pause.Length; i++)
            {
                Maps[pause[i]] = 3;
            }
            int[] tunnel = { 20, 25, 45, 63, 72, 88, 90 };//时空隧道
            for (int i = 0; i < tunnel.Length; i++)
            {
                Maps[tunnel[i]] = 4;
            }
        }
        /// <summary>
        /// 绘制地图
        /// </summary>
        private static void DrawMap()
        {
            Console.WriteLine("图例:幸运轮盘:@ 地雷:G 暂停:P 时空隧道:T");
            #region 第一横行
            for (int i = 0; i < 30; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            Console.WriteLine();
            #region 第一竖行
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(DrawStringMap(i));
                Console.WriteLine();
            }
            #endregion
            #region 第二横行
            for (int i = 64; i >= 35; i--)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            Console.WriteLine();
            #region 第二竖行
            for (int i = 65; i <= 69; i++)
            {
                Console.WriteLine(DrawStringMap(i));
            }
            #endregion
            #region 第三横行
            for (int i = 70; i < 100; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            //画完最后一行，换行
            Console.WriteLine();
        }
        /// <summary>
        /// 画图方法
        /// </summary>
        /// <param name="i">数组元素</param>
        /// <returns></returns>
        private static string DrawStringMap(int i)
        {
            string stra = "";
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[0] == i)//判断玩家A与玩家B的坐标是否相同。并都在地图范围之内
            {
                stra = "$";//如果坐标相同则这个位置的图标为：<>
            }
            else if (PlayerPos[0] == i)
            {
                stra = "A";
            }
            else if (PlayerPos[1] == i)
            {
                stra = "B";
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        stra = "#";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        stra = "@";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        stra = "G";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        stra = "P";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        stra = "T";
                        break;
                }
            }
            return stra;
        }
        /// <summary>
        /// 玩游戏
        /// </summary>
        /// <param name="playernumber"></param>
        private static void PlayGame(int playernumber)
        {
            Random r = new Random();
            int rNumber = r.Next(1, 7);
            Console.WriteLine("{0}按任意键开始掷骰子", playNames[playernumber]);
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}掷出了{1}", playNames[playernumber], rNumber);
            PlayerPos[playernumber] += rNumber;
            ChangeaPos();
            Console.ReadKey(true);
            Console.WriteLine("{0}按任意键开始行动", playNames[playernumber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}行动完了", playNames[playernumber]);
            Console.ReadKey(true);
            //这里判断玩家A踩到了玩家B、方块、幸运轮盘、地雷、暂停、时空隧道
            if (PlayerPos[playernumber] == PlayerPos[1 - playernumber])
            {
                Console.WriteLine("玩家{0}踩到了玩家{1},玩家{2}退6格", playNames[playernumber], playNames[1 - playernumber], playNames[1 - playernumber]);
                PlayerPos[1 - playernumber] -= 6;
                ChangeaPos();
                Console.ReadKey(true);
            }
            else //踩到了关卡
            {
                switch (Maps[PlayerPos[playernumber]])
                {
                    case 0:
                        Console.WriteLine("玩家{0}踩到了方块，安全", playNames[playernumber]);
                        Console.ReadKey(true);
                        break;
                    case 1:
                        Console.WriteLine("玩家{0}踩到了幸运轮盘，请选择1--交换位置 2--轰炸对方", playNames[playernumber]);
                        string strInput = Console.ReadLine();
                        while (strInput != "1" && strInput != "2")
                        {
                            Console.WriteLine("输入错误！只能输入数字1或者2，请重新输入:");
                            strInput = Console.ReadLine();
                        }
                        if (strInput == "1")
                        {
                            Console.WriteLine("玩家{0}选择与玩家{1}交换位置", playNames[playernumber], playNames[1 - playernumber]);
                            Console.ReadKey(true);
                            int temp = PlayerPos[playernumber];
                            PlayerPos[playernumber] = PlayerPos[1 - playernumber];
                            PlayerPos[1 - playernumber] = temp;
                            Console.WriteLine("交换完成！按任意键继续游戏！！");
                            Console.ReadKey(true);
                        }
                        else
                        {
                            Console.WriteLine("玩家{0}选择了轰炸玩家{1},玩家{2}后退6格", playNames[playernumber], playNames[1 - playernumber], playNames[1 - playernumber]);
                            Console.ReadKey(true);
                            PlayerPos[1 - playernumber] -= 6;
                            ChangeaPos();
                            Console.WriteLine("玩家{0}退了6格", playNames[1 - playernumber]);
                            Console.ReadKey(true);
                        }
                        break;
                    case 2:
                        Console.WriteLine("玩家{0}踩到了地雷，后退6格", playNames[playernumber]);
                        Console.ReadKey(true);
                        PlayerPos[playernumber] -= 6;
                        ChangeaPos();
                        Console.ReadKey(true);
                        break;
                    case 3:
                        Console.WriteLine("玩家{0}踩到了暂停,暂停一回合", playNames[playernumber]);
                        Flags[playernumber] = true;
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.WriteLine("玩家{0}踩到了时空隧道，前进10格", playNames[playernumber]);
                        //Console.ReadKey(true);
                        PlayerPos[playernumber] += 10;
                        ChangeaPos();
                        Console.ReadKey(true);
                        break;
                }
            }
            Console.Clear();
            DrawMap();
        }
        /// <summary>
        /// 当玩家坐标发生变化的时候调用，防止玩家坐标超出地图范围
        /// </summary>
        private static void ChangeaPos()
        {
            if (PlayerPos[0] < 0)
            {
                PlayerPos[0] = 0;
            }
            if (PlayerPos[0] >= 99)
            {
                PlayerPos[0] = 99;
            }
            if (PlayerPos[1] < 0)
            {
                PlayerPos[1] = 0;
            }
            if (PlayerPos[1] >= 99)
            {
                PlayerPos[1] = 99;
            }
        }
        public static void Win()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                          ◆                      ");
            Console.WriteLine("                    ■                  ◆               ■        ■");
            Console.WriteLine("      ■■■■  ■  ■                ◆■         ■    ■        ■");
            Console.WriteLine("      ■    ■  ■  ■              ◆  ■         ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■       ■■■■■■■   ■    ■        ■");
            Console.WriteLine("      ■■■■ ■   ■                ●■●       ■    ■        ■");
            Console.WriteLine("      ■    ■      ■               ● ■ ●      ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■         ●  ■  ●     ■    ■        ■");
            Console.WriteLine("      ■■■■      ■             ●   ■   ■    ■    ■        ■");
            Console.WriteLine("      ■    ■      ■            ■    ■         ■    ■        ■");
            Console.WriteLine("      ■    ■      ■                  ■               ■        ■ ");
            Console.WriteLine("     ■     ■      ■                  ■           ●  ■          ");
            Console.WriteLine("    ■    ■■ ■■■■■■             ■              ●         ●");
            Console.ResetColor();
        }
    }

}


