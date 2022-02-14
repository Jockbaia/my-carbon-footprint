using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnToMainScreen : MonoBehaviour
{

    private GameObject gui;
    private int isFinished;
    
    // Start is called before the first frame update
    void Start()
    {
        isFinished = 0;
        gui = GameObject.Find("EndingScreen"); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && isFinished == 1) {


            SceneManager.LoadScene("intro");
            Screen.lockCursor = false;

        }    
    }

    public void setEndFlag() {
        isFinished = 1;
    }
}

