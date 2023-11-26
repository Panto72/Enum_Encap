public class EmpoyeeGetSet
{
    private string Name;
    private string Salary;
    private DateTime created;

    public void display()
    {
        Console.WriteLine(this.Name);
    }
    public string NAME
    {
        get { return Name; }
        set { Name = value; }
    }
}

public class Program
{
    public static void Main()
    {
        EmpoyeeGetSet Emp = new EmpoyeeGetSet();
        Emp.NAME = "pranto";
        Emp.display();
        Console.ReadLine();
    }

}