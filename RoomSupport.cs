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
        // chrus creates the room table 
        private RoomTableSupport roomTableSupport = new RoomTableSupport();

        public RoomSupport()
        {
            // default constructor
        }

        public List<Room> provideRoomListForForm()
        {
            //call ProvideRoomForForm from roomtablesupport
            // recieve list of room objects

            return roomTableSupport.ProvideRoomForForm();
        }
       
        public void provideRoomListForDataBase(List<Room>)
        {
            // call ProvideRoomForDataBase from roomtablesupport
            // send list of room objects     
            // josh has to provide us this list}
    }
}
