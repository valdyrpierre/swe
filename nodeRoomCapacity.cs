using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nodestubs;


public class NodeRoomCapacity
{
    private NodeRoomCapacity head;
    public int count;

    public NodeRoomCapacity()
    {
        head = null;
        count = 0;
    }

    public void AddRoomCapacityToFront(int c)
    {
        newNode = new NodeRoomCapacity(c);
        newNode.next = head;
        head = newNode;
        count++;
    }

    public void displayCount()
    {
        Console.WriteLine("Total number of nodes: " + count);
    }

    // useful for debugging
    public void PrintList()
    {
        NodeRoomCapacity runner = head;
        while (runner != null)
        {
            Console.WriteLine(runner._roomName);
            runner = runner.next;
        }
    }

}