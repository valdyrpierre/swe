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

    public class RoomFormSupport
    {
        List<Room> roomList_MOCK = new List<Room>();
        DataBaseRoomSupport dbrs; //= new DataBaseRoomSupport();

        public RoomFormSupport() { }

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

        public List<Room> retrieveRoomInformation_MOCK()//needed when form opens
        {
            return roomList_MOCK;
        }

        public void populateDataBase_MOCK(List<Room> r)//needed when form closes
        {
            return;
        }

        public List<Room> updateRoomInformation_MOCK(List<Room> r)//needed when list changes
        {
            return r;
        }





        public void populateDataBase(List<Room> r)//needed when form closes
        {
            dbrs.PopulateDataBase(r);
        }

        public List<Room> retrieveInformation()//needed when form opens
        {
            dbrs.obtainListFromDataBase();
        }

        public List<Room> updateRoomInformation(List<Room> r)//needed when list changes
        {
            return dbrs.updateRoomDataBase(r);
        }


    }
}

