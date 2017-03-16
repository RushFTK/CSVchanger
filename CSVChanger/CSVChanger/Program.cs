using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using System.IO;

namespace CSVChanger
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Sub_Functions
    {
        public static void FileStreamChange(String Src_Path,String Aim_Path)
        {
            StreamReader sr1 = new StreamReader(Src_Path);
            string str = null;                      //临时存储读取结果
            string temp = null;
            string result = null;
            Regex reg = new Regex(@"[\u4e00-\u9fa5]+|\d+");        //正则匹配公式 整型数字，用于提取流中数字
            MatchCollection mcs;                    //存储匹配结果
            while (true)
            {
                str = sr1.ReadLine();
                if (str == null) break;
                mcs = reg.Matches(str);
                foreach (Match mc in mcs)               //对所有匹配结果提取的数值，存入图表中
                {
                    temp = mc.Groups[0].Value;
                    try    //尝试转换
                    {
                        Convert.ToInt32(temp);
                    }
                    catch
                    {
                        result += mc.Groups[0].Value + ",";  //字母换/n
                        continue;
                    }
                    result += mc.Groups[0].Value + "\n";   //数字换行
                }
            }
            System.IO.File.WriteAllText(Aim_Path + "result.csv", result, System.Text.Encoding.UTF8);
            /*string source = "{计算方法  运筹学  } 30  \n{计算方法} 30        ";
            string temp = null;
            string result = null;
            MatchCollection Matches = Regex.Matches(source, @"[\u4e00-\u9fa5]+|\d+");
            foreach (Match NextMatch in Matches)
            {
                temp = NextMatch.Groups[0].Value;
                try
                {
                     Convert.ToInt32(temp);
                }
                catch
                {
                    result += NextMatch.Groups[0].Value + ",";  //字母换/n
                    continue;
                }
                result += NextMatch.Groups[0].Value+"\n";   //数字换行
               // result += NextMatch.Value;
            }
            MessageBox.Show(result);*/
        }
    }
}
