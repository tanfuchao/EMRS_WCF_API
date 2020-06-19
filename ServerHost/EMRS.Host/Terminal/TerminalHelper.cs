using Microsoft.Win32;
using System;

namespace HostStart
{
    public static class TerminalHelper
    {
        public static void StartInputCommand()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("->");
                string cInput = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                if (cInput.Trim().Length > 0)
                {
                    cInput = cInput.Trim();
                    string cKey = "";             // 指令
                    string[] aryParameter = null; // 参数
                    if (cInput.IndexOf(" ") > 0)
                    {
                        cKey = cInput.Substring(0, cInput.IndexOf(" "));
                        aryParameter = cInput.Substring(cInput.IndexOf(" ") + 1).Split(' ');
                    }
                    else
                    {
                        cKey = cInput;
                    }

                    switch (cKey.ToLower())
                    {
                        case "help":
                            Help();
                            break;
                        case "install":
                            if (aryParameter != null && aryParameter.Length > 0)
                            {
                                InstallService(aryParameter);
                            }
                            else
                            {
                                Console.WriteLine("  指令错误、如需帮助请输入help指令");
                            }
                            break;
                        case "uninstall":
                            if (aryParameter != null && aryParameter.Length > 0)
                            {
                                UnInstallService(aryParameter);
                            }
                            else
                            {
                                Console.WriteLine("  指令错误、如需帮助请输入help指令");
                            }
                            break;
                        case "restart":
                            RestartService(aryParameter);
                            break;
                        case "exit":
                            ExitServiceFrame();
                            break;

                        case "autorun":
                            if (aryParameter != null && aryParameter.Length > 0 && (aryParameter[0].ToLower() == "start" || aryParameter[0].ToLower() == "stop"))
                            {
                                AutoRun(aryParameter[0]);
                            }
                            else
                            {
                                Console.WriteLine("  指令错误、如需帮助请输入help指令");
                            }
                            break;
                        default:
                            Console.WriteLine("  指令错误、如需帮助请输入help指令");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("  指令错误、如需帮助请输入help指令");
                }
            }
        }

        public static string PWD { get; set; } // 程序退出加密

        private static void Help()
        {
            Console.WriteLine("  install [ServicePath]  \t附载指定路径下的DLL");
            Console.WriteLine("  uninstall [ServiceName]\t卸载指定的服务");
            Console.WriteLine("  restart                \t重新启动所有服务");
            Console.WriteLine("  restart [ServiceName]  \t重新启动指定服务");
            Console.WriteLine("  exit                   \t退出程序");
            Console.WriteLine("  autoRun [start/stop]   \t自启动");
        }

        #region 附载指定服务
        /// <summary>
        /// 附载指定服务
        /// </summary>
        /// <param name="Parameters">服务路径</param>
        /// <returns></returns>
        private static bool InstallService(string[] Parameters)
        {
            bool bResult = false;
            for (int i = 0; i < Parameters.Length; i++)
            {
                if (ServiceHelper.TaskService(Parameters[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("【Done】" + Parameters[i] + "附载成功");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("【Fail】" + Parameters[i] + "附载失败");
                }
            }
            return bResult;
        }
        #endregion

        #region 卸载指定服务
        /// <summary>
        /// 卸载指定服务
        /// </summary>
        /// <param name="Parameters">服务名称</param>
        /// <returns></returns>
        private static void UnInstallService(string[] Parameters)
        {
            if (Parameters != null && Parameters.Length > 0)
            {
                for (int i = 0; i < Parameters.Length; i++)
                {
                    try
                    {
                        if (!string.IsNullOrWhiteSpace(Parameters[i]))
                        {
                            ServiceHelper.UnInstallService(Parameters[i]);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\r\n  【Error】卸载" + Parameters[i] + "异常");
                        //LogHelper.WriteLog("卸载" + Parameters[i] + "异常:" + ex.Message);
                    }
                }
            }
        }
        #endregion

        #region 重启服务
        /// <summary>
        /// 重启服务
        /// </summary>
        /// <param name="parameters">服务名称</param>
        /// <returns></returns>
        private static bool RestartService(string[] parameters)
        {
            bool bResult = false;
            if (parameters == null || parameters.Length <= 0)
            {
                ServiceHelper.ResetAllService();
            }
            else
            {
                // 启动指定服务
                for (int i = 0; i < parameters.Length; i++)
                {

                }
            }
            return bResult;
        }
        #endregion

        #region 结束程序
        private static void ExitServiceFrame()
        {
            if (!string.IsNullOrWhiteSpace(PWD))
            {
                while (true)
                {
                    Console.Write("  请输入密码：");
                    string key = Console.ReadLine();
                    if (key == PWD)
                    {
                        break;
                    }
                    if (key.ToLower() == "q")
                    {
                        return;
                    }
                }
            }
            Console.Write("  是否确认退出服务？-----Y/N\t");
            if (Console.ReadLine().Trim().ToLower() == "y")
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }
        #endregion

        #region 开机自启动
        private static void AutoRun(string state)
        {
            string key = "XFundService";
            string value = System.Environment.CurrentDirectory + "\\CBFund_Shell.exe";

            try
            {
                RegistryKey HKLM = Registry.LocalMachine;
                RegistryKey Run = HKLM.CreateSubKey(@"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\");
                RegistryKey XFund = HKLM.OpenSubKey(@"SOFTWARE\Trumgu\XFund", true);

                if (XFund == null)
                {
                    XFund = HKLM.CreateSubKey(@"SOFTWARE\Trumgu\XFund");
                }

                if (state.ToLower() == "start")
                {
                    XFund.SetValue("Path", System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                    Run.SetValue(key, value);
                    Console.WriteLine("  自启动已开启！");
                }
                else
                {
                    XFund.DeleteValue("Path");
                    Run.DeleteValue(key);
                    Console.WriteLine("  自启动已关闭！");
                }
                HKLM.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("  自启动异常:" + ex.Message);
            }
        }
        #endregion
    }
}
