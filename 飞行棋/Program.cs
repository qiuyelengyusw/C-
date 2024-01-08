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
        //声明一个静态字段，存储玩家姓名
        public static string[] PlayerNames = new string[2];
        //声明一个静态数组保存玩家的状态，默认是false
        public static bool[] Flags = new bool[2];
        static void Main(string[] args)
        {
            GameShow();
            #region 输入玩家姓名
            Console.WriteLine("请输入玩家A的姓名:");
            PlayerNames[0] = Console.ReadLine();
            while (PlayerNames[0] == "")
            {
                Console.WriteLine("玩家的姓名不能为空！请重新输入:");
                PlayerNames[1] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名:");
            PlayerNames[1] = Console.ReadLine();
            while (PlayerNames[1] == "" || PlayerNames[0] == PlayerNames[1])
            {
                if (PlayerNames[1] == "")
                {
                    Console.WriteLine("玩家的姓名不能为空！请重新输入:");
                }
                else
                {
                    Console.WriteLine("玩家的姓名不能相同!请重新输入:");
                }
                PlayerNames[1] = Console.ReadLine();
            }
            #endregion
            //玩家姓名输入完毕后，先清空屏幕
            Console.Clear();
            //重新调用游戏头
            GameShow();
            Console.WriteLine("{0}的士兵用A来表示", PlayerNames[0]);
            Console.WriteLine("{0}的士兵应B来表示", PlayerNames[1]);
            //初始化地图
            InitailMap();
            //画地图
            DrawMaps();
            //如果玩家A与玩家B都不在终点的时候，游戏才可以进行
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
                if (PlayerPos[0]>=99)
                {
                    Console.WriteLine("玩家{0}无耻的赢了玩家{1}", PlayerNames[0], PlayerNames[1]);
                    Win();
                    break;
                }
                Console.Clear();
                GameShow();
                InitailMap();
                DrawMaps();                
                if (Flags[1] == false)
                {
                    PlayGame(1);
                }
                else
                {
                    Flags[1] = false;
                }
                if (PlayerPos[1]>=99)
                {
                    Console.WriteLine("玩家{0}无耻的赢了玩家{1}", PlayerNames[1], PlayerNames[0]);
                    Win();
                    break;
                }
                Console.Clear();
                GameShow();
                InitailMap();
                DrawMaps();
            }
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
        /// <summary>
        /// 玩游戏
        /// </summary>
        /// <param name="playernumber"></param>
        public static void PlayGame(int playernumber)
        {
            Random r = new Random();
            int rNumber = r.Next(1, 7);
            Console.WriteLine("{0}开始掷骰子", PlayerNames[playernumber]);
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}掷出了{1}", PlayerNames[playernumber], rNumber);
            PlayerPos[playernumber] += rNumber;
            //调用方法判断玩家坐标是否在地图范围之内
            ChangePos();
            Console.ReadKey(true);
            Console.WriteLine("{0}按任意键开始行动", PlayerNames[playernumber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}行动完了", PlayerNames[playernumber]);
            Console.ReadKey(true);
            //下面的代码判断玩家A踩到玩家B，踩到方块，踩到幸运轮盘、地雷、暂停、或者时空隧道的情况
            if (PlayerPos[playernumber] == PlayerPos[1 - playernumber])
            {
                Console.WriteLine("玩家{0}踩到了玩家{1},玩家{2}退6格", PlayerNames[playernumber], PlayerNames[1 - playernumber], PlayerNames[1 - playernumber]);
                PlayerPos[1 - playernumber] -= 6;
                Console.ReadKey(true);
            }
            else //踩到关卡
            {
                switch (Maps[PlayerPos[playernumber]])
                {
                    case 0:
                        Console.WriteLine("玩家{0}踩到了方块，安全", PlayerNames[playernumber]);
                        Console.ReadKey(true);
                        break;
                    case 1:
                        Console.WriteLine("玩家{0}踩到的幸运轮盘，请选择1--交换位置 2--轰炸对方", PlayerNames[playernumber);
                        string strInput = Console.ReadLine();
                        while (strInput != "1" && strInput != "2")
                        {
                            Console.WriteLine("只能输入数字1或者2，请重新输入：");
                            strInput = Console.ReadLine();
                        }
                        if (strInput == "1")  //选择交换位置
                        {
                            Console.WriteLine("玩家{0}选择与玩家{1}交换位置", PlayerNames[playernumber], PlayerNames[1 - playernumber]);
                            Console.ReadKey(true);
                            int temp = PlayerPos[playernumber];
                            PlayerPos[playernumber] = PlayerPos[1 - playernumber];
                            PlayerPos[1 - playernumber] = temp;
                            Console.WriteLine("位置交换完成！按任意键继续游戏！");
                            Console.ReadKey(true);
                        }
                        else  //选择轰炸对方
                        {
                            Console.WriteLine("玩家{0}选择轰炸玩家{1},玩家{2}后退6格", PlayerNames[playernumber], PlayerNames[1 - playernumber], PlayerNames[1 - playernumber]);
                            Console.ReadKey(true);
                            PlayerPos[1 - playernumber] -= 6;
                            ChangePos();
                            Console.WriteLine("玩家{0}退了6格", PlayerNames[1 - playernumber]);
                            Console.ReadKey(true);
                        }
                        break;
                    case 2:
                        Console.WriteLine("玩家{0}踩到了地雷，后退6格", PlayerNames[playernumber]);
                        Console.ReadKey(true);
                        PlayerPos[playernumber] -= 6;
                        ChangePos();
                        Console.ReadKey(true);
                        break;
                    case 3:
                        Console.WriteLine("玩家{0}踩到了暂停,暂停一回合", PlayerNames[playernumber]);
                        Flags[playernumber] = true;
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.WriteLine("玩家{0}踩到了时空隧道，前进10格", PlayerNames[playernumber]);
                        PlayerPos[playernumber] += 10;
                        ChangePos();
                        Console.ReadKey(true);
                        break;
                }
            }
            Console.Clear();
            DrawMaps();
        }
        /// <summary>
        /// 当玩家坐标发生变化的是后调用，防止玩家坐标超出地图范围
        /// </summary>
        public static void ChangePos()
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
            Console.WriteLine("                                     ◆                            ■ ");
            Console.WriteLine("                  ■                ◆                  ■           ■ ");
            Console.WriteLine("      ■■■■ ■   ■  ■              ◆  ■            ■    ■           ■");
            Console.WriteLine("      ■    ■  ■   ■            ◆    ■            ■    ■           ■ ");
            Console.WriteLine("      ■    ■ ■■■■■■■■■■■■     ■■■■■■■■■■■■       ■    ■           ■ ");
            Console.WriteLine("      ■■■■ ■      ■                 ●■●          ■    ■           ■");
            Console.WriteLine("      ■    ■      ■                ● ■ ●         ■    ■           ■");
            Console.WriteLine("      ■    ■ ■■■■■■■■■■■■●        ●  ■   ●       ■    ■           ■ ");
            Console.WriteLine("      ■■■■ ■      ■             ●    ■     ●     ■    ■           ■");
            Console.WriteLine("      ■    ■      ■           ●      ■       ●   ■    ■           ■");
            Console.WriteLine("      ■    ■      ■         ●        ■           ■    ■           ■ ");
            Console.WriteLine("     ■     ■      ■                  ■             ●  ■           ■ ");
            Console.WriteLine("    ■    ■■ ■■■■■■■■■■■■■■           ■                ●           ●");
            Console.ResetColor();
        }
    }
}
