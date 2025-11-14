using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportForSpeakerForm
{
    public class Speaker
    {
        public String firstName;
        //getters and setters
        public String lastName;
        //getters and setters
        public String phoneNumber;
        //getters and setters
        public String dayOfPhone;
        //getters and setters
        public String emailAddress;
        //getters and setters
        public int keyField;
        //getters and setters
    }

    public class SpeakerFormSupport
    {
        public SpeakerFormSupport()
        {
            // default constructor
        }
        /*
                public void PopulateDataBase(List<Speaker> s)
                {
                    rts.PopulateDataBase(s);
                }
        */
        public List<Speaker> retrieveSpeakerInformation_MOCK()
        {
            List<Speaker> speakerList = new List<Speaker>();

            //instantiate five speaker objects=0;n<5;n++)
            String[] firstName = { };
            String[] lastName = { };
            String[] phoneNumber = { };
            String[] dayOfPhone = { };
            String[] emailAddress = { };
            int[] keyFields = { 11111, 22222, 33333, 44444, 55555 };

            string fullName = firstName + " " + lastName;

            for (int n = 0; n < fullName.Length; n++)
            {
                Speaker S = new Speaker();
                {
                    S.firstName = firstName[n];
                    S.lastName = lastName[n];
                    S.phoneNumber = phoneNumber[n];
                    S.dayOfPhone = dayOfPhone[n];
                    S.emailAddress = emailAddress[n];
                    S.keyField = keyFields[n];

                    //add each to a list
                    speakerList.Add(S);
                }
            }
            return speakerList;
        }
        /*
                public List<Speaker> retrieveSpeakerInformation()
                {
                    return rts.retrieveSpeakerInformation();
                }

                public List<Speaker> provideSpeakerListForDataBase()
                {
                    // call ProvideSpeakerForDataBase from speakerFormSupport
                    // send list of Speaker objects

                    // josh has to provide us this list
                    return rts.ProvideSpeakerForDataBase();
                }
        */
    }
}