using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundFeedback : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip mmhSFX;
    public AudioClip successSFX;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
        audioSource.PlayOneShot(mmhSFX);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playHumming() {

        audioSource.PlayOneShot(mmhSFX);

    }

    public void playSuccess() {

        audioSource.PlayOneShot(successSFX);
    }
}
