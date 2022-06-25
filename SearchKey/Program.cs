namespace BinaryTree
{
    class Program
    {
        static void Main (String[] args)
        {
            Console.WriteLine("Binary Tree Search ");
            BinarySearchTree<int> BinaryTree = new BinarySearchTree<int>();

            BinaryTree.AddNode(56);
            BinaryTree.AddNode(30);
            BinaryTree.AddNode(70);
            BinaryTree.AddNode(22);
            BinaryTree.AddNode(40);
            BinaryTree.AddNode(11);
            BinaryTree.AddNode(63);
            BinaryTree.AddNode(67);
            BinaryTree.AddNode(16);
            BinaryTree.AddNode(60);
            BinaryTree.AddNode(95);
            BinaryTree.AddNode(65);
            BinaryTree.AddNode(3);

            //int Size = BinaryTree.GetSize();
            //Console.WriteLine(Size);

            bool result = BinaryTree.SearchKey(63);
            Console.WriteLine(result);

            bool result1 = BinaryTree.SearchKey(55);
            Console.WriteLine(result1);

        }
    }

}