using System;
using System.Collections.Generic;

public class TreeNode<T>
{
    public T Data { get; set; }
    public TreeNode<T> Parent { get; set; }
    public List<TreeNode<T>> Children { get; set; }

    public TreeNode(T data, TreeNode<T> parent = null)
    {
        Data = data;
        Parent = parent;
        Children = new List<TreeNode<T>>();
    }

    public void AddChild(TreeNode<T> child)
    {
        child.Parent = this;
        Children.Add(child);
    }

    public void Display()
    {
        Console.WriteLine($"- {Data}");
        foreach (var child in Children)
        {
            Console.WriteLine($" - {child.Data}");
        }
    }
}
