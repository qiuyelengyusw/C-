using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 进程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buta_Click(object sender, EventArgs e)
        {
           
        }

        private void buta_Click_1(object sender, EventArgs e)
        {
            //Process.Start("calc");//打开计算器
            Process.Start("iexplore","http://www.baidu.com"); //打开浏览器
            //Process.Start("notepad");
        }

        private void but2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "打开文件";
            ofd.InitialDirectory = @"E:\";
            ofd.Filter = "文本文件|*.txt|所有文件|*.*";
            ofd.ShowDialog();
            string path=ofd.FileName;
            if(path=="")
            {
                return;
            }
            ProcessStartInfo processStartInfo = new ProcessStartInfo(path);
            //创建进程对象
            Process p = new Process();
            p.StartInfo = processStartInfo;
            p.Start();  
        }
    }
}
