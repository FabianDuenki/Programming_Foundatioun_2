using System;
using System.Collections;

public class Program
{
    public static void Main()
    {
        Katze katze = new Katze(1);
        Hund hund = new Hund(2);
        Papagei papagei = new Papagei(3);
        hund.Spielen(katze);
    }
}
public class Tier
{
    private int _id;
    public Tier(int id)
    {
        Id = id;
        Count++;
    }
    private int Id
    {
        get { return Id; }
        set { _id = value; }
    }
    public static int Count
    {
        get; set;
    }
    public void Spielen(Tier other)
    {
        if (this is Hund)
        {
            if (other is Katze)
            {
                Console.WriteLine("ah wau, ah miaow");
                Console.ReadLine();
            }
        }
        else
        {
            Console.WriteLine("ah, ah");
        }
    }
}
public class Hund : Tier
{
    public Hund (int Id):base(Id)
    {

    }
}
public class Katze : Tier
{
    public Katze(int Id) : base(Id)
    {

    }
}
public class Papagei : Tier
{
    public Papagei(int Id) : base(Id)
    {

    }
}