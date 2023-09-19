using System;
using System.Collections.Generic;
using System.Text;

namespace commonTest
{
    public static class Test0919
    {
        public delegate int Callback();
        

        public static int startProcess(int a, int b, Callback callBackFunc) {
            
            return a + b;
        }

        public static int addEvent()
        {
            return 9;
        }
      

        public static void PrintFunc(Callback callBack, string str)
        {
           
           
        }

        public static int LoadMsg()
        {
             
            return 10;
        }
    }
}
