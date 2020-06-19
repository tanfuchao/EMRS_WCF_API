using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HostStart
{
    public static class ServiceHelper
    {
        /// <summary>
        /// 启动成功的服务
        /// </summary>
        public static Hashtable ServiceSuccessTable
        {
            get;
            set;
        }

        /// <summary>
        /// 反射成功的DLL
        /// </summary>
        public static Hashtable AssSuccessTable
        {
            get;
            set;
        }

        #region 启动全部服务 By: @CaiYong
        /// <summary>
        /// 启动服务
        /// </summary>
        public static void RunService()
        {
            ServiceSuccessTable = new Hashtable();
            AssemblyHelper oAssHel = new AssemblyHelper(AppDomain.CurrentDomain.BaseDirectory + "LoadDLL");
            try
            {
                if (oAssHel.LoadAllDll())
                {
                    AssSuccessTable = new Hashtable();
                    List<string> listRemove = new List<string>();
                    foreach (DictionaryEntry de in oAssHel.AssSuccessTable)
                    {
                        if (IsWCFDLL((Assembly)de.Value))
                        {
                            AssSuccessTable.Add(de.Key, de.Value);
                        }
                        else
                        {
                            if (!listRemove.Contains(de.Key.ToString()))
                            {
                                listRemove.Add(de.Key.ToString());
                            }
                        }
                    }
                    #region 移除非WCF DLL
                    if (listRemove.Count > 0)
                    {
                        for (int i = 0; i < listRemove.Count; i++)
                        {
                            foreach (DictionaryEntry de in oAssHel.AssSuccessTable)
                            {
                                if (de.Key.ToString() == listRemove[i])
                                {
                                    Assembly ass = (Assembly)de.Value;
                                }
                            }
                            oAssHel.AssSuccessTable.Remove(listRemove[i]);
                        }
                    }
                    #endregion
                    // 循环遍历启动服务
                    foreach (DictionaryEntry de in AssSuccessTable)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("【Load】");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("启动服务集：" + de.Key.ToString());

                        if (RestartService((Assembly)de.Value))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("【Done】");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("【Fail】");
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("启动服务集：" + de.Key.ToString());
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("【Fail】加载DLL文件失败！");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("【Error】加载DLL文件异常！\r\n\tMessage:" + ex.Message);
            }
        }
        #endregion

        #region 获取服务状态 By: @CaiYong
        /// <summary>
        /// 根据服务名称获取服务状态
        /// </summary>
        /// <param name="ServiceName">服务名称</param>
        /// <returns>true：运行；false：停止</returns>
        public static bool IsServiceRun(string ServiceName)
        {
            bool bResult = false;
            if (!string.IsNullOrWhiteSpace(ServiceName))
            {
                if (ServiceSuccessTable != null
                    && ServiceSuccessTable.ContainsKey(ServiceName.Trim()))
                {
                    ServiceHost sh = (ServiceHost)ServiceSuccessTable[ServiceName.Trim()];
                    if (sh.State == CommunicationState.Opened)  // 服务已启动
                    {
                        bResult = true;
                    }
                }
            }
            return bResult;
        }
        #endregion

        #region 卸载指定服务 By: @CaiYong
        /// <summary>
        /// 根据指定的服务名称卸载服务
        /// </summary>
        /// <param name="ServiceName">服务名称</param>
        /// <returns>true：卸载成功；false：卸载失败</returns>
        public static bool UnInstallService(string ServiceName)
        {
            bool bResult = false;
            if (ServiceSuccessTable != null
                    && ServiceSuccessTable.ContainsKey(ServiceName.Trim()))
            {
                try
                {
                    ServiceHost sh = (ServiceHost)ServiceSuccessTable[ServiceName.Trim()];
                    if (sh.State == CommunicationState.Opened)  // 服务已启动
                    {
                        sh.Close();
                    }
                    ServiceSuccessTable.Remove(ServiceName.Trim());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("【Done】");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("卸载服务：" + ServiceName.Trim());
                    bResult = true;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("【Fail】");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("卸载服务：" + ServiceName.Trim());
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t【Error】" + ex.Message);
                    bResult = false;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("【Fail】");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("卸载服务：" + ServiceName.Trim());
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("【Error】：此服务不存在！");
                bResult = false;
            }
            return bResult;
        }
        #endregion

        #region 重启指定服务 By: @CaiYong
        /// <summary>
        /// 重启指定服务（可根据服务名称在加载的DLL中查询启动）
        /// </summary>
        /// <param name="ServiceName"></param>
        /// <param name="Ass"></param>
        /// <returns></returns>
        public static bool RestartService(Assembly AssServiceObj)
        {
            bool bResult = false;

            try
            {
                if (AssServiceObj.GetTypes().Count() > 0)
                {

                    foreach (var v in AssServiceObj.GetTypes())
                    {
                        if (v.IsNested || !v.IsPublic)
                        {
                            continue;
                        }
                        #region 1、判断服务是否存在并且Open
                        if (IsServiceRun(v.FullName))
                        {
                            ServiceHost sh = (ServiceHost)ServiceSuccessTable[v.FullName];
                            sh.Close();
                        }
                        #endregion
                        #region 2、判断服务是否在服务集合中，如果在则Remove
                        if (ServiceSuccessTable.ContainsKey(v.FullName.Trim()))
                        {
                            ServiceSuccessTable.Remove(v.FullName.Trim());
                        }
                        #endregion
                        #region 3、启动并配置WCF
                        Type type = AssServiceObj.GetType(v.FullName, true);
                        if (type.IsClass)
                        {
                            ServiceHost sh = new ServiceHost(type);
                           
                            sh.Open();
                            ServiceSuccessTable.Add(v.FullName, sh);
                            bResult = true;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\t【Load】");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("启动服务：" + v.FullName);
                        }
                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t【Fail】");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("启动服务：" + AssServiceObj.FullName);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t【Error】" + ex.Message);
                bResult = false;
            }

            return bResult;
        }
        #endregion

        #region 重启所有服务 By: @CaiYong
        /// <summary>
        /// 重启所有已加载的服务
        /// </summary>
        /// <returns></returns>
        public static bool ResetAllService()
        {
            bool bResult = false;
            if (AssSuccessTable != null && AssSuccessTable.Count > 0)
            {
                #region 1、关闭所有已启动成功的服务
                if (ServiceSuccessTable != null && ServiceSuccessTable.Count > 0)
                {
                    foreach (DictionaryEntry v in ServiceSuccessTable)
                    {
                        ServiceHost sh = (ServiceHost)v.Value;
                        if (sh.State == CommunicationState.Opened)
                        {
                            sh.Close();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("\t【Done】");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("关闭服务：" + v.Key);
                        }
                    }
                }

                ServiceSuccessTable.Clear();
                #endregion

                #region 2、启动所有已载入的数据
                foreach (DictionaryEntry de in AssSuccessTable)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("【Load】");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("启动服务集：" + de.Key.ToString());

                    if (RestartService((Assembly)de.Value))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("【Done】");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("【Fail】");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("启动服务集：" + de.Key.ToString());
                }
                #endregion
            }
            else
            {
                throw new Exception("AssSuccessTable is empty");
            }
            return bResult;
        }
        #endregion

        #region 附载指定服务 By: @CaiYong
        public static bool TaskService(string FilePath)
        {
            bool bResult = false;
            if (!string.IsNullOrWhiteSpace(FilePath) && File.Exists(FilePath) && FilePath.LastIndexOf(".") > 0)  // 判断文件是否存在并且是否为*.dll文件
            {
                string cExt = FilePath.Substring(FilePath.LastIndexOf("."));
                if (cExt.ToLower() == ".dll")
                {
                    AssemblyHelper assembly = new AssemblyHelper(FilePath);
                    FileInfo oFileInfo = new FileInfo(FilePath);
                    Assembly oAssembly = assembly.LoadDll(oFileInfo);
                    if (oAssembly != null && IsWCFDLL(oAssembly))
                    {
                        if (!AssSuccessTable.ContainsKey(oFileInfo.Name.Substring(0, oFileInfo.Name.LastIndexOf('.'))) && RestartService(oAssembly))
                        {
                            AssSuccessTable.Add(oFileInfo.Name.Substring(0, oFileInfo.Name.LastIndexOf('.')), oAssembly);
                            bResult = true;
                        }
                    }
                }
            }
            return bResult;
        }
        #endregion

        #region DLL是否为WCF By：@CaiYong
        /// <summary>
        /// 判断DLL是否为WCF Author：@CaiYong
        /// </summary>
        /// <param name="assembly">反射对象</param>
        /// <returns>true：是；false：不是</returns>
        public static bool IsWCFDLL(Assembly assembly)
        {
            try
            {
                Type[] type = assembly.GetTypes();
                if (type != null)
                {
                    for (int i = 0; i < type.Length; i++)
                    {
                        var obj = type[i].GetCustomAttributes(typeof(ServiceContractAttribute), true);
                        int iCount = obj.Count();
                        if (iCount > 0)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());
                return false;
            }
            
        }
        #endregion
    }
}
