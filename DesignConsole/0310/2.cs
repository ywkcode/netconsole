using static DesignConsole._0310.Subject;

namespace DesignConsole._0310
{
    //增加抽象观察者abstract Observer 抽象通知者 interface Subject

    //解耦了，但是通知事件不够灵活 最好由客户端决定



    //
    public interface Subject
    {
        void Attach(Observer observer);
        void Detch(Observer observer);

        void Notify();
        string SecretaryAction { get; set; }

        delegate void EventHandle();
    }
    public class Secretary2 : Subject
    {
        private string action;
        private IList<Observer> observers = new List<Observer>();

        public event EventHandle Update;

        public void Attach(Observer server)
        {
            observers.Add(server);
        }

        public void Detch(Observer server)
        {
            observers.Remove(server);
        }
        public string SecretaryAction
        {
            get { return action; }
            set { action = value; }
        }

        public void Notify()
        {
            Update();
        }
    }
    public abstract class Observer
    {
        protected string name { get; set; }

        protected Secretary2 sub { get; set; }

        public Observer(string name, Secretary2 sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public abstract void Update();
    }


    public class StockObServer2 : Observer
    {

        public StockObServer2(string name, Secretary2 sub) : base(name, sub)
        {

        }


        public override void Update()
        {
            Console.WriteLine($"{sub.SecretaryAction},{name}继续工作");
        }
    }

    public class NBAObserver : Observer
    {
        public NBAObserver(string name, Secretary2 sub) : base(name, sub) { }

        public override void Update()
        {
            Console.WriteLine($"{sub.SecretaryAction},{name}关闭直播");
        }
    }

    public static class Test2
    {
        //违背了开放关闭原则 和依赖倒转原则，应该让程序依赖抽象
        public static void Main()
        {
            Secretary2 sub = new Secretary2();
            sub.SecretaryAction = "老板来了";
            StockObServer2 t1 = new StockObServer2("A", sub);
            StockObServer2 t2 = new StockObServer2("B", sub);

            sub.Update += new EventHandle(t1.Update);
            sub.Update += new EventHandle(t2.Update);
            sub.Notify();//通知所有订阅者
        }
    }
}
