using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1.Tree
{
    class Tree<T>
    {
        public TreeNode<T> root;
       
        public Tree(T data)
        {
            this.root = new TreeNode<T>(data);
        }


        public TreeNode<T> Search(TreeNode<T> node, T dataToFind)
        {
            if (EqualityComparer<T>.Default.Equals(node.data, dataToFind))
                return node;

            foreach (var child in node.Children)
            {
                var result = Search(child, dataToFind);
                if (result != null)
                    return result;
            }

            return null;
        }

        public void check()
        {
            Console.WriteLine(EqualityComparer<T>.Default.Equals(root.data, root.data));

            Console.WriteLine(Comparer<T>.Default.Compare(root.data, root.Children[1].data));
        }

        public void Swap(ref T e1, ref T e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        public void Sort(TreeNode<T> node)
        {                                  

            foreach (var child in node.Children)
            {
                
                //for (int i = 0; i < node.Children.Count; i++)
                //{
                //    for (var j = 0; j < node.Children.Count - i; j++)
                //    {
                //        if (Comparer<T>.Default.Compare(node.Children[j].data, node.Children[j+1].data) < 0)
                //        {
                //            Swap(ref node.Children[j].data, ref node.Children[j + 1].data);
                //        }
                //    }
                //}
                
                
                    if (Comparer<T>.Default.Compare(child.data, child.Parent.data) < 0)
                    {
                        Swap(ref child.data, ref child.Parent.data);
                    }
                    Sort(child);
                                              
            }            
        }
      

        public void AddToNode(T nodeData, T data)
        {
            Search(root, nodeData).AddChild(data);
        }

        private void PrintDFS(TreeNode<T> root, string spaces)
        {
            if (this.root == null)
            {
                return;
            }

            Console.WriteLine(spaces + root.data);

            TreeNode<T> child = null;

            for (int i = 0; i < root.ChildrenCount; i++)
            {

                child = root.GetChild(i);
                PrintDFS(child, spaces + "   ");
            }

        }

        public void TraverseDFS()
        {
            this.PrintDFS(this.root, string.Empty);
        }
    }
}
