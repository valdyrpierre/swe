using System.Collections.Generic;
using FrontEndSupport;
using Models;
using System;

namespace SoftwareEngineering
{
    public class RoomList
    {
        private List<Room> rooms;

        public RoomList()
        {
            rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        public void RemoveRoom(Room room)
        {
            rooms.Remove(room);
        }

        public List<Room> GetRooms()
        {
            return rooms;
        }
        public void DisplayRooms()
        {
            foreach ( var room in rooms)
            {
                Console.WriteLine($"Room Number: {room.RoomNumber}, Add Room {room.AddRoom}, Capacity: {room.Capacity}");
            }
        }

    }
}