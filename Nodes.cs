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

        /// <summary>Gets to the last node from current one</summary>
        /// <returns>Last node in the list</returns>
        public IntNode GetLastNode()
        {
            IntNode current = this;

            while (current.GetNext() != null)
            {
                current = current.GetNext();
            }

            return current;
        }

        /// <summary>Turns all nodes from current one to the end to string</summary>
        /// <param name="node">First node to turn to string</param>
        /// <returns>String with all _values_ of the nodes in the list</returns>
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

        /// <summary>Override regular to string to print the node's value</summary>
        /// <returns>Value in string</returns>
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
    }
}
