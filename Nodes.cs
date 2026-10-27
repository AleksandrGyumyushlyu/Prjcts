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

        public Node<T> CopyList()
        {
            Node<T> curr = this;
            Node<T> cpHead = new Node<T>(this.GetValue());
            Node<T> cpCurr = cpHead;

            curr = curr.GetNext();

            while (curr != null)
            {
                cpCurr.SetNext(new Node<T>(curr.GetValue()));
                cpCurr = cpCurr.GetNext();

                curr = curr.GetNext();
            }

            return cpHead;
        }

        public Node<T> GetLastNode()
        {
            Node<T> current = this;

            while (current.GetNext() != null)
            {
                current = current.GetNext();
            }

            return current;
        }

        public static Node<T> BuildList(T[] arr)
        {
            Node<T> head = null;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                head = new Node<T>(arr[i], head);
            }

            return head;
        }

        public string ListToString()
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

    public class NodeFuncs
    {
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

        public static void AddNode<T>(Node<T> prev, Node<T> newNode)
        {
            if (prev.GetNext() != null)
            {
                newNode.SetNext(prev.GetNext());
                prev.SetNext(newNode);
            }
            else
            {
                newNode.SetNext(null);
                prev.SetNext(newNode);
            }
        }

        public static Node<T> RemoveNode<T>(Node<T> head, Node<T> node)
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
                return curr;
            }
            else if (curr.GetNext() != null)
            {
                prev = new Node<T>(head.GetValue());
                curr = head.GetNext();
                head.SetValue(curr.GetValue());
                head.SetNext(curr.GetNext());
                curr.SetNext(null);

                return prev;
            }
            else
            {
                return null;
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
                if (curr.GetValue() == num)
                {
                    tmp = curr.GetNext();
                    RemoveNode(head, curr);
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

        public static Node<int> CopyUniqVals(Node<int> head)
        {
            Node<int> curr = head;
            Node<int> uniquesNode = new Node<int>(head.GetValue());
            Node<int> uniqCurr = uniquesNode;

            curr = curr.GetNext();

            while (curr != null)
            {
                if (!IsIn(uniquesNode, curr.GetValue()))
                {
                    uniqCurr.SetNext(new Node<int>(curr.GetValue()));
                    uniqCurr = uniqCurr.GetNext();
                }

                curr = curr.GetNext();
            }

            return uniquesNode;
        }

        public static bool IsInRisingOrder(Node<int> head)
        {
            Node<int> curr = head;

            while (curr.GetNext() != null)
            {
                if (curr.GetValue() >= curr.GetNext().GetValue())
                {
                    return false;
                }

                curr = curr.GetNext();
            }

            return true;
        }

        public static string ToStrInRising(Node<int> head)
        {
            Node<int> curr = head.GetNext();
            string listToString = head.ToString();
            int prevNum = head.GetValue();

            while (curr != null)
            {
                if (curr.GetValue() > prevNum)
                {
                    listToString += ", " + curr.ToString();
                }

                prevNum = curr.GetValue();
                curr = curr.GetNext();
            }

            return listToString;
        }

        public static Node<int> CreateOrder(int begginner, int num)
        {
            int currNum = begginner + 1;
            Node<int> head = new Node<int>(begginner);
            Node<int> curr = head;

            for (int i = 1; i < num; i++, currNum++)
            {
                curr.SetNext(new Node<int>(currNum));
                curr = curr.GetNext();
            }

            return head;
        }

        public static Node<int> RecordBackwardList()
        {
            Node<int> head = null;
            string input;
            int num = 0;

            Console.WriteLine("Enter integers to put into a list, type -999 to stop.");
            while (num != -999)
            {
                Console.Write("Enter an integer: ");
                input = Console.ReadLine();
                if (Funcs.IsInt(input))
                {
                    num = int.Parse(input);
                    if (num != -999)
                    {
                        head = new Node<int>(num, head);
                    }
                }
                else
                {
                    Console.Write("Input isn't an integer, try again: ");
                }
            }

            if (head != null)
            {
                return head;
            }
            else
            {
                return new Node<int>(0);
            }
        }

        public static bool IsBalanced(Node<int> head)
        {
            Node<int> curr = head;
            double listAvg = (double)(NodeFuncs.SumNodes(head) / NodeFuncs.CountNodes(head));
            int belowAvgCount = 0;
            int aboveAvgCount = 0;

            while (curr != null)
            {
                if (curr.GetValue() > listAvg)
                {
                    aboveAvgCount++;
                }
                else if (curr.GetValue() < listAvg) // what if there's value that equals to average?
                {
                    belowAvgCount++;
                }

                curr = curr.GetNext();
            }

            return belowAvgCount == aboveAvgCount;
        }

        public static Node<int> FindBiggestNum(Node<int> head)
        {
            Node<int> curr = head.GetNext();
            Node<int> biggestNode = head;
            int biggestNum = head.GetValue();

            while (curr != null)
            {
                if (curr.GetValue() > biggestNum)
                {
                    biggestNum = curr.GetValue();
                    biggestNode = curr;
                }
                curr = curr.GetNext();
            }

            return biggestNode;
        }

        public static Node<int> RemoveBiggest(Node<int> head, int n)
        {
            if (n == 0)
            {
                return head;
            }
            else
            {
                NodeFuncs.RemoveNode(head, NodeFuncs.FindBiggestNum(head));
                return NodeFuncs.RemoveBiggest(head, n - 1);
            }
        }

        public static int CountCharOccurs(Node<char> head, char occurence)
        {
            Node<char> curr = head;
            int countOccurences = 0;

            while (curr != null)
            {
                if (curr.GetValue() == occurence)
                {
                    countOccurences++;
                }

                curr = curr.GetNext();
            }

            return countOccurences;
        }

        public static int[] CountAbcs(Node<char> abcs)
        {
            int[] abcsCount = new int[26];

            for (int i = 0; i < abcsCount.Length; i++)
            {
                abcsCount[i] = CountCharOccurs(abcs, (char)(i + 'A')) + CountCharOccurs(abcs, (char)(i + 'a'));
            }

            return abcsCount;
        }

        public static int CountNameAppearance(Node<string> namesList, string name)
        {
            Node<string> currName = namesList;
            int nameCount = 0;
            name += ' ';

            while (currName != null)
            {
                if (EngUtils.FindInString(currName.GetValue(), name))
                {
                    nameCount++;
                }

                currName = currName.GetNext();
            }

            return nameCount;
        }

        public static Node<T> ReverseList<T>(Node<T> head)
        {
            Node<T> newHead = head.GetLastNode();
            NodeFuncs.ReverseList(head, head.GetNext());
            head.SetNext(null);

            return newHead;
        }

        private static void ReverseList<T>(Node<T> prev, Node<T> curr)
        {
            if (curr.GetNext() == null)
            {
                curr.SetNext(prev);
                return;
            }

            ReverseList(curr, curr.GetNext());
            curr.SetNext(prev);
        }

        public static Node<string> AbcSort(Node<string> head)
        {
            Node<string> curr = head;

            while (curr.GetNext() != null)
            {
                if (EngUtils.DictionaryOrder(curr.GetValue(), curr.GetNext().GetValue()) == curr.GetNext().GetValue())
                {
                    return curr;
                }

                curr = curr.GetNext();
            }

            return null;
        }

        // NOTE:
        // Task 22:
        // Paragraph A:
        // Example for 1 is: <any number>->null, example for 2: <any number>-><anynumber>->null
        // Paragraph B:
        // The function will return 1 if the length of the list is ODD (e.g. if there's only 1 node, or only 3 nodes)
        // because num is 2 in the beggining, then after first iteration it's 3-2=1, after second it's 3-1=2, so it's either 1 or 2

        public static Node<int> FindIn(Node<int> node, int value)
        {
            while (node != null)
            {
                if (node.GetValue() == value)
                {
                    return node;
                }

                node = node.GetNext();
            }

            return null;
        }

        public static bool HasOrder(Node<int> head, int n)
        {
            Node<int> curr = head;
            int orderCount = 1;

            while (curr.GetNext() != null)
            {
                if (curr.GetValue() + 1 == curr.GetNext().GetValue())
                {
                    orderCount++;
                }
                else
                {
                    orderCount = 1;
                }

                if (orderCount == n)
                {
                    return true;
                }

                curr = curr.GetNext();
            }

            return false;
        }

        public static void swapValues<T>(Node<T> node1, Node<T> node2)
        {
            Node<T> tmp = new Node<T>(node1.GetValue());
            node1.SetValue(node2.GetValue());
            node2.SetValue(tmp.GetValue());
        }

        public static void NeverOddOrEven(Node<int> head)
        {
            Node<int> curr = head;
            Node<int> odd = null;
            bool inSearch = false;

            while (curr != null)
            {
                if (curr.GetValue() % 2 == 1 && !inSearch)
                {
                    odd = curr;
                    inSearch = true;
                    curr = curr.GetNext();
                }
                else if (curr.GetValue() % 2 == 0 && inSearch)
                {
                    NodeFuncs.swapValues(odd, curr);
                    inSearch = false;
                    curr = odd.GetNext();
                }
                else
                {
                    curr = curr.GetNext();
                }
            }
        }

        public static void CutSeries(Node<int> head)
        {
            Node<int> curr = head;
            Node<int> next = head.GetNext();

            while (curr != null && (next = curr.GetNext()) != null && next.GetNext() != null)
            {
                if (curr.GetValue() == next.GetValue() &&
                    curr.GetValue() == next.GetNext().GetValue() &&
                    next.GetValue() == next.GetNext().GetValue())
                {
                    while ((next = curr.GetNext()) != null && next.GetValue() == curr.GetValue())
                    {
                        NodeFuncs.RemoveNode(curr, next);
                    }

                    if (next != null)
                    {
                        NodeFuncs.RemoveNode(curr, curr);
                    }
                    else
                    {
                        NodeFuncs.RemoveNode(head, curr);
                    }
                }
                else
                {
                    curr = curr.GetNext();
                }
            }
        }
    }
}
