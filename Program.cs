using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlistUC4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList listThree = new LinkedList();
            listThree.AddAppend(56);
            listThree.AddAppend(70);
            listThree.Display();
            listThree.Insert(2, 30);
            Console.WriteLine("----------After insert operation----------");
            listThree.Display();
            Console.ReadLine();

        }
    }
}
