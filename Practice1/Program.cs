using System;
using System.Collections.Generic;
using Practice1.LinkedList;
using Practice1.DoublyLinkedList;
using Practice1.SortingAlgorithms;
using Practice1.Tree;
   
class Program 
{   
    static void Main(string[] args)
    {

        #region MySort
        //int[] data = new int[20];
        //Random rd = new Random();
        //for (int i = 0; i < data.Length; ++i)
        //{
        //    data[i] = rd.Next(1, 101);
        //}
        //System.Console.WriteLine("The array before sorting:");
        //foreach (int x in data)
        //{
        //    System.Console.Write(x + " ");
        //}
        //MySortingMethod.Sort(data);       
        //System.Console.ReadKey();
        #endregion

        #region BubbleSort
        //int[] data = new int[20];
        //Random rd = new Random();
        //for (int i = 0; i < data.Length; ++i)
        //{
        //    data[i] = rd.Next(1, 101);
        //}
        //System.Console.WriteLine("The array before sorting:");
        //foreach (int x in data)
        //{
        //    System.Console.Write(x + " ");
        //}
        //BubbleSorting.BubbleSort(data);
        //System.Console.WriteLine("\nThe array after sorting:");
        //foreach (int x in data)
        //{
        //    System.Console.Write(x + " ");
        //}
        //System.Console.ReadKey();
        #endregion

        #region Quicksorting
        //int[] data = new int[20];
        //Random rd = new Random();
        //for (int i = 0; i < data.Length; ++i)
        //{
        //    data[i] = rd.Next(1, 101);
        //}
        //System.Console.WriteLine("The array before sorting:");
        //foreach (int x in data)
        //{
        //    System.Console.Write(x + " ");
        //}
        //QuickSorting.sorting(data, 0, data.Length - 1);
        //System.Console.WriteLine("\nThe array after sorting:");
        //foreach (int x in data)
        //{
        //    System.Console.Write(x + " ");
        //}
        //System.Console.ReadKey();
        #endregion

        #region BucketSort
        //BucketSort bucketSort = new BucketSort();
        //int[] data = new int[] { -4, -1245, 3, 0, 234, 125, 1245, -100 };
        //Console.WriteLine("unsorted\n\n");
        //for (int i =0; i < data.Length; i ++)
        //{
        //    Console.WriteLine(data[i]);
        //}
        //bucketSort.BucketSorting(data);
        //Console.WriteLine("\nsorted\n\n");
        //for (int i = 0; i < data.Length; i++)
        //{
        //    Console.WriteLine(data[i]);
        //}
        #endregion

        #region SingleLinkedList
        //SingleLinkedList<int> a = new SingleLinkedList<int>();

        //a.AddWithWhile(6);
        //a.AddWithWhile(5);
        //a.AddWithWhile(4);
        //a.AddWithWhile(3);
        //a.AddWithWhile(2);
        //a.AddWithWhile(2);
        //a.AddWithWhile(2);
        //a.PrintList();
        //Console.WriteLine("\nasdasd\n");
        //a.Remove(4);
        //a.PrintList();      
        //Console.WriteLine("\nasdasd\n");
        //a.Clear();
        //a.PrintList();      
        //Console.WriteLine("\nnull\n");
        #endregion

        #region DoubleLinkedList
        //DoubleLinkedList<int> b = new DoubleLinkedList<int>();

        //b.AddWithWhile(1);
        //b.AddWithWhile(2);
        //b.AddWithWhile(3);
        //b.AddWithWhile(4);
        //b.AddWithWhile(5);
        //b.AddWithWhile(6);
        //b.PrintList();
        //Console.WriteLine("printing reverse list");
        //b.PrintReverseList();
        //Console.WriteLine("Remove list");
        //b.Remove(3);
        //b.PrintList();
        //Console.WriteLine("printing reverse list");
        //b.PrintReverseList();
        //Console.WriteLine("clear");
        //b.Clear();
        //b.PrintList();             
        //Console.WriteLine("\nnull\n");
        //Console.ReadKey();
        #endregion
       

        #region Tree
        Tree<int> tree = new Tree<int>(15);
        tree.AddToNode(15, 4);
        tree.AddToNode(15, 10);
        tree.AddToNode(15, 5);
        tree.AddToNode(4, 1);
        tree.AddToNode(4, 2);
        tree.AddToNode(10, 77);
        tree.AddToNode(10, 51);
        tree.AddToNode(5, 69);
        tree.AddToNode(5, 13);
        tree.AddToNode(1, 11);
        tree.AddToNode(1, 66);
        tree.AddToNode(2, 7);

        Console.WriteLine("\nBefore sorting\n");

        tree.TraverseDFS();        

        tree.Sort(tree.root);
            
        Console.WriteLine("\nAfter sorting 1\n");

        tree.TraverseDFS();

        tree.Sort(tree.root);

        Console.WriteLine("\nAfter sorting 2\n");

        tree.TraverseDFS();

        #endregion
    }
}


