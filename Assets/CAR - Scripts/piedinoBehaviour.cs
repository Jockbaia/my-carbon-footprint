using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piedinoBehaviour : MonoBehaviour
{

    private Animator anim;
    private GameObject player;
    public int isShown;
    private GameObject piedinoBTN;
    private GameObject hintBTN;
    private GameObject soundFeedback;

    // Start is called before the first frame update

    void Start()
    {
        anim = GetComponent<Animator>();
        player = GameObject.Find("Giocatore");
        isShown = 0; 
        piedinoBTN = GameObject.Find("PiedinoButton");   
        hintBTN = GameObject.Find("PlayerHints");   
        soundFeedback = GameObject.Find("Sound FX");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && isShown == 1) {
            isShown = 0;   
            anim.SetBool("showPiedino", false);
            piedinoBTN.GetComponent<RectTransform> ().localScale = new Vector3 ((float) 0, 0, 1);
            player.GetComponent<actionSchedule>().nextEvent();
            hintBTN.GetComponent<RectTransform> ().localScale = new Vector3 (1, 1, 1);
            soundFeedback.GetComponent<soundFeedback>().playHumming();
        }

    }

    public void showPiedino() {
        isShown = 1;    
        anim.SetBool("showPiedino", true);
        piedinoBTN.GetComponent<RectTransform> ().localScale = new Vector3 ((float) 0, 0, 1);
        

    }

    public void hidePiedino() {
        isShown = 0;   
        anim.SetBool("showPiedino", false); 
        piedinoBTN.GetComponent<RectTransform> ().localScale = new Vector3 ((float) 0.5, (float) 0.5, 1);
        
    }
}
