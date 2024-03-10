using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignConsole._0310
{
    //双向耦合

    public class Secretary
    {
        private string action;
        private IList<StockObServer> observers = new List<StockObServer>();
        public void Attach(StockObServer stockServer)
        {
            observers.Add(stockServer);
        }
        public string SecretaryAction
        {
            get { return action; }
            set { action = value; }
        }

        public void Notify()
        {
            foreach (var model in observers)
            {
                model.Update();
            }
        }
    }

    public class StockObServer
    {
        private string name;
        private Secretary sub;
        public StockObServer(string name, Secretary sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void Update()
        {
            Console.WriteLine($"{sub.SecretaryAction},{name}继续工作");
        }


    }
    //Secrerty和StockerServer 互相依赖

    public static class Test
    {
        //违背了开放关闭原则 和依赖倒转原则，应该让程序依赖抽象
        public static void Main()
        {
            Secretary sub = new Secretary();
            sub.SecretaryAction = "老板来了";
            StockObServer t1 = new StockObServer("A", sub);
            StockObServer t2 = new StockObServer("B", sub); 
            sub.Attach(t1); 
            sub.Attach(t2); 
            sub.Notify();//通知所有订阅者
        }
    }
}
