using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportForRoomForm
{
    public class Room
    {
        public String name;
        public int capacity;
        public int keyField;
    }

    public class RoomFormSupport
    {
        public RoomFormSupport()
        {
            // default constructor
        }
/*
        public void PopulateDataBase(List<Room> r)
        {
            rts.PopulateDataBase(r);
        }
*/
        public List<Room> retrieveRoomInformation_MOCK()
        {
            List<Room> roomList = new List<Room>();

            //instantiate five room objects=0;n<5;n++)
            String[] names = { "one", "two", "three", "four", "five" };
            int[] capacities = { 10, 20, 30, 40, 50 };
            int[] keyFields = { 11111, 22222, 33333, 44444, 55555 };

            for (int n = 0; n < names.Length; n++)
            {
                Room r = new Room();
                {
                    r.name = names[n];
                    r.capacity = capacities[n];
                    r.keyField = keyFields[n];

                    //add each to a list
                    roomList.Add(r);
                }
            }
            return roomList;
        }
/*
        public List<Room> retrieveRoomInformation()
        {
            return rts.retrieveRoomInformation();
        }

        public List<Room> provideRoomListForDataBase()
        {
            // call ProvideRoomForDataBase from roomformsupport
            // send list of room objects

            // josh has to provide us this list
            return rts.ProvideRoomForDataBase();
        }
*/
    }
}