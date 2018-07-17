using System;

namespace DoublyLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList Playlist = new DoublyLinkedList();
            Playlist.Add(8).Add(9).Add(11);
            Playlist.Reverse();
            Playlist.Display();
            Console.WriteLine("Hello World!");
        }
    }
}
