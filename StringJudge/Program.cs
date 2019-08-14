using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace StringJudge
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
            try
            {
                #region json序列化
                string sPath = AppDomain.CurrentDomain.BaseDirectory + "Update.json";
                StreamReader file = File.OpenText(sPath);
                JsonTextReader reader = new JsonTextReader(file);
                JObject J = (JObject)JToken.ReadFrom(reader);
                Root root = JsonConvert.DeserializeObject<Root>(J.ToString());
                #endregion

                #region 服务器访问权限
                string str = root.server.credential;
                string[] credential = str.Split(';');
                string pathStr = credential[0];
                string userStr = credential[1];
                string pwdStr = credential[2];
                GetAccess(pathStr, userStr, pwdStr);
                #endregion

                #region 对比版本是否打开升级程序
                FileVersionInfo infoServer = FileVersionInfo.GetVersionInfo(root.server.program);
                string local_program = Process.GetCurrentProcess().MainModule.FileName;
                FileVersionInfo infoLocal = FileVersionInfo.GetVersionInfo(local_program);

                Version versionServer = new Version(infoServer.FileVersion);//服务器版本
                Version versionLocal = new Version(infoLocal.FileVersion);//当前版本
                //Version versionLocal = new Version(Application.ProductVersion);//自身当前版本
                //MessageBox.Show(versionServer + "\r\n" + versionLocal);
                if (infoServer.ProductName == infoLocal.ProductName && versionServer > versionLocal)
                {
                    if (MessageBox.Show("Do you want to upgrade the program?", "Update"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Process.Start("Update.exe", local_program);
                        Environment.Exit(0);
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Upgrade failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Run(new Main());
        }

        static void GetAccess(string path, string user, string pwd)
        {
            Process p = new Process();

            p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");

            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;

            p.Start();
            //DOS语句net use \\DN2PROD12 "19931001" /user:SAEDGO1\R086706
            p.StandardInput.WriteLine(@"net use {0} /del", path); //必须先删除，否则报错
            p.StandardInput.WriteLine(@"net use {0} ""{1}"" /user:{2}", path, pwd, user);
            p.StandardInput.WriteLine("exit"); //如果不加这句WaitForExit会卡住
            p.WaitForExit();
            p.Close();
        }
    }
}