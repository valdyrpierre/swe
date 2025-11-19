using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSupport
{
    
    public class Room
    {
        public string name;
        public int capacity;
                public int keyField;

        public Room() { }
    }

    public class DataBaseFormSupport
    {
        List<Room> roomList_MOCK = new List<Room>();

        public DataBaseFormSupport() { }

        private void makeListForMocks_MOCK()
        {
            //instantiate five room objects=0;n<5;n++)
            string[] names = { "one", "two", "three", "four", "five" };
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
                    roomList_MOCK.Add(r);
                }
            }
        }

        /*
        public void PopulateDataBase_MOCK(List<Room> r_MOCK)
        {
            rts.PopulateDataBase(r_MOCK);
        }

        
        public void PopulateDataBase(List<Room> r)
        {
            rts.PopulateDataBase(r);
        }


        public List<Room> RetrieveDataBaseFormSupport_MOCK()
        {
            return roomList;
        }
*/
        public List<Room> retrieveRoomInformation_MOCK()
        {
            return roomList_MOCK;
        }

        /* 
         public List<Room> retrieveRoomInformation()
        {
            return rts.retrieveRoomInformation();
        }
        */

    }
}

