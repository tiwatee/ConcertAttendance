using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertSelection
{
    public abstract class Class1 //abstraction using abstract class
    {
        private bool isadele;
        private bool isedsheeran;
        private bool isjohnnydrille;
        
        public bool IsAdele //encapsulation
        {
            get
            {
                return isadele;
            }
            set
            {
                isadele = value;
            }
        }
        public bool IsEdsheeran //encapsulation
        {
            get 
            { 
                return isedsheeran; 
            }
            set
            {
                isedsheeran = value;
            }
        }

        public bool IsJohnnyDrille //encapsulation
        {
            get
            {
                return isjohnnydrille;
            }
            set
            {
                isjohnnydrille = value;
            }

        }

        public abstract void ProgOrganizer();
        public string Attend()
        {
            if (IsAdele && IsEdsheeran && IsJohnnyDrille)
            {
                return"I will be attending";
            }
            else
            {
                return "I will not be attending";
            }
        }
    }

    public class AliAndSon : Class1 //inheritance. inheriting the properties and methods of class1

    {
        public override void ProgOrganizer() //polymorphism
        {
            Console.WriteLine("The organizers are Ali and Son Corporation");
        }
    }

    public class LadyBug : Class1 // inheritance.Inheriting the properties and methods of class1
    {
        public override void ProgOrganizer() //polymorphism
        {
            Console.WriteLine("The organizers are Lady Bug Corporation");
        }
    }

}
