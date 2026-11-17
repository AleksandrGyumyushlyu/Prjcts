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
            stash.SetNext(null);

            this.lastItem = this.lastItem.GetNext();
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
}
