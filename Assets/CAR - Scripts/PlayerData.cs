using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int footprintValue;
    public int footprintPoints;

    // Start is called before the first frame update
    void Start()
    {
        footprintValue = 0;
        footprintPoints = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseFootprint(int value) {
        footprintValue+=value;    
    }

    public void increasePoints(int value) {
        footprintPoints+=value;    
    }
}