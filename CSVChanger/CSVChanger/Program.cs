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
        public static void FileStreamChange()
        {
            string source = "{计算方法  运筹学  } 30  \n{计算方法} 30        ";
            string result = null;
            MatchCollection Matches = Regex.Matches(source, @"\{(\s*\S*\s*)*\}\s*\d*\s*\n?");
            foreach (Match NextMatch in Matches)
            {
                result += NextMatch.Groups[0].Value;
               // result += NextMatch.Value;
            }
            MessageBox.Show(result);
        }
    }
}
