using System;
using System.Collections.Generic;
using System.Text;


namespace softwareengineer
{
    public class RoomFormSupport
    {
        public RoomFormSupport()
        {
            // default constructor
        }

        public void PopulateDataBase(List<Room> r)
        {
            rts.PopulateDataBase(r);
        }

        public List<Room> retrieveRoomInformation()
        {
            return rts.retrieveRoomInformation();
        }
        public List<Room> provideRoomListForDataBase()
        {
            // call ProvideRoomForDataBase from roomtablesupport
            // send list of room objects

            // josh has to provide us this list
            return rts.ProvideRoomForDataBase();
        }
    }
}
