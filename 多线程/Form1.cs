using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多线程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Test()
        {
            for (int i = 0; i < 100000; i++) 
            {
                Console.WriteLine(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //创建一个线程去执行这个方法
            Thread th=new Thread(new ThreadStart(Test));  
            //标记这个线程已经准备就绪，可以随时运行
            //具体什么时候执行这个线程，由CPU决定
            th.Start();
        }
    }
    
}
