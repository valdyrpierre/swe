using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using room;


// this will get the information about the room
// consolidates information about the session


public class PopulateRoom
{
    List<string> nodeRoomNameList = new List<string>();
    List<int> nodeRoomCapacityList = new List<int>();
    public String RoomNames { get; protected set; }
    public int RoomCapacity { get; protected set; }

    // adding a default constructor
    public PopulateRoom()
    {

    }

    // method to add room name
    public void addRoomName(string r)
    {
        // i will add room name there will get help from doc

    }
    // method to add room capacity
    public void addRoomCapacity(int c)
    {
        // i will add room capacity there will get help from doc

    }

    // method to display room list and campacity for debugging
    public void displayRoomList()
    {
        // this will display the room list and capacity for debugging
    }
}