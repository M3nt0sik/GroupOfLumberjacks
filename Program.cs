using GroupOfLumberjacks;
using System;
using System.ComponentModel;
using System.Xml.Linq;

internal class Program
{
    static Random rand = new Random();
    static void ADDLumber(string _name, int CountPancake, Queue<Lumberjack> myLumbejack, Lumberjack myLumber)
    {
        myLumber = new Lumberjack(_name);
        for (int i = 0; i < CountPancake; i++)
        {
            int e = Enum.GetNames<EFlapjack>().Length;
            myLumber.TakeFlapjack((EFlapjack)rand.Next(e));

        }
        myLumbejack.Enqueue(myLumber);
    }
    private static void Main(string[] args)
    {
        string name;
        int pancakesCount;
        Lumberjack myLumber = new Lumberjack("nn"); ;
        Queue<Lumberjack> myLumbejack = new Queue<Lumberjack>();
        
        Console.Write("Imie pierwszergo drwala: ");
        name = Console.ReadLine();
        Console.Write("Liczba nalenikow: ");
        int.TryParse(Console.ReadLine(), out pancakesCount);
        ADDLumber(name, pancakesCount, myLumbejack, myLumber);
        
        

        while (true)
        {
            Console.Write("\nImie natepnego drwala: ");
            name = Console.ReadLine();
            if (name == "") break;
            Console.Write("Liczba nalenikow: ");
            int.TryParse(Console.ReadLine(), out pancakesCount);
            ADDLumber(name, pancakesCount, myLumbejack, myLumber);
        }
        
        
        foreach(Lumberjack lumb in myLumbejack)
        {
            lumb.EatFlapjacks();
        }
        myLumbejack.Clear();
        
    }
    
}