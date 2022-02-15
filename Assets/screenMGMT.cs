using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenMGMT : MonoBehaviour
{

    private GameObject screen;

    void Start()
    {
        screen = GameObject.Find("SchermoPC");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startScreen() {
        
    }

    public void removeScreen() {
        screen.GetComponent<Transform> ().localScale = new Vector3((float) 0, (float) 0, (float) 0);
    }
}
