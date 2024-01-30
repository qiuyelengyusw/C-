using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 移动按钮
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            int dblx=this.ClientSize.Width-butA.ClientSize.Width; //按钮移动的最大宽度是工作区的宽度减去按钮的宽度
            int dbly=this.ClientSize.Height-butA.ClientSize.Height; //按钮移动的最大高度是工作区的高度减去按钮的高度
            Random random = new Random();
            butA.Location = new Point(random.Next(0,dblx+1),random.Next(0,dbly+1)); //给按钮一个新的坐标
        }
    }
}
