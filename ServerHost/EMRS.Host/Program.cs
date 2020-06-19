using EMRS.Mapper;
using System;

namespace HostStart
{
    class Program
    {


        static void Main(string[] args)
        {
            AutoMapperRegister();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("EMRS_Service Starting...\r\n");
            ServiceHelper.RunService();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nEMRS_Service Start Success");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\r\n--------------------Terminal--------------------");
            Console.WriteLine(" 输入help指令可查看全部指令说明");
            TerminalHelper.StartInputCommand();
            Console.ReadKey();

        }

        /// <summary>
        /// AutoMapper的配置初始化
        /// </summary>
        private static void AutoMapperRegister()
        {
            new AutoMapperStartupTask().Execute();
        }
    }
}
