using HelloWorldProject;
using System;
using System.Diagnostics.Metrics;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;

namespace HWNS
{
    


    class Program
    {
        
        public static void Main()
        {
            BSTree bSTree = new BSTree();
            bSTree.insert(7);
            bSTree.insert(4);
            bSTree.insert(3);
            bSTree.insert(9);
            bSTree.insert(8);
            Console.WriteLine("before deleting 9: ");
            bSTree.printBST();
            Console.WriteLine("-----------------------");
            bSTree.delete(9);
            Console.WriteLine("after deleting 9");
            bSTree.printBST();

        }

    }
}

            

       