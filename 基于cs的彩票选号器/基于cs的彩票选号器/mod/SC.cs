
using System;
using System.Collections.Generic;

namespace 基于cs的彩票选号器
{

    public class SC

    //选号功能类
    {
         // 创建 Form1 的实例

        private Random arandom = new Random();
       
        //属性
        public List<string[]> choose { get; set; }
        //建立一个集合 保存所有选择的完整号码 以一个数一个数的形式保存 还需转换
        public SC()
        //构造方法开头初始化数组
        {
            choose = new List<string[]>();
        }
        /// <summary>
        /// 生成7个随机号码
        /// </summary>
        /// <returns></returns>
        public string[] RandomNumber()
        {

            string[] randomlist = new string[7];
            for (int i = 0; i < 7; i++)
            {
                randomlist[i] = arandom.Next(0, 10).ToString();
            }
            //随机数
            return randomlist;
        }
        /// <summary>
        /// 生成制定组数
        /// </summary>
        /// <param name="count"></param>
        public void groupsc(int count)
        {
            choose.Clear();
            for (int i = 0; i < count; i++)
            {
                choose.Add(RandomNumber());
                //choose集合里添加randomnumber生成的7位数号码数组
            }
        }

        


        /// <summary>
        /// 获取标准规格的显示
        /// </summary>
        /// <returns></returns>
        public List<string> GetPrintNumber()
        {
            List<string> allNumber = new List<string>();
            for (int i = 0; i < choose.Count; i++)
            {
                string aPrintNumber = string.Empty;
                if (i < 9)
                {

                    aPrintNumber = "序号0" + (i + 1) + "号码是";
                }
                else { aPrintNumber = "序号" + (i + 1) + "号码是"; }
                for (int a = 0; a < choose[i].Length; a++)
                {

                    if (a == 5)
                    {

                        aPrintNumber += choose[i][a] + "   ";
                    }
                    else
                    {
                        aPrintNumber += choose[i][a] + " ";
                    }

                    
                }
                allNumber.Add(aPrintNumber);
            }
            return allNumber;
        }


        }


       
    }
