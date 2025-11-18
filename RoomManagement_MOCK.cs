using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomFormSupport_MOCK
{
    public class RoomManagement_MOCK
    {
        public string name;
        public int capacity;
        public string room;
        public int keyField;
    }

    public class RoomManagement
    {
        public RoomManagement()
        {
            // default constructor
        }

        /*
        public void PopulateDataBase(List<Room> r)
        {
            rts.PopulateDataBase(r);
        }
*/

        public List<Room> RetrieveRoomDatabase_MOCK()
        {
            List<Room> roomList = new List<Room>();

            //instantiate five room objects=0;n<5;n++)
            string[] names = { "one", "two", "three", "four", "five" };
            int[] capacities = { 10, 20, 30, 40, 50 };
            int[] keyFields = { 11111, 22222, 33333, 44444, 55555 };
            string[] rooms = { "A101", "B202", "C303", "D404", "E505" };

            for (int n = 0; n < names.Length; n++)
            {
                Room r = new Room();
                {
                    r.name = names[n];
                    r.capacity = capacities[n];
                    r.keyField = keyFields[n];
                    r.room = rooms[n];

                    //add each to a list
                    roomList.Add(r);
                }
            }
            return roomList;
        }

        /* public List<Room> retrieveRoomInformation()
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

