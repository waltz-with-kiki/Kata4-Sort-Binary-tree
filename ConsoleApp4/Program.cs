using System.Collections.Generic;

class Kata
{
    public static List<int> TreeByLevels(Node node)
    {
        /*List<int> list = new List<int>();

                 if (node == null) return list;

                 list.Add(node.Value);
                 if (node.Left != null)
                 {
                     list.AddRange(TreeByLevels(node.Left));
                 }

                 if (node.Right != null)
                 {
                      list.AddRange(TreeByLevels(node.Right));
                 }

                 return list;*/
        // Вывод по ветвям дерева через рекурсию
        List<int> list = new List<int>();

        if (node == null) return list;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            int j = queue.Count;

            for (int i = 0; i < j; i++)
            {
                Node current = queue.Dequeue();
                list.Add(current.Value);

                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }

                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }

        }

        return list;
    }

    public class Node
    {
        public Node Left;
        public Node Right;
        public int Value;

        public Node(Node l, Node r, int v)
        {
            Left = l;
            Right = r;
            Value = v;
        }
    }
}