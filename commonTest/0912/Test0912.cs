using System;
using System.Collections.Generic;
using System.Text;

namespace commonTest._0912
{
   

    /// <summary>
    /// 抽象类 如果把流程真分解
    /// </summary>
    public abstract class Commander
    {
        public abstract void Execute();
    }

    public class StartCommander : Commander
    {
        public override void Execute()
        {
            Console.WriteLine("StartCommander");
        }
    }

    public class StopCommander : Commander
    {
        public override void Execute()
        {
            Console.WriteLine("StopCommander");
        }
    }

   
    public static class Test0912
    {
        public static void Drive(Commander commander)
        {
            commander.Execute();
        }

    }
}
