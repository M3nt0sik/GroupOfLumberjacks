using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfLumberjacks
{
    internal class Lumberjack
    {
        //private field Name
        private string name;
        //reference Stack he take Enum EFlpajack
        private Stack<EFlapjack> flapjackStack;
        //property to set privet field name
        public string Name 
        { 
            get { return name; } 
            private set { name = value; }
        }
        //Constructor to blid object
        public Lumberjack(string name)
        {
            Name = name;
            flapjackStack = new Stack<EFlapjack>();
        }
        //method to place emenent on top the stack
        public void TakeFlapjack(EFlapjack flapjack)
        {
            flapjackStack.Push(flapjack);
        }
        //method remove element from the stack
        public void EatFlapjacks()
        {
            foreach(EFlapjack f in flapjackStack)
            {
                Console.WriteLine($"{Name} je {f} nalesnik");
            }
            flapjackStack.Clear();
                
        }
        //override method to beter understed when debug program
        public override string ToString()
        {
            return $"{Name} ma nalesnikow {flapjackStack.Count}";
        }

    }
}
