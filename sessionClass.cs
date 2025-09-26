using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// consolidates information about the session

public class Session_Class
{

    // Attributes
    private string sessionName;
    private int sessionCapacity;
    private string speakerName;
    private string topicName;
    private string roomLocation;
    private DateTime startTime;
    private DateTime endTime;
    private DateTime sessionDuration;

    //sets and gets
    public void setSessionName(string name)
    {
        // user will enter the session name
        // use string to allow session name to be entered
    }


    public string getSessionName()
    {
        // this will return the session name


    }

    public void setCapacity(int capacity)
    {
        // user will enter the session capacity
        // int used to make sure that only a num is used
        // capacity can't be negative
        // i will have this continue to loop until they put in a valid num
    }


    public int getCapacity()
    {
        // this will return the session capacity


    }
    public void setSpeakerName(string name)
    {
        // user will enter the session capacity
        // string used to ensure a proper name is entered
    }


    public string getSpeakerName()
    {
        // this will return the speakers name


    }

    public void setTopicName(string TopicName)
    {
        // user will enter the topic
        // string used to make sure only letters are used to enter topic
        // method will continue to loop until a valid name of a topic is entered
    }


    public string getTopicName()
    {
        // this will return the name of the Topic being presented

    }

    public void setRoomLocation(string room)
    {
        // user will enter the room location
        // use string to make sure that only a location is used
        // continue to loop until a valid location is entered
    }


    public string getRoomLocation()
    {
        // this will return the room location


    }

    public void setStartTime(DateTime start)
    {
        // user will enter the session start time
        // use DateTime to make sure the session start time is entered
        // continue loop until a valid session DateTime is entered
    }


    public DateTime getStartTime()
    {
        // this will return the time the session starts


    }

    public void setEndTime(DateTime end)
    {
        // user will enter the session end time
        // use DateTime to make sure that only a time is entered
        // ensure EndTime is not before start
        // continue loop until a valid time is entered
        // if end is before start, clear end to avoid error
    }


    public DateTime getEndTime()
    {
        // this will return the session end time


    }

    public void setTimeSlot(DateTime TimeSlot)
    {
        // user will enter the scheduled session time slot
        // use DateTime to make sure that only a valid DateTime is entered
        // continue loop until a valid DateTime is entered
    }


    public DateTime getTimeSlot()
    {
        // this will return the scheduled session time slot


    }

    public TimeSpan GetSessionDuration()
    {
        // Duration should be a TimeSpan derived from End - Start.
        // 00:00:00 if equal or not set yet
        // this will display the duration of the session    
    }
}
