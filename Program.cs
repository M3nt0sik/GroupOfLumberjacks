using GroupOfLumberjacks;
using System;
using System.ComponentModel;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        string name;
        int pancakesCount;
        Lumberjack myLumber;
        Stack<Lumberjack> myLumbejack = new Stack<Lumberjack>();
        Random rand = new Random();
        Console.Write("Imie pierwszergo drwala: ");
        name = Console.ReadLine();
        Console.Write("Liczba nalenikow: ");
        int.TryParse(Console.ReadLine(), out pancakesCount);
        ADDLumber(name, pancakesCount);
        
        

        while (true)
        {
            Console.Write("\nImie natepnego drwala: ");
            name = Console.ReadLine();
            if (name == "") break;
            Console.Write("Liczba nalenikow: ");
            int.TryParse(Console.ReadLine(), out pancakesCount);
            ADDLumber(name, pancakesCount);
        }
        
        
        foreach(Lumberjack lumb in myLumbejack)
        {
            lumb.EatFlapjacks();
        }
        void ADDLumber(string _name, int CountPancake)
        {
            myLumber = new Lumberjack(_name);
            for (int i = 0; i < CountPancake; i++)
            {
                int e = Enum.GetNames<EFlapjack>().Length;
                myLumber.TakeFlapjack((EFlapjack)rand.Next(e));

            }
            myLumbejack.Push(myLumber);
        }
    }
    
}