using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piedinoBehaviour : MonoBehaviour
{

    private Animator anim;
    private GameObject player;
    public int isShown;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        player = GameObject.Find("Giocatore");
        isShown = 0;    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && isShown == 1) {
            isShown = 0;   
            anim.SetBool("showPiedino", false);
            player.GetComponent<actionSchedule>().nextEvent();
        }

    }

    public void showPiedino() {
        isShown = 1;    
        anim.SetBool("showPiedino", true);
    }

    public void hidePiedino() {
        isShown = 0;   
        anim.SetBool("showPiedino", false); 
    }
}
