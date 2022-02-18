using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showGuide : MonoBehaviour
{

    private GameObject gui;

    // Start is called before the first frame update
    void Start()
    {
        gui = GameObject.Find("Guide");       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showGUIControls() {
        gui.GetComponent<RectTransform> ().localScale = new Vector3 (1, 1, 1);
    }
}
