using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1.Tree
{
    class TreeNode<T>
    {
        public T data;

        public TreeNode<T> Parent;

        public List<TreeNode<T>> Children;

        public TreeNode(T data)
        {
            this.data = data;
            this.Parent = null;
            this.Children = new List<TreeNode<T>>();
        }

        public int ChildrenCount
        {
            get
            {
                return this.Children.Count;
            }
        }

        public void AddChild(T data)
        {
            TreeNode<T> temp = new TreeNode<T>(data);
            this.Children.Add(temp);
            temp.Parent = this;
        }

        public TreeNode<T> GetChild(int index)
        {
            return this.Children[index];
        }

    }
}
