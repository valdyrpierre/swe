using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nodestubs;

public class NodeRoomNameList
{
    private NodeRoomName head;
    private int count;

    public NodeRoomNameList()
    {
        head = null;
        count = 0;
    }

    public void AddRoomNameToFront(string r)
    {
        NodeRoomName newNode = new NodeRoomName(r);
        newNode.next = head;
        head = newNode;
        count++;
    }
    public void displayCount()
    {
        Console.WriteLine("Total number of nodes: " + count);
    }

    // primarily for debugging
    public void PrintList()
    {
        NodeRoomName runner = head;
        while (runner != null)
        {
            Console.WriteLine(runner._roomName);
            runner = runner.next;
        }
    }
}