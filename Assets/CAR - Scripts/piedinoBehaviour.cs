using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piedinoBehaviour : MonoBehaviour
{

    private Animator anim;
    public int isShown;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        isShown = 0;    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && isShown == 1) {
            isShown = 0;   
            anim.SetBool("showPiedino", false);
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
