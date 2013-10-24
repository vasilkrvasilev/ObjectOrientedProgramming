using System;
using System.Collections.Generic;
using System.Text;

//Uses classes TreeNode<T> and BinarySearchTree<T>
public class Start
{
    public static void Main()
    {
        //Create binary search tree
        BinarySearchTree<int> firstTree = new BinarySearchTree<int>();
        firstTree.Root = new TreeNode<int>(10);
        firstTree.Root.Left = new TreeNode<int>(5);
        firstTree.Root.Right = new TreeNode<int>(20);

        firstTree.Root.Left.Left = new TreeNode<int>(1);
        firstTree.Root.Right.Right = new TreeNode<int>(24);

        firstTree.Root.Left.Left.Right = new TreeNode<int>(3);
        firstTree.Root.Right.Right.Right = new TreeNode<int>(35);

        firstTree.Root.Right.Right.Right.Right = new TreeNode<int>(50);

        //Test ToString() method
        Console.WriteLine("Elements of firstTree");
        Console.WriteLine(firstTree.ToString());

        //Create another binary search tree
        BinarySearchTree<int> secondTree = new BinarySearchTree<int>();
        secondTree.Root = new TreeNode<int>(10);
        secondTree.Root.Left = new TreeNode<int>(5);
        secondTree.Root.Right = new TreeNode<int>(20);

        secondTree.Root.Left.Left = new TreeNode<int>(1);
        secondTree.Root.Right.Right = new TreeNode<int>(24);

        secondTree.Root.Left.Left.Right = new TreeNode<int>(3);
        secondTree.Root.Right.Right.Right = new TreeNode<int>(35);

        secondTree.Root.Right.Right.Right.Right = new TreeNode<int>(49);

        //Test Equals() method
        Console.WriteLine("firstTree is equal to secondTree?:");
        Console.WriteLine(firstTree.Equals(secondTree));

        //Test Clone() method
        Console.WriteLine("Elements of the clone of firstTree");
        BinarySearchTree<int> clone = (BinarySearchTree<int>)firstTree.Clone();
        Console.WriteLine(clone.ToString());

        //Test Search() method
        Console.WriteLine("firstTree contains 50?:");
        Console.WriteLine(firstTree.Search(50));
        Console.WriteLine("secondTree contains 50?:");
        Console.WriteLine(secondTree.Search(50));

        //Test Add() method
        Console.WriteLine("Elements of firstTree after adding 22");
        firstTree.Add(22);
        Console.WriteLine(firstTree.ToString());

        //Test Delete() method
        Console.WriteLine("Elements of secondTree after deleting 24");
        Console.WriteLine(secondTree.Delete(24));
        Console.WriteLine(secondTree.ToString());

        //Use foreach to test the implementation of IEnumerable<T> interface
        clone.Add(100);
        Console.WriteLine("firstTree after adding 100 to clone");
        foreach (var item in firstTree)
        {
            Console.Write("{0} ", item);
        }

        Console.WriteLine("clone after adding 100 to clone");
        foreach (var item in clone)
        {
            Console.Write("{0} ", item);
        }
    }
}