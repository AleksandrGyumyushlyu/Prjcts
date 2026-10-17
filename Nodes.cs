using Prjcts;
using System.ComponentModel;

namespace Prjcts
{
    public class Node<T>
    {
        private T value;
        private Node<T> next;

        public Node(T value, Node<T> next = null)
        {
            this.value = value;
            this.next = next;
        }

        public T GetValue() { return this.value; }
        public Node<T> GetNext() { return this.next; }

        public void SetValue(T value) { this.value = value; }
        public void SetNext(Node<T> next) { this.next = next; }

        public Node<T> CopyNode() { return new Node<T>(this.value, this.next); }

        public Node<T> GetLastNode()
        {
            Node<T> current = this;

            while (current.GetNext() != null)
            {
                current = current.GetNext();
            }

            return current;
        }

        public static Node<T> BuildNode(T[] arr)
        {
            Node<T> head = null;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                head = new Node<T>(arr[i], head);
            }

            return head;
        }

        public string AllNodesToString()
        {
            Node<T> curr = this;
            string output = "";

            while (curr != null)
            {
                output += curr;
                if (curr.GetNext() != null)
                    output += ", ";

                curr = curr.GetNext();
            }

            return output;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }

    }

    public class IntNode
    {
        private int value;
        private IntNode next;

        public IntNode(int value) { this.value = value; this.next = null; }
        public IntNode(int value, IntNode next) { this.value = value; this.next = next; }

        public int GetValue() { return this.value; }
        public IntNode GetNext() { return this.next; }

        public void SetValue(int value) { this.value = value; }
        public void SetNext(IntNode next) { this.next = next; }

        public IntNode CopyNode() { return new IntNode(this.value, this.next); }

        public IntNode GetLastNode()
        {
            IntNode current = this;

            while (current.GetNext() != null)
            {
                current = current.GetNext();
            }

            return current;
        }

        public static IntNode BuildNode(int[] arr)
        {
            IntNode head = null;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                head = new IntNode(arr[i], head);
            }

            return head;
        }

        public string AllNodesToString()
        {
            IntNode curr = this;
            string output = "";

            while (curr != null)
            {
                output += curr;
                if (curr.GetNext() != null)
                    output += ", ";

                curr = curr.GetNext();
            }

            return output;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }
    }

    public class UnitTest()
    {
        public static void Launcher()
        {
            UnitTest.Test3();
        }

        public static int CountNodes<T>(Node<T> head)
        {
            Node<T> curr = head;
            int count = 0;

            while (curr != null)
            {
                count++;
                curr = curr.GetNext();
            }
            return count;
        }

        public static int SumNodes(Node<int> node)
        {
            int sum = 0;

            while (node != null)
            {
                sum += node.GetValue();
                node = node.GetNext();
            }
            return sum;
        }

        public static int CountOddValues(Node<int> node)
        {
            int count = 0;

            while (node != null)
            {
                if (node.GetValue() % 2 != 0)
                {
                    count++;
                }

                node = node.GetNext();
            }
            return count;
        }

        public static int GetDifference(Node<int> node)
        {
            int oddSum = 0;
            int evenSum = 0;
            // Never odd or eveN
            while (node != null)
            {
                if (node.GetValue() % 2 == 0)
                {
                    evenSum += node.GetValue();
                }
                else
                {
                    oddSum += node.GetValue();
                }

                node = node.GetNext();
            }

            return Math.Abs(evenSum - oddSum);
        }

        public static bool IsPositive(Node<int> node)
        {
            int negSum = 0;
            int posSum = 0;
            // Never odd or eveN
            while (node != null)
            {
                if (node.GetValue() >= 0)
                {
                    posSum += node.GetValue();
                }
                else
                {
                    negSum += node.GetValue();
                }

                node = node.GetNext();
            }

            return posSum >= negSum;
        }

        public static bool IsIn(Node<int> node, int value)
        {
            while (node != null)
            {
                if (node.GetValue() == value)
                {
                    return true;
                }

                node = node.GetNext();
            }

            return false;
        }

        public static bool IsInLesserOrder(Node<int> node)
        {
            while (node.GetNext() != null)
            {
                if (node.GetValue() < node.GetNext().GetValue())
                {
                    return false;
                }

                node = node.GetNext();
            }

            return true;
        }

        public static void AddNode<T>(Node<T> prev, T value)
        {
            if (prev.GetNext() != null)
            {
                prev.SetNext(new Node<T>(value, prev.GetNext()));
            }
            else
            {
                prev.SetNext(new Node<T>(value));
            }
        }

        public static void RemoveNode<T>(Node<T> head, Node<T> node)
        {
            Node<T> curr = head;
            Node<T> prev = null;

            if (curr != node)
            {
                while (curr != node)
                {
                    prev = curr;
                    curr = curr.GetNext();
                }

                prev.SetNext(curr.GetNext());
                curr.SetNext(null);
                curr = null;
            }
            else
            {
                curr = head.GetNext();
                head.SetValue(curr.GetValue());
                head.SetNext(curr.GetNext());
                curr.SetNext(null);
            }
        }

        public static int CountSeries(Node<int> head, int num)
        {
            Node<int> curr = head;
            int seriesCount = 0;
            bool isSeries = false;

            while (curr != null)
            {
                if (isSeries)
                {
                    if (curr.GetValue() != num)
                    {
                        isSeries = false;
                        seriesCount++;
                    }
                }
                else
                {
                    if (curr.GetValue() == num)
                    {
                        isSeries = true;
                        if (curr.GetNext() == null)
                        {
                            seriesCount++;
                        }
                    }
                }

                curr = curr.GetNext();
            }

            return seriesCount;
        }

        public static char EvenOddEqual(Node<int> head)
        {
            Node<int> curr = head;
            int evenCount = 0;
            int oddCount = 0;

            while (curr != null)
            {
                if (curr.GetValue() % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }

                curr = curr.GetNext();
            }

            if (evenCount == oddCount)
            {
                return 's';
            }
            else
            {
                return evenCount > oddCount ? 'z' : 'e';
            }
        }

        public static Node<int> RemoveNums(Node<int> head, int num)
        {
            Node<int> curr = head;
            Node<int> tmp = null;

            while (curr != null)
            {
                Console.WriteLine("loop");
                if (curr.GetValue() == num)
                {
                    tmp = curr.GetNext();
                    RemoveNode(head,curr);
                    if (curr.GetNext() == null)
                    {
                        curr = tmp;
                    }
                }
                else
                {
                    curr = curr.GetNext();
                }
            }

            return head;
        }

        public static void IntNodeTest1()
        {

            IntNode n1 = new IntNode(42);
            IntNode n2 = new IntNode(3);
            IntNode n3 = new IntNode(51);
            IntNode head = n1;
            IntNode current = null;

            n1.SetNext(n2);
            n2.SetNext(n3);

            n1 = null;
            n2 = null;
            n3 = null;

            IntNode n4 = new IntNode(99);

            current = head;
            current = head.GetLastNode();
            current.SetNext(n4);

            Console.WriteLine(head.AllNodesToString());

            current = head;
            while (current.GetNext().GetNext() != null)
            {
                current = current.GetNext();
            }
            current.SetNext(null);

            Console.WriteLine(head.AllNodesToString());
        }

        public static void Test2()
        {
            Node<int> head = Node<int>.BuildNode( [42, 58, 49, 42, 13] );
            Node<int> tmp = null;

            Console.WriteLine($"1: {UnitTest.SumNodes(head)}\n2: {UnitTest.CountOddValues(head)}");
            Console.WriteLine($"3: {UnitTest.GetDifference(head)}\n4: {UnitTest.IsPositive(head)}");
            Console.WriteLine($"5 True: {UnitTest.IsIn(head, 49)}\n5 False: {UnitTest.IsIn(head, 45)}\n6 False: {UnitTest.IsInLesserOrder(head)}\n6 True: {UnitTest.IsInLesserOrder(head.GetNext())}");

            Console.WriteLine(head.AllNodesToString());
            
            AddNode(head.GetLastNode(), 11);
            Console.WriteLine(head.AllNodesToString());
            
            RemoveNode(head, head.GetLastNode());
            Console.WriteLine(head.AllNodesToString());

            RemoveNode(head, head);
            Console.WriteLine(head.AllNodesToString());
        }

        public static void Test3()
        {
            Node<int> head1 = Node<int>.BuildNode([4, 5, 6, 6, 3, 4, 4, 4, 22, 3, 6]);
            Node<int> head2 = Node<int>.BuildNode([1,1,1,1,1,2,1,2,2,2]);
            Console.WriteLine(head1.AllNodesToString());
            Console.WriteLine(CountSeries(head1, 4));

            Console.WriteLine(EvenOddEqual(head1));
            Console.WriteLine(EvenOddEqual(head2));

            Console.WriteLine(RemoveNums(head1, 6).AllNodesToString());
            Console.WriteLine(RemoveNums(head2, 1).AllNodesToString());
        }
    }
}
