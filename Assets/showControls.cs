using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class showControls : MonoBehaviour
{

    private GameObject gui;

    // Start is called before the first frame update
    void Start()
    {
        gui = GameObject.Find("Controls");       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showGUIControls() {
        gui.GetComponent<RectTransform> ().localScale = new Vector3 (1, 1, 1);
    }
}
