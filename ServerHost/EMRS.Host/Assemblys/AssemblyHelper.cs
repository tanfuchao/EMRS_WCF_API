using System;
using System.Collections;
using System.IO;
using System.Reflection;

namespace HostStart
{
    /// <summary>
    /// 反射帮助类
    /// </summary>
    public class AssemblyHelper
    {
        /// <summary>
        /// 反射路径
        /// </summary>
        public string FilePath
        {
            get;
            set;
        }

        /// <summary>
        /// 反射成功结果集合
        /// </summary>
        public Hashtable AssSuccessTable
        {
            get;
            set;
        }

        #region 构造函数 By: @CaiYong
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="FilePath">反射路径</param>
        public AssemblyHelper(string FilePath)
        {
            this.FilePath = FilePath;
            this.AssSuccessTable = new Hashtable();
        }
        #endregion

        #region 反射DLL文件 By: @CaiYong
        /// <summary>
        /// 反射指定路径下的所有函数
        /// </summary>
        /// <returns>true:成功;false:失败</returns>
        public bool LoadAllDll()
        {
            bool bResult = false;
            if (!string.IsNullOrWhiteSpace(this.FilePath))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(this.FilePath.Trim());
                FileInfo[] files = directoryInfo.GetFiles("*.dll");
                if (files != null && files.Length > 0)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        FileInfo oFileInfo = files[i];
                        //Assembly oAssembly = Assembly.LoadFile(oFileInfo.FullName);
                        Assembly oAssembly = Assembly.UnsafeLoadFrom(oFileInfo.FullName);
                        this.AssSuccessTable.Add(oFileInfo.Name.Substring(0, oFileInfo.Name.LastIndexOf('.')), oAssembly);
                    }
                }
                bResult = true;
            }
            else
            {
                throw new NullReferenceException("Error:FilePath is empty.");
            }
            return bResult;
        }
        #endregion

        #region 反射指定路径下的DLL文件
        public Assembly LoadDll(FileInfo oFileInfo)
        {
            Assembly oAssembly = null;
            try
            {
                //oAssembly = Assembly.LoadFile(oFileInfo.FullName);
                oAssembly = Assembly.UnsafeLoadFrom(oFileInfo.FullName);
            }
            catch (Exception)
            {
            }
            return oAssembly;
        }
        #endregion
    }
}
