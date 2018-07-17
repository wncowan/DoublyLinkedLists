using System;

namespace DoublyLinkedLists
{
        public class DoublyLinkedList
        {
            public DllNode Head;
            // Place your methods here.
            public DoublyLinkedList Add(int value) 
            {
                DllNode newNode = new DllNode(value);
                if(Head == null) 
                {
                    Head = newNode;
                    return this;
                } 
                else
                {
                    DllNode runner = Head;
                    while(runner.Next != null) {
                        runner = runner.Next;
                    }
                    runner.Next = newNode;
                    newNode.Prev = runner;
                    return this;
                }
            } 
            public bool Remove(int value)
            {
                
                DllNode runner = Head;
                while(runner.Value != value && runner != null)
                {
                    runner = runner.Next;
                }
                if(runner == null){
                    return false;
                }
                else{
                    DllNode previousItem = runner.Prev;
                    previousItem.Next = runner.Next;
                    return true;
                }
            }
            public void Reverse()
            {
                DllNode runner = Head;
                while(runner != null)
                {
                    if(runner.Next == null)
                    {
                        Head = runner;
                    }
                    DllNode temp = runner.Prev;
                    DllNode tempNext = runner.Next;
                    runner.Prev = runner.Next;
                    runner.Next = temp;
                    runner = tempNext;
                }
                
            }
            public void Display()
            {
                DllNode runner = Head;
                while(runner != null)
                {
                    Console.WriteLine(runner.Value);
                    runner = runner.Next;
                }
            }
        }

}