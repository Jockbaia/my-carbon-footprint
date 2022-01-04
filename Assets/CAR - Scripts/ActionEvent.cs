using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

[RequireComponent(typeof(AudioSource))]

public class ActionEvent : MonoBehaviour
{

    public GameObject ActionWheel;
    public GameObject CrossHair;
    AudioSource clickSFX;
    MeshRenderer mr;
 
    // Start is called before the first frame update
    void Start()
    {
        clickSFX = GetComponent<AudioSource>();
        mr = GetComponent<MeshRenderer>();
        ActionWheel.SetActive(false);
    }

    // Crossover hovering the object
    void OnMouseEnter() {
        Debug.Log("Entering");

        // Enabling glow
        mr.material.EnableKeyword("_EMISSION");

    }


    // Crossover left the object
    void OnMouseExit()
    {
        Debug.Log("Exiting");

        // Disabling glow
        mr.material.DisableKeyword("_EMISSION");   
    }


    // Left click on the object
    void OnMouseDown(){
        Debug.Log("Clicking");

        // Play chosen sound
        clickSFX.Play(0);
        // Enabling Actionwheel
        ActionWheel.SetActive(true);
        // Disabling Crosshair
        CrossHair.SetActive(false);
        // Show cursor
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
