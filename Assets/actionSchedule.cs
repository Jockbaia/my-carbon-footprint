using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actionSchedule : MonoBehaviour
{
    private const int NUM_EVENTS = 9;
    private string[] events = new string[NUM_EVENTS];
    public int counter = 0;
    public bool isCurrentScheduled;
    
    // Start is called before the first frame update
    void Start()
    {
        events[0] = "BREAKFAST";
        events[1] = "TRAVEL";
        //events[0] = "BOTTLE";
        //events[1] = "TRAVEL";
        events[2] = "COFFEE";
        events[3] = "BREAKFAST";
        events[4] = "BISCUITS";
        events[5] = "WASHER";
        events[6] = "SHOWER";
        events[7] = "CAR";
        events[8] = "CLOSE";

        // Unscheduled
        // "TEMPERATURE"

        counter = 0;
    }

    public string getID() {
        return events[counter];
    }

    public void nextEvent() {
        if(isCurrentScheduled) {
            counter++;
        }
    }

    public void setCurrentScheduled(bool myValue) {
        isCurrentScheduled = myValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
