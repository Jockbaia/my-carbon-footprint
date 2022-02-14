using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeControls : MonoBehaviour
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
        if(Input.GetMouseButtonDown(0)) {
            gui.GetComponent<RectTransform> ().localScale = new Vector3 (0, 1, 1);
        }    
    }
}
