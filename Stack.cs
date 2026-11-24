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
            Stack<T> s = new Stack<T>();
            for (int i = 0; i < arr.Length; i++)
            {
                s.Push(arr[i]);
            }

            return s;
        }

        public static Stack<T> BuildStackR<T>(T[] arr)
        {
            Stack<T> s = new Stack<T>();
            for (int i = arr.Length - 1; i >= 0; i++)
            {
                s.Push(arr[i]);
            }

            return s;
        }

        public static Stack<T> CopyStack<T>(Stack<T> s)
        {
            Stack<T> newStack = new Stack<T>();
            Stack<T> tempStack = new Stack<T>();

            while (!s.IsEmpty())
            {
                tempStack.Push(s.Pop());
            }

            while (!tempStack.IsEmpty())
            {
                newStack.Push(tempStack.Top());
                s.Push(tempStack.Pop());
            }

            return newStack;
        }

        public static bool SearchInt(Stack<int> s, int x)
        {
            Stack<int> stk = CopyStack(s);

            while(!stk.IsEmpty())
            {
                if (stk.Pop() == x)
                    return true;
            }
            return false;
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

            firstItem = s.Pop();

            while(!s.IsEmpty())
            {
                tmp.Push(s.Pop());
            }

            s.Push(firstItem);
            while(!tmp.IsEmpty())
            {
                s.Push(tmp.Pop());
            }
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
                Console.WriteLine();
                if (xIn - '0' >= 2 && xIn - '0' <= 9)
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

        public static bool AreSimilar(Stack<int> s1, Stack<int> s2)
        {
            Stack<int> c1 = CopyStack(s1);
 
            while (!c1.IsEmpty())
            {
                if (!SearchInt(s2, c1.Pop()))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AreEqual<T>(T val1, T val2)
        {
            return EqualityComparer<T>.Default.Equals(val1, val2);
        }

        public static bool IsIn<T>(Stack<T> s, T val)
        {
            Stack<T> tmp = new Stack<T>();

            while (!s.IsEmpty())
            {
                tmp.Push(s.Pop());
                if (AreEqual(tmp.Top(), val))
                {
                    return true;
                }
            }

            while (!tmp.IsEmpty())
            {
                s.Push(tmp.Pop());
            }

            return false;
        }

        public static bool IsInRecursive<T>(Stack<T> s, T val)
        {
            return IsInRecursive(s, val, CopyStack(s));
        }

        public static bool IsInRecursive<T>(Stack<T> s, T val, Stack<T> tmp)
        {
            if (tmp.IsEmpty())
            {
                return false;
            }

            if (AreEqual(val, tmp.Pop()))
            {
                return true;
            }
            else
            {
                return IsInRecursive(s, val, tmp);
            }
        }

        public static bool AreSameRecursive<T>(Stack<T> s1, Stack<T> s2)
        {
            return AreSameRecursive(s1, s2, CopyStack(s1), CopyStack(s2));
        }

        public static bool AreSameRecursive<T>(Stack<T> s1, Stack<T> s2, Stack<T> tmp1, Stack<T> tmp2)
        {
            if (tmp1.IsEmpty() && tmp2.IsEmpty())
            {
                return true;
            }
            else if (tmp1.IsEmpty() || tmp2.IsEmpty())
            {
                return false;
            }

            if (!AreEqual(tmp1.Pop(),tmp2.Pop()))
            {
                return false;
            }

            return AreSameRecursive(s1, s2, tmp1, tmp2);
        }

        public static void RisesLowers(Stack<int> s)
        {
            Stack<int> tmp = new Stack<int>();
            bool firstIteration = true;
            int borderNum = 0;

            while (!s.IsEmpty())
            {
                tmp.Push(s.Pop());

                if (firstIteration)
                {
                    firstIteration = false;
                    borderNum = tmp.Top();
                }
                else
                {
                    if (tmp.Top() > borderNum)
                    {
                        borderNum = tmp.Top();
                    }

                }
            }

            while (!tmp.IsEmpty())
            {
                s.Push(tmp.Pop());
            }
        }

        public static void UnitTest1()
        {
            Stack<int> stack1 = BuildStack(Funcs.GenArr(17, 0, 100));
            Console.WriteLine(stack1);

            Stack<string> stack2 = BuildStack(["Cooking", "GitHub", "Stationery", "SomeBullshit"]);
            Stack<int> stack3 = BuildStack([2, 3, 5, 6]);
            Stack<int> stack4 = BuildStack([3, 2, 6, 5]);
            Console.WriteLine(stack2);

            Console.WriteLine($"Task5: {IsSorted(stack1)}");
            RoundAbout(stack1);
            Console.WriteLine($"Task6: {stack1}\n");

            // Console.WriteLine(BackX(stack2, "Back"));
            // Console.WriteLine(stack2);
            // // Does ReadKey and it's ANOYING
            // Console.WriteLine(BackX(stack2, "BackX"));
            // Console.WriteLine(stack2);

            Console.WriteLine(stack3);
            Console.WriteLine(stack4);
            Console.WriteLine(AreSimilar(stack3, stack4));

            Console.WriteLine(IsIn(stack2, "Cooking"));
            Console.WriteLine(IsIn(stack2, "Aboba"));

            // Console.WriteLine(IsIn(stack3, 3));
            // Console.WriteLine("Second");
            // Console.WriteLine(IsIn(stack3, 7));

            Console.WriteLine(IsInRecursive(stack3, 3));
            Console.WriteLine("Second");
            Console.WriteLine(IsInRecursive(stack3, 7));

            Console.WriteLine(AreSameRecursive(stack3, stack3));
            Console.WriteLine(AreSameRecursive(stack3, stack4));

            
        }
    }
}
