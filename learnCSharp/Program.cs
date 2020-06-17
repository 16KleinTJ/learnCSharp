using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace learnCSharp
{
    class Program
    {
        static void Main(String[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 = Sorting\n2 = Binary Tree\n3 = Linked List");
                var userInput = Console.ReadKey().KeyChar;
                switch (userInput)
                {
                    case '1':
                        Sort();
                        break;
                    case '2':
                        binaryTree();
                        break;
                    case '3':
                        doLinkedList();
                        break;
                    default:
                        Console.WriteLine("\nInvalid input");
                        break;
                }
            }
        }

        static void graph()
        {
            GraphNode<String> london = new GraphNode<String>("London");
            GraphNode<String> edinburgh = new GraphNode<String>("Edinburgh");

            london.ConnectTo(edinburgh, 650);

            // What is London connected to first?
            Console.Out.WriteLine(london.Edges[0].OtherNode(london).Data);
        }

        static void binaryTree()
        {
            Console.Clear();

            var bTree = new BinaryTree<int>(5);

            bTree.Add(10);

            bTree.Add(3);

            bTree.InOrder();

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        static void schoolDirectory()
        {
            Teacher teacher;
            Pupil[] pupil = new Pupil[1000];    // In release code, you'd definitely not
                                                // hardcode this, you'd use a List or similar!

            teacher = new Teacher("John Jones", "L5");

            teacher.eyeColour = Teacher.colour.BLUE;

            Console.Out.WriteLine("Teacher's name is " + teacher.name);

            pupil[0] = new Pupil("James Earl Jones");

            Console.Out.WriteLine("Pupil 0's name is " + pupil[0].name);
        }

        static void doLinkedList()
        {
            LinkedList l;
            ListNode tmp;

            l = new LinkedList(1); // create a new list

            l.append(5); // add 5 & 10 to the list
            l.append(10);


            l.printAll(); // print the contents of the completed list

            tmp = l.first;
            Console.Out.WriteLine(tmp.data);
            while ((tmp = tmp.next) != null)
                Console.Out.WriteLine(tmp.data);

            l = null;

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        static void Sort()
        {
            Console.Clear();

            char response;

            Console.WriteLine("Please let me know what kinda sort you would like (i)nsertion sort, or (b)ubble sort, or (q)uit");
            for (; ; )
            {
                response = Console.ReadKey().KeyChar;
                switch (response)
                {
                    case 'i':
                    case 'I':
                        InsertionSort();
                        break;
                    case 'b':
                    case 'B':
                        BubbleSort();
                        break;
                    case 'q':
                    case 'Q':
                        return;
                    /* NOTREACHED */
                    default:
                        Console.WriteLine("Um, what are you playing at?");
                        break;
                }
            }
        }
        static void BubbleSort()
        {
            var List = new SortingList(10);
            List.Randomise();
            List.Print();

            while (true) // loops forever until break is called
            {
                bool swapped = false; // init a boolean to track whether any swaps have been made
                for (int i = 0; i < List.Length - 1; i++) // for the entirety of the list, minus one (so that the final element is not compared against nothing)
                {
                    if (List.list[i] > List.list[i + 1]) // compare the current element to the element to it's right
                    {
                        swapped = true; // sets the swapped bool to true indicating that a swap has been made
                        var tempvar = List.list[i]; // store the current element in the array
                        List.list[i] = List.list[i + 1]; // overwrites the current element with the smaller value
                        List.list[i + 1] = tempvar; // move the larger value to i + 1
                    }
                }
                List.Print();
                if (!swapped) // if swapped is false (indicating that no swaps have been made) the list is sorted
                {
                    break; // break is called to end the loop
                }
            }
        }
        static void InsertionSort()
        {
            var unsortedList = new SortingList(10);
            var sortedList = new SortingList(unsortedList.Length);

            /* Let's fill the unsorted list with all sorts of junk */
            unsortedList.Randomise();
            unsortedList.Print();

            /* This is where we do the insertion sort-- doesn't
             * object oriented make this look easy? */

            for (int i = 0; i < unsortedList.Length; i++)
            {
                sortedList.Insert(unsortedList.Pop());
            }

            sortedList.Print();
        }
    }
}
