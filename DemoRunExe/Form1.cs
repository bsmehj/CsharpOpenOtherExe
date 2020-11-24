using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DemoRunExe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 目标是实现C#与C++交互式编程
        // 在现有的程序中打开其他的应用程序
        // 方式1
        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("hello C#!");

            Process proc = new Process();

            proc.StartInfo.FileName = "OKW_Prj_Serial.exe";

            proc.StartInfo.UseShellExecute = false;

            proc.StartInfo.RedirectStandardInput = true;

            proc.StartInfo.RedirectStandardOutput = true;

            proc.StartInfo.RedirectStandardError = true;

            proc.StartInfo.CreateNoWindow = true;

            // p.StartInfo.WorkingDirectory = Application.StartupPath + @"\OKW_Prj_Serial.exe";
            proc.StartInfo.WorkingDirectory = Application.StartupPath;
            proc.Start();

            proc.StandardInput.WriteLine("OKW_Prj_Serial.exe");

            proc.StandardInput.WriteLine("exit");

            //             System.Diagnostics.ProcessStartInfo startInfo =
            //                 new System.Diagnostics.ProcessStartInfo();
            //             //startInfo.Arguments = String.Format("{0}  {1}  {2}", columnStr, tempFilePath, "True");
            //             startInfo.FileName = 
            //                 + "\\Excel.exe";
            //             startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            //             System.Diagnostics.Process process = new System.Diagnostics.Process();
            //             process.StartInfo = startInfo;
            //             process.Start();
            //             process.WaitForExit();
            //             process.Close();
        }

        // 方式2
        // 指定待启动应用程序的名称，然后启动设定的进程程序
        private void button2_Click(object sender, EventArgs e)
        {
            string procName = "OKW_Prj_Serial.exe";
            System.Diagnostics.ProcessStartInfo info = 
                new System.Diagnostics.ProcessStartInfo(procName);
            info.WorkingDirectory = System.IO.Path.GetDirectoryName(procName); 
            System.Diagnostics.Process.Start(info);
        }

        // 方式3
        // 直接通过process运行进程程序
        private void button3_Click(object sender, EventArgs e)
        {
            string procName = "OKW_Prj_Serial.exe";
            System.Diagnostics.Process.Start(procName);
        }
    }
}
