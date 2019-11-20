using Binary_Tree.models;
using System;

namespace Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int t1 = 20;
            int t2 = 15;
            int t3 = 30;
            int t4 = 25;
            int t5 = 35;
            int t6 = 22;
            int t7 = 28;
            int t8 = 32;
            int t9 = 38;
            int t10 = 31;
            int t11 = 33;

            BinaryTree bt = new BinaryTree();
            bt.Add(t1);
            bt.Add(t2);
            bt.Add(t3);
            bt.Add(t4);
            bt.Add(t5);
            bt.Add(t6);
            bt.Add(t7);
            bt.Add(t8);
            bt.Add(t9);
            bt.Add(t10);
            bt.Add(t11);

            //Find
            BinaryTreeItem bt1 = new BinaryTreeItem();
            BinaryTreeItem bt2 = new BinaryTreeItem();

            // bt1 = bt.Find(12);
            // bt2 = bt.FindRecursiv(12);
            //bt2 = bt.FindItemBeforeItem(12);

            bt.Remove(20);

            // bt1 = bt.FindMax();
            //bt2 = bt.FindMaxRecursiv(10);
            //bt1 = bt.FindMin(10);
            //bt2 = bt.FindMinRecursiv(10);
            //Console.WriteLine(bt2);
            Console.WriteLine();

            //bt1 = bt.FindMin();
            //bt2 = bt.FindMax();
            // Console.WriteLine(bt1);
            //Console.WriteLine(bt2);

            // Console.WriteLine(bt.Counter);


            Console.ReadKey();
        }
    }
}
