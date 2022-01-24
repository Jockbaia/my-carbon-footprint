using UnityEngine;
using UnityEngine.UI;


public class ActionButtonController : MonoBehaviour
{

    private GameObject crosshair;
    private Animator anim;
    public string itemName;
    public Text itemText;
    private bool selected = false;
    public Sprite icon;
    public GameObject ActionWheel;
    
    AudioSource audioSource;
    public AudioClip hoverSFX;
    public AudioClip clickSFX;
    public bool ending = false;
    

    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>(); 
        crosshair = GameObject.Find("Crosshair");
    }

    // Update is called once per frame
    void Update()
    {
        if(selected)
        {
            itemText.text = itemName;
            

            if(ending) {
               
               ActionWheel.SetActive(false); 
               crosshair.GetComponent<RectTransform> ().localScale = new Vector3 (1, 1, 1);
               Cursor.lockState = CursorLockMode.Locked;
               Cursor.visible = false; 
            }

        }
    }

    public void Selected() 
    {
        audioSource.PlayOneShot(clickSFX);
        selected = true;
        Debug.Log("Selected");
            
        ending = true;   
    }

    public void Deselected() 
    {
        selected = false;
        Debug.Log("Deselected");
    }

    public void HoverEnter()
    {
        Debug.Log("HoverEnter");
        anim.SetBool("hover", true);
        itemText.text = itemName;
        audioSource.PlayOneShot(hoverSFX);
    }

    public void HoverExit()
    {
        Debug.Log("HoverExit");
        anim.SetBool("hover", false);
        itemText.text = "";
    }
}
