using System;
public class Program
{
    public static void Main()
    {
        var Ab = new[]
{
            new {ID =14172 ,Name="Pranto",Mobile="01752335210"},
            new {ID =13926 ,Name="surovi",Mobile="01752335210"},
            new {ID =14174 ,Name="tausif",Mobile="01752335210"},
        };
        foreach (var item in Ab)
        {
            Console.WriteLine(item.Name);
        }
    }
}