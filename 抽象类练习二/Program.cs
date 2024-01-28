using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类练习二
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入笔记本的品牌:");
            string str = Console.ReadLine();
            NoteBook noteBook = GetNoteBook(str);
            noteBook.SayHello();
            Console.ReadKey();
        }
        public static NoteBook GetNoteBook(string str)
        {
            NoteBook nb = null;
            switch (str)
            {
                case "Lenovo":
                    nb = new Lenovo();
                    break;
                case "Hp":
                    nb = new Hp();
                    break;
                case "Acer":
                    nb = new Acer();
                    break;
                case "Dell":
                    nb = new Dell();
                    break;
            }
            return nb;
        }
    }
}
