using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform应用
{
    public partial class frma : Form
    {
        public frma()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tima.Stop();  //再窗体初始化得时候，让timer停止
        }
        string stra = "☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★"; //定义一个字符串
        private void tima_Tick(object sender, EventArgs e)
        {           
            stra = stra.Substring(1) + stra.Substring(0, 1);    //将字符串从第二个元素截取，然后将第一个元素连接       
            lbla.Text = stra; //将字符串赋值给lbl
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tima.Start(); //开始
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.tima.Stop();//停止
            this.timb.Stop();            
        }

        private void timb_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            if(DateTime.Now.Hour==18&&DateTime.Now.Minute==06)
            {
                SoundPlayer sp=new SoundPlayer();
                sp.SoundLocation = "1.wav";
                sp.Play();
                tima.Start();
                timb.Stop();
            }
        }
    }
}
