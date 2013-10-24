using System;

//Create generic class TreeNode to hold current node of the binary search tree
public class TreeNode<T>
{
    //Class TreeNode<T> has three fields and properties - the value of the node of type T and left and right child nodes
    private T data;
    private TreeNode<T> left;
    private TreeNode<T> right;

    public T Value
    {
        get { return data; }
        set { data = value; }
    }

    //Left and right child nodes could have value null - they could not exist
    public TreeNode<T> Left
    {
        get
        {
            if (this.left == null)
            {
                return null;
            }
            else
            {
                return (TreeNode<T>)this.left;
            }
        }
        set
        {
            if (this.left == null)
            {
                this.left = new TreeNode<T>();
            }

            this.left = value;
        }
    }

    public TreeNode<T> Right
    {
        get
        {
            if (this.right == null)
            {
                return null;
            }
            else
            {
                return (TreeNode<T>)this.right;
            }
        }
        set
        {
            if (this.right == null)
            {
                this.right = new TreeNode<T>();
            }

            this.right = value;
        }
    }

    //Create three constructors - empty, only with value of the node and with value of the node, left and right child nodes
    public TreeNode() 
    { 
    }
    public TreeNode(T data) : this(data, null, null) 
    { 
    }
    public TreeNode(T data, TreeNode<T> left, TreeNode<T> right)
    {
        this.Value = data;
        this.Left = left;
        this.Right = right;
    }
}