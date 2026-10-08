using Prjcts;
using System.ComponentModel;

namespace Prjcts
{
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

        public IntNode GetLastNode()
        {
            IntNode current = this;

            while (current.GetNext() != null)
            {
                current = current.GetNext();
            }

            return current;
        }

        public static string AllNodesToString(IntNode node)
        {
            string output = "";

            while (node != null)
            {
                output += node;
                if (node.GetNext() != null)
                    output += ", ";

                node = node.GetNext();
            }

            return output;
        }

        public static int Count(IntNode node)
        {
            int count = 0;
            while (node != null)
            {
                count++;
                node = node.GetNext();
            }
            return count;
        }

        public static int SumNodes(IntNode node)
        {
            int sum = 0;
            while (node != null)
            {
                sum += node.GetValue();
                node = node.GetNext();
            }
            return sum;
        }

        public static int CountOddValues(IntNode node)
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

        public static int GetDifference(IntNode node)
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

        public static bool IsPositive(IntNode node)
        {
            int negSum = 0;
            int posSum = 0;
            // Never neg or eveN
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

        public static bool IsIn(IntNode node, int num)
        {
            while (node != null)
            {
                if (node.GetValue() == num)
                {
                    return true;
                }

                node = node.GetNext();
            }

            return false;
        }

        public static bool IsInLesserOrder(IntNode node)
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

        public override string ToString()
        {
            return this.value.ToString();
        }
    }

    public class UnitTest()
    {
        public static void Test1()
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

            Console.WriteLine(IntNode.AllNodesToString(head));

            current = head;
            while (current.GetNext().GetNext() != null)
            {
                current = current.GetNext();
            }
            current.SetNext(null);

            Console.WriteLine(IntNode.AllNodesToString(head));
        }

        public static void Test2()
        {
            // TODO: Tests
        }
    }
}
