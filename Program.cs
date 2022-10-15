using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedListUC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                linkedListUC3 customLinkedList = new linkedListUC3();
                //UC3 append
                customLinkedList.Append(56);
                customLinkedList.Append(30);
                customLinkedList.Append(70);
                Console.ReadLine();
        }
    }
}
