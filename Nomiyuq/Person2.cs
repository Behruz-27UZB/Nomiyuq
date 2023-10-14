using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomiyuq
{
    public class Person2 : IPerson
    {
        private int ID = 1;
        private string Name = "Name";
         int IPerson.Id 
        {   get => ID; 
            set => ID = value; 
        }
        string IPerson.FulName 
        {   get => Name; 
            set => Name = value; 
        }
        void IPerson.Olish() 
        {
            Console.WriteLine("Id = " + this.ID + "\n Ful Name = " + this.Name);
        }
    }
}
