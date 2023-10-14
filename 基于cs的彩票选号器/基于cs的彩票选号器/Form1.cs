using LotteryPro;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace 基于cs的彩票选号器
{

    public partial class Form1 : Form
    {
        Fath.BarcodeX barCode = new Fath.BarcodeX();
        private SC sc = new SC();
        public UIListBox list;
        /// <summary>
        /// 清空列表 并且添加list数值
        /// </summary>
        public void Shownumber()
        {
            allchoose.Items.Clear();
            allchoose.Items.AddRange(sc.GetPrintNumber().ToArray());

        }
        public Form1()
        {
            InitializeComponent();

            confirmchoose.Enabled = false;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该选项已被禁用");
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        #region  拖动窗体的实现

        private Point mouseOff;//鼠标移动位置变量
        //鼠标坐标字段
        private bool leftFlag;//标签是否为左键
        //左键判断
        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            //创建时间
            if (e.Button == MouseButtons.Left)
            //如果获取的按钮是左键
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                //给mouseoff附一个值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }
        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }
        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        #endregion

        /// <summary>
        /// 定时随机生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] numlist = sc.RandomNumber();
            n1.Text = numlist[0];
            n2.Text = numlist[1];
            n3.Text = numlist[2];
            n4.Text = numlist[3];
            n5.Text = numlist[4];
            n6.Text = numlist[5];
            n7.Text = numlist[6];

        }

        private void auto_Click(object sender, EventArgs e)
        {
            timer1.Start();

            confirmchoose.Enabled = true;
        }

        private void confirmchoose_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            string[] scnum = { n1.Text, n2.Text, n3.Text, n4.Text, n5.Text, n6.Text, n7.Text };
            sc.choose.Add(scnum);

            Shownumber();
            confirmchoose.Enabled = false;
        }

        private void inputchoose_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            string[] scnum = { m1.Text, m2.Text, m3.Text, m4.Text, m5.Text, m6.Text, m7.Text };
            sc.choose.Add(scnum);

            Shownumber();
        }

        private void autochoose_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sc.groupsc(Convert.ToInt32(num.Text.Trim()));
            Shownumber();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (allchoose.SelectedItems == null || allchoose.Count == 0)
            {
                MessageBox.Show("滚");
            }
            else
            {

                int index = allchoose.SelectedIndex;
                sc.choose.RemoveAt(index);
                Shownumber();
            }
        }

        private void chooseinputnull_Click(object sender, EventArgs e)
        {
            sc.choose.Clear();
            allchoose.Items.Clear();

        }
        /// <summary>
        /// 打印彩票
        /// </summary>
        public void PrintLottery(System.Drawing.Printing.PrintPageEventArgs e, string serialNum, List<string> numList)
        {
            //生成条形码
            barCode.Text = serialNum;//条码数据
            barCode.Symbology = Fath.bcType.Code128;//设置条码格式
            barCode.ShowText = true;//同时显示文本           
            e.Graphics.DrawImage(barCode.Image(240, 50), new Point(20, 5));//画条形码

            //生成票据
            float left = 2; //打印区域的左边界
            float top = 70;//打印区域的上边界
            Font titlefont = new Font("仿宋", 10);//标题字体
            Font font = new Font("仿宋", 8);//内容字体            
            e.Graphics.DrawString("天津百万奖彩票中心", titlefont, Brushes.Blue, left + 20, top, new StringFormat());//打印标题
            //画一条分界线
            Pen pen = new Pen(Color.Green, 1);
            e.Graphics.DrawLine(pen, new Point((int)left - 2, (int)top + 20), new Point((int)left + (int)180, (int)top + 20));

            //循环打印选号
            for (int i = 0; i < numList.Count; i++)
            {
                e.Graphics.DrawString(numList[i], font, Brushes.Blue, left,
                    top + titlefont.GetHeight(e.Graphics) + font.GetHeight(e.Graphics) * i + 12, new StringFormat());
            }

            //画一条分界线           
            float topPoint = titlefont.GetHeight(e.Graphics) + font.GetHeight(e.Graphics) * (numList.Count) + 22;

            e.Graphics.DrawLine(pen, new Point((int)left - 2, (int)top + (int)topPoint),
                new Point((int)left + (int)180, (int)top + (int)topPoint));

            //打印时间
            string time = "购买时间：" + DateTime.Now.ToString("yyy-MM-dd  HH:mm:ss");
            e.Graphics.DrawString(time, font, Brushes.Blue, left, top + titlefont.GetHeight(e.Graphics)
                + font.GetHeight(e.Graphics) * (numList.Count + 1) + 12, new StringFormat());

            //二维码图片left和top坐标
            int qrcodetop = (int)(top + titlefont.GetHeight(e.Graphics) + font.GetHeight(e.Graphics) * (numList.Count + 3) + 12);
            int qrcodeleft = (int)left + 32;

            //生成二维码图片
            // Image bmp = QRcodeCreator.GetQRCodeBmp("http://487487.xyz/" + serialNum);//直接添加流水号，将来从网站直接查询
            Image bmp = QRcodeCreator.GetQRCodeBmp("http://487487.xyz/");
            //打印
            e.Graphics.DrawImage(bmp, new Point(qrcodeleft, qrcodetop));//不同的URL图片大小不同，可以根据需要调整left坐标
            e.Graphics.DrawString("扫描二维码可直接查询兑奖结果", font, Brushes.Blue, left, qrcodetop + bmp.Height + 10, new StringFormat());
        }
       
        private void LotteryPrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string serialNum = DateTime.Now.ToString("yyyyMMddHHmmssms");//流水号（条码使用）
           PrintLottery(e, serialNum, sc.GetPrintNumber());

   

          
        }


    }
}
