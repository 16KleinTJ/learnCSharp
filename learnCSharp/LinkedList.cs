using System;

namespace learnCSharp
{
    public class LinkedList
    {
        public ListNode first { get; }

        /* This is the constructor equivalent to def __init__(self, data) */
        public LinkedList(int data)
        {
            first = new ListNode(data, null);
        }

        public bool append(int data)
        {
            ListNode finalNode;

            finalNode = this.getLast();
            /* Set the pointer of the last list item to the new node */
            finalNode.next = new ListNode(data, finalNode);

            return true;
        }

        private ListNode getLast()
        {
            ListNode n;
            /* How do we return the final node? 
             * If you want to test in your program remember to make it public
             */

            /* 
             * Walk along the list, until the pointer next is null
             */
            n = this.first;

            while (n.next != null)
                n = n.next;
            return n;
        }

        public ListNode findItem(int data)
        {
            /* Return null if you can't find the item */

            /* make this! */
            var currentNode = first;
            while (currentNode != null)
            {
                if (currentNode.data > data)
                    currentNode = currentNode.next;
                else if (currentNode.data < data)
                    currentNode = currentNode.previous;
                else if (currentNode.data == data)
                    return currentNode;
            }
            return null;
        }

        public void deleteItem(int data)
        {
            ListNode n;

            n = this.findItem(data);

            n.previous.next = n.next;
            n.next.previous = n.previous;

            /* n is now orphaned */
        }

        public void printAll()
        {
            /* do something */
            var currentNode = first;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }

        }

    }
}
