using commonTest._0912;
using System;

namespace commonTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //action:提交
            Commander commander = new StartCommander();
            Test0912.Drive(commander);

            //action:退回
            commander = new StopCommander();
            Test0912.Drive(commander);

            Console.ReadLine();
        }
    }
}
