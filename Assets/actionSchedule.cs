using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actionSchedule : MonoBehaviour
{
    private const int NUM_EVENTS = 9;
    private GameObject endingscreen;
    private string[] events = new string[NUM_EVENTS];
    public int counter = 0;
    public bool isCurrentScheduled;
    private GameObject finalhint;

    
    // Start is called before the first frame update
    
    void Start()
    {
        endingscreen = GameObject.Find("EndingScreen");
        finalhint = GameObject.Find("TipsText2");
        

        events[0] = "BOTTLE"; // OK
        events[1] = "TRAVEL"; // OK
        events[2] = "COFFEE"; // OK
        events[3] = "BREAKFAST"; // OK
        events[4] = "BISCUITS"; // OK
        events[5] = "WASHER"; // OK
        events[6] = "SHOWER"; // OK
        events[7] = "CAR"; // OK 
        events[8] = "CLOSE";

        // Unscheduled
        //
        // "TEMPERATURE" OK
        // "LIGHTS" OK
        // "ROOMBA" OK

        counter = 0;
    }

    public string getID() {
        return events[counter];
    }

    public int getCurrent() {
        return counter;
    }

    public void nextEvent() {
        if(isCurrentScheduled) {
            counter++;
        }

        if(counter==8) {
            finalhint.GetComponent<showTipContext> ().setFinalHint();
            endingscreen.GetComponent<RectTransform> ().localScale = new Vector3 (1, 1, 1);

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
