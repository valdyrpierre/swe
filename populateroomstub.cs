using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using room;


// this will get the information about the room
// consolidates information about the session


public class PopulateRoom_Class
{
    public List<string> _roomName;
    public List<int> _roomCapacity;

    //constructor
    public PopulateRoom_Class(string roomName, int roomCapacity)
    {
        // this will initialize the room name and capacity
        _roomName = new List<string>();
        _roomCapacity = new List<int>();
    }

    public void PopulateroomName(string roomName)
    {
        // this will obtain all room name from database
        // poplulate room name in a list 
        //add " add room name to list"
    }

    public void PopulateroomCapacity(int roomCapacity)
    {
        // this will obtain all room capacity from database
        // poplulate room capacity in a list
          
    }
    

}