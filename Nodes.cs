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

            while (current.GetNext() != null)
            {
                current = current.GetNext();
            }

            current.SetNext(n4);

            current = head;

            while (current != null)
            {
                Console.Write(current);
                if (current.GetNext() != null)
                    Console.Write(", ");

                current = current.GetNext();
            }

            current = head;

            Console.WriteLine();

            while (current.GetNext().GetNext() != null)
            {
                current = current.GetNext();
            }

            current.SetNext(null);


            current = head;

            while (current != null)
            {
                Console.Write(current);
                if (current.GetNext() != null)
                    Console.Write(", ");

                current = current.GetNext();
            }

        }
    }
}
