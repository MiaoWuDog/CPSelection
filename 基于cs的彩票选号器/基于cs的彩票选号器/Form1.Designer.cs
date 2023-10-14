namespace 基于cs的彩票选号器
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.giveresult = new Sunny.UI.UIButton();
            this.chooseinputnull = new Sunny.UI.UIButton();
            this.delete = new Sunny.UI.UIButton();
            this.confirmchoose = new Sunny.UI.UIButton();
            this.autochoose = new Sunny.UI.UIButton();
            this.inputchoose = new Sunny.UI.UIButton();
            this.auto = new Sunny.UI.UIButton();
            this.m7 = new Sunny.UI.UITextBox();
            this.m6 = new Sunny.UI.UITextBox();
            this.m5 = new Sunny.UI.UITextBox();
            this.m3 = new Sunny.UI.UITextBox();
            this.m4 = new Sunny.UI.UITextBox();
            this.num = new Sunny.UI.UITextBox();
            this.m2 = new Sunny.UI.UITextBox();
            this.m1 = new Sunny.UI.UITextBox();
            this.allchoose = new Sunny.UI.UIListBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.n6 = new Sunny.UI.UILabel();
            this.n3 = new Sunny.UI.UILabel();
            this.n5 = new Sunny.UI.UILabel();
            this.n7 = new Sunny.UI.UILabel();
            this.n4 = new Sunny.UI.UILabel();
            this.n2 = new Sunny.UI.UILabel();
            this.n1 = new Sunny.UI.UILabel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.min = new Sunny.UI.UIButton();
            this.max = new Sunny.UI.UIButton();
            this.close = new Sunny.UI.UIButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.label2);
            this.uiPanel1.Controls.Add(this.label1);
            this.uiPanel1.Controls.Add(this.autochoose);
            this.uiPanel1.Controls.Add(this.giveresult);
            this.uiPanel1.Controls.Add(this.chooseinputnull);
            this.uiPanel1.Controls.Add(this.delete);
            this.uiPanel1.Controls.Add(this.confirmchoose);
            this.uiPanel1.Controls.Add(this.inputchoose);
            this.uiPanel1.Controls.Add(this.auto);
            this.uiPanel1.Controls.Add(this.m7);
            this.uiPanel1.Controls.Add(this.m6);
            this.uiPanel1.Controls.Add(this.m5);
            this.uiPanel1.Controls.Add(this.m3);
            this.uiPanel1.Controls.Add(this.m4);
            this.uiPanel1.Controls.Add(this.num);
            this.uiPanel1.Controls.Add(this.m2);
            this.uiPanel1.Controls.Add(this.m1);
            this.uiPanel1.Controls.Add(this.allchoose);
            this.uiPanel1.Controls.Add(this.uiLabel8);
            this.uiPanel1.Controls.Add(this.n6);
            this.uiPanel1.Controls.Add(this.n3);
            this.uiPanel1.Controls.Add(this.n5);
            this.uiPanel1.Controls.Add(this.n7);
            this.uiPanel1.Controls.Add(this.n4);
            this.uiPanel1.Controls.Add(this.n2);
            this.uiPanel1.Controls.Add(this.n1);
            this.uiPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(6, 42);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(634, 358);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(323, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "个数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(323, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "随机";
            // 
            // giveresult
            // 
            this.giveresult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giveresult.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.giveresult.Location = new System.Drawing.Point(520, 247);
            this.giveresult.MinimumSize = new System.Drawing.Size(1, 1);
            this.giveresult.Name = "giveresult";
            this.giveresult.Size = new System.Drawing.Size(90, 87);
            this.giveresult.TabIndex = 5;
            this.giveresult.Text = "打印票据";
            this.giveresult.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // chooseinputnull
            // 
            this.chooseinputnull.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseinputnull.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chooseinputnull.Location = new System.Drawing.Point(422, 299);
            this.chooseinputnull.MinimumSize = new System.Drawing.Size(1, 1);
            this.chooseinputnull.Name = "chooseinputnull";
            this.chooseinputnull.Size = new System.Drawing.Size(90, 35);
            this.chooseinputnull.TabIndex = 4;
            this.chooseinputnull.Text = "清空选择";
            this.chooseinputnull.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chooseinputnull.Click += new System.EventHandler(this.chooseinputnull_Click);
            // 
            // delete
            // 
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delete.Location = new System.Drawing.Point(324, 299);
            this.delete.MinimumSize = new System.Drawing.Size(1, 1);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(90, 35);
            this.delete.TabIndex = 4;
            this.delete.Text = "删除已选";
            this.delete.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // confirmchoose
            // 
            this.confirmchoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmchoose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmchoose.Location = new System.Drawing.Point(422, 247);
            this.confirmchoose.MinimumSize = new System.Drawing.Size(1, 1);
            this.confirmchoose.Name = "confirmchoose";
            this.confirmchoose.Size = new System.Drawing.Size(90, 35);
            this.confirmchoose.TabIndex = 4;
            this.confirmchoose.Text = "确认选择";
            this.confirmchoose.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmchoose.Click += new System.EventHandler(this.confirmchoose_Click);
            // 
            // autochoose
            // 
            this.autochoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autochoose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.autochoose.Location = new System.Drawing.Point(422, 196);
            this.autochoose.MinimumSize = new System.Drawing.Size(1, 1);
            this.autochoose.Name = "autochoose";
            this.autochoose.Size = new System.Drawing.Size(90, 35);
            this.autochoose.TabIndex = 4;
            this.autochoose.Text = "随机多选";
            this.autochoose.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.autochoose.Click += new System.EventHandler(this.autochoose_Click);
            // 
            // inputchoose
            // 
            this.inputchoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputchoose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputchoose.Location = new System.Drawing.Point(518, 195);
            this.inputchoose.MinimumSize = new System.Drawing.Size(1, 1);
            this.inputchoose.Name = "inputchoose";
            this.inputchoose.Size = new System.Drawing.Size(90, 35);
            this.inputchoose.TabIndex = 4;
            this.inputchoose.Text = "填写选择";
            this.inputchoose.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputchoose.Click += new System.EventHandler(this.inputchoose_Click);
            // 
            // auto
            // 
            this.auto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.auto.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.auto.Location = new System.Drawing.Point(326, 247);
            this.auto.MinimumSize = new System.Drawing.Size(1, 1);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(90, 35);
            this.auto.TabIndex = 4;
            this.auto.Text = "随机单选";
            this.auto.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.auto.Click += new System.EventHandler(this.auto_Click);
            // 
            // m7
            // 
            this.m7.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.m7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m7.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m7.Location = new System.Drawing.Point(579, 137);
            this.m7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m7.MinimumSize = new System.Drawing.Size(1, 16);
            this.m7.Name = "m7";
            this.m7.Padding = new System.Windows.Forms.Padding(5);
            this.m7.ShowText = false;
            this.m7.Size = new System.Drawing.Size(29, 36);
            this.m7.TabIndex = 3;
            this.m7.Text = "0";
            this.m7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.m7.Watermark = "";
            // 
            // m6
            // 
            this.m6.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.m6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m6.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m6.Location = new System.Drawing.Point(507, 137);
            this.m6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m6.MinimumSize = new System.Drawing.Size(1, 16);
            this.m6.Name = "m6";
            this.m6.Padding = new System.Windows.Forms.Padding(5);
            this.m6.ShowText = false;
            this.m6.Size = new System.Drawing.Size(29, 36);
            this.m6.TabIndex = 3;
            this.m6.Text = "0";
            this.m6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.m6.Watermark = "";
            // 
            // m5
            // 
            this.m5.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.m5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m5.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m5.Location = new System.Drawing.Point(470, 137);
            this.m5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m5.MinimumSize = new System.Drawing.Size(1, 16);
            this.m5.Name = "m5";
            this.m5.Padding = new System.Windows.Forms.Padding(5);
            this.m5.ShowText = false;
            this.m5.Size = new System.Drawing.Size(29, 36);
            this.m5.TabIndex = 3;
            this.m5.Text = "0";
            this.m5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.m5.Watermark = "";
            // 
            // m3
            // 
            this.m3.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.m3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m3.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m3.Location = new System.Drawing.Point(398, 137);
            this.m3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m3.MinimumSize = new System.Drawing.Size(1, 16);
            this.m3.Name = "m3";
            this.m3.Padding = new System.Windows.Forms.Padding(5);
            this.m3.ShowText = false;
            this.m3.Size = new System.Drawing.Size(29, 36);
            this.m3.TabIndex = 3;
            this.m3.Text = "0";
            this.m3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.m3.Watermark = "";
            // 
            // m4
            // 
            this.m4.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.m4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m4.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m4.Location = new System.Drawing.Point(435, 137);
            this.m4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m4.MinimumSize = new System.Drawing.Size(1, 16);
            this.m4.Name = "m4";
            this.m4.Padding = new System.Windows.Forms.Padding(5);
            this.m4.ShowText = false;
            this.m4.Size = new System.Drawing.Size(29, 36);
            this.m4.TabIndex = 3;
            this.m4.Text = "0";
            this.m4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.m4.Watermark = "";
            // 
            // num
            // 
            this.num.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.num.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num.DoubleValue = 5D;
            this.num.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num.IntValue = 5;
            this.num.Location = new System.Drawing.Point(372, 195);
            this.num.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num.MinimumSize = new System.Drawing.Size(1, 16);
            this.num.Name = "num";
            this.num.Padding = new System.Windows.Forms.Padding(5);
            this.num.ShowText = false;
            this.num.Size = new System.Drawing.Size(41, 36);
            this.num.TabIndex = 3;
            this.num.Text = "5";
            this.num.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.num.Watermark = "";
            // 
            // m2
            // 
            this.m2.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.m2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m2.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m2.Location = new System.Drawing.Point(361, 137);
            this.m2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m2.MinimumSize = new System.Drawing.Size(1, 16);
            this.m2.Name = "m2";
            this.m2.Padding = new System.Windows.Forms.Padding(5);
            this.m2.ShowText = false;
            this.m2.Size = new System.Drawing.Size(29, 36);
            this.m2.TabIndex = 3;
            this.m2.Text = "0";
            this.m2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.m2.Watermark = "";
            // 
            // m1
            // 
            this.m1.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.m1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m1.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m1.Location = new System.Drawing.Point(324, 137);
            this.m1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m1.MinimumSize = new System.Drawing.Size(1, 16);
            this.m1.Name = "m1";
            this.m1.Padding = new System.Windows.Forms.Padding(5);
            this.m1.ShowText = false;
            this.m1.Size = new System.Drawing.Size(29, 36);
            this.m1.TabIndex = 3;
            this.m1.Text = "0";
            this.m1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.m1.Watermark = "";
            // 
            // allchoose
            // 
            this.allchoose.FillColor = System.Drawing.Color.White;
            this.allchoose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.allchoose.Location = new System.Drawing.Point(17, 128);
            this.allchoose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allchoose.MinimumSize = new System.Drawing.Size(1, 1);
            this.allchoose.Name = "allchoose";
            this.allchoose.Padding = new System.Windows.Forms.Padding(2);
            this.allchoose.ShowText = false;
            this.allchoose.Size = new System.Drawing.Size(290, 206);
            this.allchoose.TabIndex = 2;
            this.allchoose.Text = "uiListBox1";
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("仿宋", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.Location = new System.Drawing.Point(-13, 0);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(210, 46);
            this.uiLabel8.TabIndex = 1;
            this.uiLabel8.Text = "6+1选号器";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // n6
            // 
            this.n6.Font = new System.Drawing.Font("黑体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.n6.Location = new System.Drawing.Point(264, 55);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(40, 43);
            this.n6.TabIndex = 0;
            this.n6.Text = "0";
            this.n6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // n3
            // 
            this.n3.Font = new System.Drawing.Font("黑体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.n3.Location = new System.Drawing.Point(126, 55);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(40, 43);
            this.n3.TabIndex = 0;
            this.n3.Text = "0";
            this.n3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // n5
            // 
            this.n5.Font = new System.Drawing.Font("黑体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.n5.Location = new System.Drawing.Point(218, 55);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(40, 43);
            this.n5.TabIndex = 0;
            this.n5.Text = "0";
            this.n5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.n7.Font = new System.Drawing.Font("黑体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.n7.Location = new System.Drawing.Point(350, 55);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(40, 43);
            this.n7.TabIndex = 0;
            this.n7.Text = "0";
            this.n7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // n4
            // 
            this.n4.Font = new System.Drawing.Font("黑体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.n4.Location = new System.Drawing.Point(172, 55);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(40, 43);
            this.n4.TabIndex = 0;
            this.n4.Text = "0";
            this.n4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // n2
            // 
            this.n2.Font = new System.Drawing.Font("黑体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.n2.Location = new System.Drawing.Point(80, 55);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(40, 43);
            this.n2.TabIndex = 0;
            this.n2.Text = "0";
            this.n2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // n1
            // 
            this.n1.Font = new System.Drawing.Font("黑体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.n1.Location = new System.Drawing.Point(34, 55);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(40, 43);
            this.n1.TabIndex = 0;
            this.n1.Text = "0";
            this.n1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.min);
            this.uiPanel2.Controls.Add(this.max);
            this.uiPanel2.Controls.Add(this.close);
            this.uiPanel2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel2.Location = new System.Drawing.Point(-3, -3);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(650, 33);
            this.uiPanel2.TabIndex = 0;
            this.uiPanel2.Text = "彩票选号系统";
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.uiPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.uiPanel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            // 
            // min
            // 
            this.min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.min.Location = new System.Drawing.Point(461, 1);
            this.min.MinimumSize = new System.Drawing.Size(1, 1);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(56, 27);
            this.min.TabIndex = 0;
            this.min.Text = "—";
            this.min.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.min.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // max
            // 
            this.max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.max.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.max.Location = new System.Drawing.Point(527, 1);
            this.max.MinimumSize = new System.Drawing.Size(1, 1);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(56, 27);
            this.max.TabIndex = 0;
            this.max.Text = "[]";
            this.max.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.max.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.Location = new System.Drawing.Point(590, 0);
            this.close.MinimumSize = new System.Drawing.Size(1, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(56, 28);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(647, 412);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            this.uiPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIButton close;
        private Sunny.UI.UIButton min;
        private Sunny.UI.UIButton max;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel n6;
        private Sunny.UI.UILabel n3;
        private Sunny.UI.UILabel n5;
        private Sunny.UI.UILabel n7;
        private Sunny.UI.UILabel n4;
        private Sunny.UI.UILabel n2;
        private Sunny.UI.UILabel n1;
        private Sunny.UI.UITextBox m6;
        private Sunny.UI.UITextBox m5;
        private Sunny.UI.UITextBox m3;
        private Sunny.UI.UITextBox m4;
        private Sunny.UI.UITextBox m2;
        private Sunny.UI.UITextBox m1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIButton giveresult;
        private Sunny.UI.UIButton chooseinputnull;
        private Sunny.UI.UIButton delete;
        private Sunny.UI.UIButton confirmchoose;
        private Sunny.UI.UIButton autochoose;
        private Sunny.UI.UIButton inputchoose;
        private Sunny.UI.UIButton auto;
        private Sunny.UI.UITextBox num;
        private Sunny.UI.UITextBox m7;
        private System.Windows.Forms.Timer timer1;
        public Sunny.UI.UIListBox allchoose;
    }
}

