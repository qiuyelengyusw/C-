using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 打开及保存文件对话框
{
    public partial class frma : Form
    {
        public frma()
        {
            InitializeComponent();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); //弹出打开文件对话框
            ofd.Title = "请选择要打开的文本文件";    //设置对话框的标题
            ofd.Multiselect = true; //设置对话框是否可以多选
            ofd.InitialDirectory = @"E:\";    //设置对话框的初始目录
            ofd.Filter = "文本文件|*.txt";     //设置对话框的文件类型            
            ofd.ShowDialog(); //显示对话框           
            string path = ofd.FileName;  //获取再打开对话框中选中的文件的路径
            if (path == "")
            {
                MessageBox.Show("请正确选择文件");
                return;
            }
            using (FileStream fsread = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsread.Read(buffer, 0, buffer.Length);
                txta.Text = Encoding.Default.GetString(buffer, 0, r);
                fsread.Close();
                fsread.Dispose();
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //这是最彻底的退出方式，不管什么线程都被强制退出，把程序结束的很干净。 参数0：代表程序正常退出；参数1：代表程序非正常退出。
            System.Environment.Exit(0); 
            //this.Close();//关闭窗体
            //this.Dispose();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fssave = new SaveFileDialog();
            fssave.Title = "保存文件";
            fssave.InitialDirectory = @"E\";
            fssave.Filter = "文本文件|*.txt";
            fssave.ShowDialog();
            string path = fssave.FileName;
            if (path == "")
            {
                MessageBox.Show("文件名不能为空");
                return;
            }
            using (FileStream fswrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(txta.Text);
                fswrite.Write(buffer, 0, buffer.Length);
                fswrite.Close();
                fswrite.Dispose();
            }
            MessageBox.Show("文件保存成功");
        }
    }
}
