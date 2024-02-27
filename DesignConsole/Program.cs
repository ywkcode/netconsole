// See https://aka.ms/new-console-template for more information
using DesignConsole._0227;

Console.WriteLine("Hello, World!");
Cat cat = new Cat("Tome");
Mouse m1 = new Mouse("Jerry");
Mouse m2 = new Mouse("Jack");
cat.CatShout += new Cat.CatShoutEventHandler(m1.Run);
cat.CatShout += new Cat.CatShoutEventHandler(m2.Run);
cat.Shout();
Console.ReadLine();