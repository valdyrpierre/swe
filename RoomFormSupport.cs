using CapstoneTableSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone

{
    public class RoomFormSupport

    {
        CapstoneTableSide.RoomTableSupport rts = new CapstoneTableSide.RoomTableSupport();
        public RoomFormSupport() { }


            public void populateDataBase(List<Roomt> r)

        {
            rts.populateDataBase(r);
        }

        public List<Roomt> populateRoomForm()
        {
            return rts.retrieveRooms();
        }

    }
}
