using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalsPalindromeLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //keep two pointers
            //slow move one node
            //fast moves 2 nodes at one time
            //fast or fast.next  becomes null, slow will be at mid

            // Pushing data in the linked list.

            //test1
            //not palindrome even
            LinkedList listEven = new LinkedList();
            listEven.add(5);

            listEven.add(4); listEven.add(3); listEven.add(2); listEven.add(1); listEven.add(5);
            Console.WriteLine(isPalindromeLinkedList(listEven));

            //test 2
            // palindrome even
            LinkedList listEven2 = new LinkedList();
            listEven2.add(5);

            listEven2.add(4); listEven2.add(3); listEven2.add(3); listEven2.add(4); listEven2.add(5);
            Console.WriteLine(isPalindromeLinkedList(listEven2));
            Console.WriteLine();

            //test 3
            //not palindrome odd
            LinkedList listOdd = new LinkedList();
           listOdd.add(5);

           listOdd.add(4); listOdd.add(3); listOdd.add(2); listOdd.add(1);
           Console.WriteLine(isPalindromeLinkedList(listOdd));

            //test 4
           // palindrome even
           LinkedList listOdd2 = new LinkedList();
           listOdd2.add(5);

           listOdd2.add(4); listOdd2.add(3);  listOdd2.add(4); listOdd2.add(5);
           Console.WriteLine(isPalindromeLinkedList(listOdd2));
           Console.WriteLine();
 

        }
        static Boolean isPalindromeLinkedList(LinkedList list)
        {
            if (list.head == null || list.head.next == null)
            {
                return true;
            }
            else
            {
                Node slow = list.head;
                Node fast = list.head;
                Stack<int> s = new Stack<int>();  //to store the elements till te mid node
                while (fast != null && fast.next != null)
                {
                    s.Push(slow.data);
                    slow = slow.next;
                    fast = fast.next.next;

                }
                //for even numbers slow is at mid
                //for odd, move one node ahead
                // 1 3 5 3 1
                // s s s
                // f   f   f 
                // fast is Not null

                //for even numbers slow is at mid

                // 1 3 5 4 3 1
                // s s s s 
                // f   f   f    f
                // fast is null

                if (fast!= null)
                {
                    slow = slow.next;
                }

                while (slow != null)
                {
                    int num = slow.data;
                    int numInStack = s.Pop();
                    if (num != numInStack)
                    {
                        return false;
                    }
                    slow = slow.next;
                }
                return true;
            }

        }
    }
        //create a single linked list
        class Node
        {
            public int data;
            public Node next, random; //next and random pointers
            public Node(int data)
            {
                this.data = data;
                this.next = null;
                this.random = null;

            }
        }
        class LinkedList
        {
            public Node head;
            //constructor
            public LinkedList()
            {
                this.head = null;

            }
            public LinkedList(Node h)
            {
                this.head = h;
            }

            //add a node
            public void add(int data)
            {
                Node newNode = new Node(data); //create a node
                //check if head is null
                if (this.head == null)
                {
                    this.head = newNode;
                }
                else
                {
                    Node current = head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = newNode;
                }
            }
            // Method to print the list.
            public void print()
            {
                Node temp = head;
                while (temp != null)
                {
                    //  Node random = temp.random;
                    //   int randomData = (random != null) ? random.data : -1;
                    Console.WriteLine("Data = " + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
    

