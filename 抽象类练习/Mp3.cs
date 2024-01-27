using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类练习
{
    internal class Mp3 : MoblesStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3在读取文件");
        }

        public override void Write()
        {
            Console.WriteLine("MP3在写入文件");
        }
        public void PlayMusic()
        {
            Console.WriteLine("MP3在播放音乐");    
        }
    }
}
