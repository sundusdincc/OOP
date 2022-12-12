internal class Program
{
    private static void Main(string[] args)
    {
        //exp-1
        var p1 = new Person();
        p1.name = "Jane";

        var p2 = new Person();
        p2.name = "Beky";

        Console.WriteLine(p1.name);
        Console.WriteLine(p2.name);

        //exp-2
        var c = new Circle();
        c.SetRadius(5);

        Console.WriteLine(c.Area());

        //exp-3
        var name = "Lenka";
        var born = new DateTime(1990, 3, 5);

        var friend = new MyFriend(name, born);
        friend.Info();

    }
}
class Person
{
    public string name;
}

class Circle
{
    private int radius;

    public void SetRadius(int radius)
    {
        this.radius = radius;
    }

    public double Area()
    {
        return this.radius * this.radius * Math.PI;
    }
}

class MyFriend
{
    private DateTime born;
    private string name;

    public MyFriend(string name, DateTime born)
    {
        this.name = name;
        this.born = born;
    }

    public void Info()
    {
        Console.WriteLine("{0} was born on {1}",
            this.name, this.born.ToShortDateString());
    }
}