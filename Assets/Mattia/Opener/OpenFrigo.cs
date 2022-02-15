using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFrigo : MonoBehaviour
{
	
	public bool isOpen = false;
	[SerializeField] public GameObject toAnimate;
	private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
		if(toAnimate != null){
			animator = toAnimate.GetComponent<Animator>();
		}
		
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnMouseDown(){
		
		if(isOpen == false){
			if(animator != null){
				Debug.Log("open");
				animator.SetBool("Active", true);
				isOpen = true;
			}
			
		}else{
			if(animator != null){
				Debug.Log("close");
				animator.SetBool("Active", false);
				isOpen = false;
			}
		}
		
		
	}
}
