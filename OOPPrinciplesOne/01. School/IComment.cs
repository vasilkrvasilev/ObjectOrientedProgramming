using System;

//Create interface IComment
public interface IComment
{
    string Comment
    {
        get;
        set;
    }

    void Print();
}