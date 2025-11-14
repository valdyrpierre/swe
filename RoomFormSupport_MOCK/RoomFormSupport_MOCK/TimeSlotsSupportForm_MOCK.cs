using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportForTimeSlotsForm
{
    public class TimeSlots
    {
        public DateTime startTime;
        public DateTime endTime;
        public int keyField;
    }

    public class TimeSlotsFormSupport
    {
        public TimeSlotsFormSupport()
        {
            // default constructor
        }
        /*
                public void PopulateDataBase(List<TimeSlots> T)
                {
                    rts.PopulateDataBase(r);
                }
        */
        public List<TimeSlots> retrieveTimeSlotsInformation_MOCK()
        {
            List<TimeSlots> timeSlotsList = new List<TimeSlots>();

            //instantiate five timeSlots objects=0;n<5;n++)
            DateTime[] startTime = { };
            DateTime[] endTime = { };
            int[] keyFields = { 11111, 22222, 33333, 44444, 55555 };

            string fullTime = startTime.ToString() + " - " + endTime.ToString();

            for (int n = 0; n < fullTime.Length; n++)
            {
                TimeSlots t = new TimeSlots();
                {
                    t.startTime = startTime[n];
                    t.endTime = endTime[n];
                    t.keyField = keyFields[n];

                    //add each to a list
                    timeSlotsList.Add(t);
                }
            }
            return timeSlotsList;
        }
        /*
                public List<TimeSlots> retrieveTimeSlotsInformation()
                {
                    return rts.retrieveTimeSlotsInformation();
                }

                public List<TimeSlots> provideTimeSlotsListForDataBase()
                {
                    // call ProvideTimeSlotsForDataBase from timeSlotstablesupport
                    // send list of TimeSlots objects

                    // josh has to provide us this list
                    return rts.ProvideTimeSlotsForDataBase();
                }
        */
    }
}