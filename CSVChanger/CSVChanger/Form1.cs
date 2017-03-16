using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CSVChanger.Sub_Functions;

namespace CSVChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BeginChange_Click(object sender, EventArgs e)
        {
            //从Text控件获取数据
            String Path_Src = this.SrcPath.Text;
            String Path_Dest = this.DestPath.Text;
            //          MessageBox.Show("源：" + Path_Src + "\n目标文件" + Path_Dest);
            FileStreamChange();

            try
            {
                
            }
            catch (Exception errorcode)
            {
                MessageBox.Show("转换失败，错误："+ errorcode);
            }

        }

        private void SelectSrc_Click(object sender, EventArgs e)
        {
            if(OpenSrcFile.ShowDialog() == DialogResult.OK)
                SrcPath.Text = OpenSrcFile.FileName; 
        }

        private void SelectDest_Click(object sender, EventArgs e)
        {
            if (OpenDestFile.ShowDialog() == DialogResult.OK)
                DestPath.Text = OpenDestFile.SelectedPath;
        }
    }
}
