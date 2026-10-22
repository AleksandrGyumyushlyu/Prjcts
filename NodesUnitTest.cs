using Prjcts;
using System.ComponentModel;

namespace Prjcts
{
    public class UnitTest
    {
        public static void Launcher()
        {
            UnitTest.Test4();
        }

        public static void Test2()
        {
            Node<int> head = Node<int>.BuildList([42, 58, 49, 42, 13]);
            Node<int> tmp = null;

            Console.WriteLine($"1: {NodeFuncs.SumNodes(head)}\n2: {NodeFuncs.CountOddValues(head)}");
            Console.WriteLine($"3: {NodeFuncs.GetDifference(head)}\n4: {NodeFuncs.IsPositive(head)}");
            Console.WriteLine($"5 True: {NodeFuncs.IsIn(head, 49)}\n5 False: {NodeFuncs.IsIn(head, 45)}\n6 False: {NodeFuncs.IsInLesserOrder(head)}\n6 True: {NodeFuncs.IsInLesserOrder(head.GetNext())}");

            Console.WriteLine(head.ListToString());

            NodeFuncs.AddNode(head.GetLastNode(), 11);
            Console.WriteLine(head.ListToString());

            NodeFuncs.RemoveNode(head, head.GetLastNode());
            Console.WriteLine(head.ListToString());

            NodeFuncs.RemoveNode(head, head);
            Console.WriteLine(head.ListToString());
        }

        public static void Test3()
        {
            Node<int> head1 = Node<int>.BuildList([4, 5, 6, 6, 3, 4, 4, 4, 22, 3, 6]);
            Node<int> head2 = Node<int>.BuildList([1, 1, 1, 1, 1, 2, 1, 2, 2, 2]);
            Node<int> head3 = Node<int>.BuildList([5, 2, 3, 6, 7, 18, 20, 26]);
            Node<int> head4 = Node<int>.BuildList([3, 3, 7, 7]);
            Node<int> head5 = Node<int>.BuildList([3, 3, 5, 9]);

            Console.WriteLine(head1.ListToString());
            Console.WriteLine(head2.ListToString());
            Console.WriteLine(NodeFuncs.CountSeries(head1, 4));

            Console.WriteLine(NodeFuncs.EvenOddEqual(head1));
            Console.WriteLine(NodeFuncs.EvenOddEqual(head2));

            Console.WriteLine(NodeFuncs.RemoveNums(head1.CopyList(), 6).ListToString());
            Console.WriteLine(NodeFuncs.RemoveNums(head2.CopyList(), 1).ListToString());

            Console.WriteLine(NodeFuncs.CopyUniqVals(head2).ListToString());
            Console.WriteLine(NodeFuncs.CopyUniqVals(head1).ListToString());

            Console.WriteLine(NodeFuncs.IsInRisingOrder(head3)); // False
            Console.WriteLine(NodeFuncs.IsInRisingOrder(head3.GetNext())); // True

            Console.WriteLine(NodeFuncs.ToStrInRising(head1));

            Console.WriteLine(NodeFuncs.CreateOrder(2, 8).ListToString());

            Console.WriteLine(NodeFuncs.RecordBackwardList().ListToString());

            Console.WriteLine(NodeFuncs.IsBalanced(head1)); // False
            Console.WriteLine(NodeFuncs.IsBalanced(head4)); // True
            Console.WriteLine(NodeFuncs.IsBalanced(head5)); // False

            Console.WriteLine(NodeFuncs.RemoveBiggest(head3.CopyList(), 4).ListToString());
        }

        public static void Test4()
        {
            Node<char> charHead = Node<char>.BuildList(['a', 'A', 'a', 'b', 'c', 'd', 'd', 'e', 'e']);
            Node<string> nameList = Node<string>.BuildList(["Josh Daveson", "Joshua NoJoshua", "Josh Rajeshovich", "David Atsalal", "Josh UltraKill"]);
            Node<string> orderCheck = Node<string>.BuildList((["apple", "cat", "egg", "girl", "good", "luck", "love", "window"]));
            Node<int> intHead = Node<int>.BuildList([5, 6, 7, 8, 9, 18, 20, 26]);

            Console.WriteLine(NodeFuncs.CountCharOccurs(charHead, 'a'));
            Console.WriteLine(NodeFuncs.CountCharOccurs(charHead, 'e'));

            Funcs.PrintArray(NodeFuncs.CountAbcs(charHead));
            Console.WriteLine();

            Console.WriteLine(NodeFuncs.CountNameAppearance(nameList, "Josh"));

            nameList = NodeFuncs.ReverseList(nameList);
            Console.WriteLine(nameList.ListToString());

            Console.WriteLine(NodeFuncs.AbcSort(orderCheck));

            Console.WriteLine(NodeFuncs.HasOrder(intHead, 5));
        }
    }
}
