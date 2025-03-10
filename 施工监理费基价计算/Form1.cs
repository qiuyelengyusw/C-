using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 施工监理费基价计算
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void txtGczj_KeyPress(object sender, KeyPressEventArgs e) //工程总价文本框按键事件
        {
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46) //判断输入的字符是否为数字
            {
                e.Handled = true; //如果不是，则不处理该事件，即不显示该字符
            }
            if ((int)e.KeyChar == '0')//判断首位是否为零
            {
                if (txtGczj.TextLength <= 0)
                {
                    e.Handled = true;
                    MessageBox.Show("0不能在第一位！");
                }
            }
            if ((int)e.KeyChar == 46)
            {
                if (txtGczj.TextLength <= 0) // //小数点不能在第一位
                {
                    e.Handled = true;
                    MessageBox.Show("小数点不能在第一位！");
                }
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false;
                    bool b2 = false;
                    b1 = float.TryParse(txtGczj.Text, out oldf);
                    b2 = float.TryParse(txtGczj.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                        {
                            e.Handled = true;
                        }
                        else
                        {
                            e.Handled = false;
                        }
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtGczj.Text != "")
            {
                double gczj = double.Parse(txtGczj.Text);
                if (gczj <= 500)
                {
                    txtJlf.Text = (gczj * 0.033).ToString();
                }
                if (gczj > 500 && gczj <= 1000)
                {
                    txtJlf.Text = (16.5 + 0.0272 * (gczj - 500)).ToString();
                }
                if (gczj > 1000 && gczj <= 3000)
                {
                    txtJlf.Text = (30.1 + 0.024 * (gczj - 1000)).ToString();
                }
                if (gczj > 3000 && gczj <= 5000)
                {
                    txtJlf.Text = (78.1 + 0.0214 * (gczj - 3000)).ToString();
                }
                if (gczj > 5000 && gczj <= 8000)
                {
                    txtJlf.Text = (120.8 + 0.0201 * (gczj - 5000)).ToString();
                }
                if (gczj > 8000 && gczj <= 10000)
                {
                    txtJlf.Text = (181 + 0.0188 * (gczj - 8000)).ToString();
                }
                if (gczj > 10000 && gczj < 20000)
                {
                    txtJlf.Text = (218.6 + 0.0175 * (gczj - 10000)).ToString();
                }
                if (gczj == 20000)
                {
                    txtJlf.Text = "393.4";
                }
                if (gczj > 20000 && gczj <= 40000)
                {
                    txtJlf.Text = (393.4 + 0.0157 * (gczj - 20000)).ToString();
                }
            }
        }

        private void Frm1_Load(object sender, EventArgs e)
        {
            //button1.Enabled = false;
        }

        private void butclear_Click(object sender, EventArgs e)
        {
            txtJlf.Text = "";
            txtGczj.Text = "";
            txtZKl.Text = "";
            txtZK.Text = "";
            txtGczj.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtZK_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
            {
                e.Handled = true; //如果不是，则不处理该事件，即不显示该字符
            }
            if ((int)e.KeyChar == '0')//判断首位是否为零
            {
                if (txtZKl.TextLength <= 0)
                {
                    e.Handled = true;
                    MessageBox.Show("0不能在第一位！");
                }
            }
            //if ((int)e.KeyChar == '.')
            //{
            //    e.Handled = true;
            //    MessageBox.Show("不能输入小数点！");
            //} 
            if ((int)e.KeyChar == 46)
            {
                if (txtZKl.TextLength <= 0) // //小数点不能在第一位
                {
                    e.Handled = true;
                    MessageBox.Show("小数点不能在第一位！");
                }
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false;
                    bool b2 = false;
                    b1 = float.TryParse(txtZKl.Text, out oldf);
                    b2 = float.TryParse(txtZKl.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                        {
                            e.Handled = true;
                        }
                        else
                        {
                            e.Handled = false;
                        }
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtJlf.Text == "")
            {
                MessageBox.Show("请先进行折前计算！");
                txtGczj.Focus();  //将光标移至工程总价文本框
            }
            else if (txtZKl.Text == "")
            {
                MessageBox.Show("请输入折扣率！");
                txtZKl.Focus(); //将光标移至折扣率文本框
            }
            else
            {
                double dbla = double.Parse(txtJlf.Text); //将折前监理费转换为double类型
                double inta = double.Parse(txtZKl.Text); //将折扣率转换为double类型
                double dblzk = (dbla * inta) / 100; //计算折扣后的监理费
                txtZK.Text = dblzk.ToString();  // 将折扣后的监理费显示在折扣监理费文本框
            }
        }
    }
}
