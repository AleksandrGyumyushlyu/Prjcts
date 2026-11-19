using Prjcts;

namespace Prjcts
{
    public class Stack<T>
    {
        private Node<T> lastItem;

        public Stack()
        {
            this.lastItem = null;
        }

        public Stack(T value)
        {
            this.lastItem = new Node<T>(value);
        }

        public bool IsEmpty()
        {
            return this.lastItem == null;
        }

        public void Push(T value)
        {
            if (this.IsEmpty())
            {
                this.lastItem = new Node<T>(value);
            }
            else
            {
                this.lastItem = new Node<T>(value, this.lastItem);
            }
        }

        public T Pop()
        {
            Node<T> stash;

            stash = this.lastItem;
            this.lastItem = this.lastItem.GetNext();
            stash.SetNext(null);

            return stash.GetValue();
        }

        public T Top()
        {
            return this.lastItem.GetValue();
        }

        public override string ToString()
        {
            string allItems = "[";
            Node<T> curr = this.lastItem;

            if (!IsEmpty())
            {
                while (curr.GetNext() != null)
                {
                    allItems += curr.GetValue().ToString() + ", ";
                    curr = curr.GetNext();
                }
                allItems += curr.GetValue().ToString();
            }

            allItems += "]";
            return allItems;
        }
    }

    public class StackPractice
    {
        public static void Launcher()
        {
            StackPractice.UnitTest1();
        }

        public static Stack<T> BuildStack<T>(T[] arr)
        {

        }

        public static bool IsSorted(Stack<int> s)
        {
            bool isSorted = true;
            Stack<int> tmp = new Stack<int>();
            int currNum = 0;
            int prevNum = 0;

            if (!s.IsEmpty())
            {
                prevNum = s.Pop();
                tmp.Push(prevNum);
            }

            while(!s.IsEmpty())
            {
                currNum = s.Pop();
                tmp.Push(currNum);
                if (currNum < prevNum)
                {
                    isSorted = false;
                }

                prevNum = currNum;
            }

            while(!tmp.IsEmpty())
            {
                currNum = tmp.Pop();
                s.Push(currNum);
            }

            return isSorted;
        }

        public static void RoundAbout<T>(Stack<T> s)
        {
            Stack<T> tmp = new Stack<T>();
            T firstItem;

            while (!s.IsEmpty())
            {
                tmp.Push(s.Pop());
            }

            firstItem = tmp.Pop();

            while (!tmp.IsEmpty())
            {
                s.Push(tmp.Pop());
            }
            s.Push(firstItem);
        }

        public static string BackX(Stack<string> addresses, string arg)
        {
            Stack<string> tmp = new Stack<string>();
            string seekedAddress;
            int xNum;
            char xIn;

            if (arg != "BackX" && arg != "Back")
            {
                Console.WriteLine($"option error: \"{arg}\" isn't an option");
                return "";
            }
            else if (arg == "BackX")
            {
                Console.Write("Enter number 2-9: ");
                xIn = Console.ReadKey().KeyChar;
                if (xIn - '0' >= 2 || xIn - '0' <= 9)
                {
                    xNum = xIn - '0';
                }
                else
                {
                    Console.WriteLine($"number error: you can't get \"{xIn}\" addresses back");
                    return "";
                }

                for (int i = 0; i < xNum && !addresses.IsEmpty(); i++)
                {
                    tmp.Push(addresses.Pop());
                }

                if (!tmp.IsEmpty())
                {
                    seekedAddress = tmp.Top();
                }
                else
                {
                    Console.WriteLine("stack error: there is no address to return to");
                    seekedAddress = "";
                }

                return seekedAddress;
            }
            else
            {
                return addresses.Pop();
            }

        }

        public static void UnitTest1()
        {
            Random rnd = new Random();
            Stack<int> stack1 = new Stack<int>();
            for (int i = 0; i < 17; i++)
            {
                stack1.Push(rnd.Next(0, 100));
            }

            Stack<string> stack2 = newStack<string>();
            Console.WriteLine(stack1);

            Console.WriteLine($"Task5: {IsSorted(stack1)}");
            RoundAbout(stack1);
            Console.WriteLine($"Task6: {stack1}");
        }
    }
}
