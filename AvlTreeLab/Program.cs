namespace AvlTreeLab
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            var avl = new AvlTree<int>();
            avl.Add(50);
            avl.Add(60);
            avl.Add(40);
            avl.Add(10);
            avl.Add(-1);
            Console.WriteLine();
        }
    }
}
