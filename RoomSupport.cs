using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrontEndSupport
{
    // this will get the information about the room
    // consolidates information about the session
    public class RoomSupport
    {
        // chris creates the room table 
        // inteciate roomtablesupport
       // private RoomTableSupport roomTableSupport = new RoomTableSupport();

        public RoomSupport()
        {
            // default constructor
            RoomCapacity = null;
            // the room name will never be null since in the data base it is not null
            RoomName = roomName();
            //this will call obtain room information method
            ObtainRoomInformation();
            // i will pass on the information i obtained to the method provide room list for form
            provideRoomListForDataBase();

        }

        public void ObtainRoomInformation()
        {
            // this will obtain the room information from the database
            roomCapacity();
            roomName();
        }
    
        public int roomCapacity()
        {
            // the room capacity can be nullable since the database won't always have a value for it
            roomCapacity = roomTableSupport.obtainRoomCapacityFromDataBase();
            if (roomCapacity == null)
            {
                roomCapacity = "0";
            }
            else
            {
                return roomCapacity;
            }

            
        }

        public string roomName()
        {
            // room name will always have a value since in the data base it is not null, so room name will equal what is in the data base
            roomName = roomTableSupport.obtainRoomNameFromDataBase();

            if (roomName == null)
            {
                roomName = addRoomName();
            }
            else
            {
                return roomName;
            }
        }
        public string addRoomName()
        {
            // this is there incase we are to add a room 
            rooomName = roomTableSupport.setRoomNameInDataBase();
            return roomName;
        }

    
        public void provideRoomListForDataBase(List<Room>)
        {
            // call ProvideRoomForDataBase from roomtablesupport
            // send list of room objects
           
            // josh has to provide us this list

        }
    } 
}
