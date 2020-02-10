using System;
using CustomBinaryTree;
using sort = CustomInsertionSort.InsertionSort;
using CustomLinkedList;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {

            /// Бинарное дерево ///

            var binaryTree = new BinaryTree<int>();

            binaryTree.Add(8);
            binaryTree.Add(3);
            binaryTree.Add(10);
            binaryTree.Add(1);
            binaryTree.Add(6);
            binaryTree.Add(4);
            binaryTree.Add(7);
            binaryTree.Add(14);
            binaryTree.Add(16);

            binaryTree.PrintTree();

            Console.WriteLine(new string('-', 40));
            binaryTree.Remove(3);
            binaryTree.PrintTree();

            Console.WriteLine(new string('-', 40));
            binaryTree.Remove(8);
            binaryTree.PrintTree();

            /// Сортировка вставками ///

            int[] array = { 6, 3, 1, 9, 5, 7, 2 };

            var newArray = sort.insertionSort(array); // 1, 2, 3, 5, 6, 7, 9

            /// Связный список ///

            LinkedList<string> linkedList = new LinkedList<string>();

            linkedList.Add("Tom");
            linkedList.Add("Alice");
            linkedList.Add("Bob");
            linkedList.Add("Sam");

            // Tom, Alice, Bob, Sam

            linkedList.Remove("Alice");

            // Tom, Bob, Sam

            linkedList.reverse();

            // Sam, Bob, Tom
        }
    }
}
