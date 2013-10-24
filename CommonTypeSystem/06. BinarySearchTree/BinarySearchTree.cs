using System;
using System.Collections.Generic;
using System.Text;

//Define the data structure binary search tree with operations for "adding new element", 
//"searching element" and "deleting elements". It is not necessary to keep the tree balanced. 
//Implement the standard methods from System.Object – ToString(), Equals(…), GetHashCode() 
//and the operators for comparison  == and !=. 
//Add and implement the ICloneable interface for deep copy of the tree. 
//Remark: Use two types – structure BinarySearchTree (for the tree) and class TreeNode (for the tree elements). 
//Implement IEnumerable<T> to traverse the tree.

//Create class BinarySearchTree<T> using class TreeNode<T>
public class BinarySearchTree<T> : IComparer<TreeNode<T>>, ICloneable, IEnumerable<T> where T : IComparable
{
    //Has only one field and property of type TreeNode<T> - 
    //Root, in which are hold references to its left and right child nodes,
    //which hold references to their left and right child nodes and so on
    private TreeNode<T> root;
    
    public TreeNode<T> Root
    {
       get { return root; }
       set { root = value; }
    }
    
    //Has empty constructor which initialize the value of Root to null
    public BinarySearchTree()
    {
        this.Root = null;
    }
    
    //Method Clear(), which set the value of Root to null, and delete all tree nodes
    public void Clear()
    {
        this.Root = null;
    }

    //Method AreEqual() checks if to objects of class TreeNode<T> are equal,
    //by comparing their values and left and right child nodes, using recursion
    public static bool AreEqual(TreeNode<T> firstRoot, TreeNode<T> secondRoot)
    {
        bool isEqual = true;
    
        if (isEqual && firstRoot!= null && firstRoot.Value.Equals(secondRoot.Value))
        {
            isEqual = AreEqual(firstRoot.Left, secondRoot.Left);
            isEqual = AreEqual(firstRoot.Right, secondRoot.Right);
        }
        else
        {
            isEqual = false;
        }
        return isEqual;
    }
    
    //Override method Equals() by using method AreEqual()
    public static bool Equals(BinarySearchTree<T> first, BinarySearchTree<T> second)
    {
        TreeNode<T> firstRoot = first.Root;
        TreeNode<T> secondRoot = second.Root;
        bool isEqual = AreEqual(firstRoot, secondRoot);
    
        return isEqual;
    }
    
    public static bool operator ==(BinarySearchTree<T> first, BinarySearchTree<T> second)
    {
        return Equals(first, second);
    }
    
    public static bool operator !=(BinarySearchTree<T> first, BinarySearchTree<T> second)
    {
        return !Equals(first, second);
    }
    
    public override bool Equals(object obj)
    {
        return Equals(this, obj as BinarySearchTree<T>);
    }
    
    //Override method GetHeshCode()
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    //Method WriteNodes() writes in a StringBuilder the values of an object of class TreeNode<T>
    //and values of its left and right child nodes, using recursion
    public StringBuilder WriteNodes(TreeNode<T> current, StringBuilder result)
    {
        if (current != null)
        {
            result.AppendLine(current.Value.ToString());
            result = WriteNodes(current.Left, result);
            result = WriteNodes(current.Right, result);
        }
        return result;
    }
    
    //Override method ToString() using method WriteNodes()
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result = WriteNodes(this.Root, result);
        return result.ToString();
    }

    //Method Copy() makes deep copy of an object of class TreeNode<T> by coping its value
    //and values of its left and right child nodes, using recursion
    public TreeNode<T> Copy(TreeNode<T> current, TreeNode<T> cloneRoot)
    {
        if (current != null)
        {
            cloneRoot.Value = current.Value;
            cloneRoot.Left = new TreeNode<T>(default(T), null, null);
            cloneRoot.Left = Copy(current.Left, cloneRoot.Left);
            cloneRoot.Right = new TreeNode<T>(default(T), null, null);
            cloneRoot.Right = Copy(current.Right, cloneRoot.Right);
        }
        return cloneRoot;
    }
    
    //Implement IClonable interface by using method Copy()
    public object Clone()
    {
        TreeNode<T> current = this.Root;
        BinarySearchTree<T> clone = new BinarySearchTree<T>();
        TreeNode<T> cloneRoot = new TreeNode<T>(default(T), null, null);
        clone.Root = Copy(current, cloneRoot);
        return clone;
    }

    //Method MakeList() writes all values of all nodes of current binary search tree in List, using recursion
    public List<T> MakeList(TreeNode<T> current, List<T> list)
    {
        if (current != null)
        {
            list.Add(current.Value);
            list = MakeList(current.Left, list);
            list = MakeList(current.Right, list);
        }
        return list;
    }

    //Implement IEnumerable<T> interface by using method MakeList()
    public IEnumerator<T> GetEnumerator()
    {
        List<T> list = new List<T>();
        list = MakeList(this.Root, list);
        return list.GetEnumerator();
    }
    
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    //Implement IComparer<TreeNode<T>> interface by method Compere(),
    //which compares two objects of class TreeNode<T>, by comparing their values
    public int Compare(TreeNode<T> x, TreeNode<T> y)
    {
        if (x.Value.CompareTo(y.Value) != 0)
        {
            return x.Value.CompareTo(y.Value);
        }
        else
        {
            return 0;
        }
    }

    //Method Search() checkes if current binary search tree contains current tree node, by using method Compare()
    public bool Search(T data)
    {
        TreeNode<T> search = new TreeNode<T>(data, null, null);
        TreeNode<T> current = this.Root;
        int result;
        while (current != null)
        {
            result = Compare(current, search);      //Compares values of two nodes
            if (result == 0)                        //The values are equal
            {
                return true;                        //There is such node in the current binary search tree
            }
            else if (result > 0)                    //The searched value is smaller
            {
                current = current.Left;             //Search in left subtree
            }
            else if (result < 0)                    //The searched value is bigger
            {
                current = current.Right;            //Search in right subtree
            }
        }

        return false;                               //There is no such node in the current binary search tree
    }

    //Method Add() adds new node with current value in current binary search tree 
    //if there is not a node with this value in the tree, using method Compare()
    public void Add(T data)
    {
        TreeNode<T> add = new TreeNode<T>(data);    //Create the node, which is going to be added
        int result;
        TreeNode<T> current = this.Root;
        TreeNode<T> parent = null;

        //Check if current binary search tree contains the node, which is going to be added
        while (current != null)
        {
            result = Compare(current, add);
            if (result == 0)
            {
                return;                             //There is such node in the tree, we do not add the node
            }
            else if (result > 0)
            {
                parent = current;
                current = current.Left;
            }
            else if (result < 0)
            {
                parent = current;
                current = current.Right;
            }
        }

        //There is no such node in the tree
        if (parent == null)
        {
            root = add;                            //The tree is empty, add the node as root
        }
        else
        {
            result = Compare(parent, add);         //The tree is not empty, add the node as leave
            if (result > 0)
            {
                parent.Left = add;
            }
            else
            {
                parent.Right = add;
            }
        }
    }

    //Method Delete() deletes current node with current value in current binary search tree 
    //if there is such node with this value in the tree, using method Compare()
    public bool Delete(T data)
    {
        if (this.Root == null)
        {
            return false;                           //The tree is empty, there is no node to be deleted
        }

        TreeNode<T> delete = new TreeNode<T>(data); //Create copy of the node, which is going to be deleted
        TreeNode<T> current = this.Root;
        TreeNode<T> parent = null;

        //Search in current binary search tree till find the node, which is going to be deleted
        int result = Compare(current, delete);
        while (result != 0)
        {
            if (result > 0)
            {
                parent = current;
                current = current.Left;
            }
            else if (result < 0)
            {
                parent = current;
                current = current.Right;
            }
    
            if (current == null)
            {
                return false;                    //There is no such node in the tree
            }
            else
            {
                result = Compare(current, delete);
            }
        }
    
        //There is such node in the tree, we are going to delete the it - current
        //Case 1: current has no right child, then 
        //current's left child replaces current
        if (current.Right == null)
        {
            if (parent == null)                  //current is the root of the binary search tree
            {
                this.Root = current.Left;        //current's left child becomes root
            }
            else
            {
                result = Compare(parent, current);
                if (result > 0)
                {
                    parent.Left = current.Left;   //current's left child becomes left child of parent
                }
                else if (result < 0)
                {
                    parent.Right = current.Left;  //current's left child becomes right child of parent
                }
            }
        }

        //Case 2: current's right child has no left child, then 
        //current's right child replaces current
        else if (current.Right.Left == null)
        {
            current.Right.Left = current.Left;
            if (parent == null)                  //current is the root of the binary search tree
            {
                this.Root = current.Right;       //current's right child becomes root
            }
            else
            {
                result = Compare(parent, current);
                if (result > 0)
                {
                    parent.Left = current.Right;  //current's right child becoms left child of parent
                }
                else if (result < 0)
                {
                    parent.Right = current.Right; //current's right child becomes right child of parent
                }
            }
        }

        //Case 3: current's right child has a left child, then
        //replace current with current's right child's left-most descendent
        else
        {
            //Find the right node's left-most child
            TreeNode<T> leftMost = current.Right.Left;
            TreeNode<T> leftMostParent = current.Right;
            while (leftMost.Left != null)
            {
                leftMostParent = leftMost;
                leftMost = leftMost.Left;
            }
    
            //parent's left subtree becomes the leftMost's right subtree
            leftMostParent.Left = leftMost.Right;
    
            //assign leftMost's left and right to current's left and right children
            leftMost.Left = current.Left;
            leftMost.Right = current.Right;

            if (parent == null)                  //current is the root of the binary search tree
            {
                this.Root = leftMost;            //leftMost becomes root
            }
            else
            {
                result = Compare(parent, current);
                if (result > 0)
                {
                    parent.Left = leftMost;      //leftMost becomes left child of parent
                }
                else if (result < 0)
                {
                    parent.Right = leftMost;     //leftMost becomes right child of parent
                }
            }
        }

        return true;                             //The node is deleted
    }
}