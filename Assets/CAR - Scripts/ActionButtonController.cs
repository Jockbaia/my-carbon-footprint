using UnityEngine;
using UnityEngine.UI;


public class ActionButtonController : MonoBehaviour
{

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
    public GameObject CrossHair;

    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(selected)
        {
            itemText.text = itemName;
            

            if(ending) {
               CrossHair.SetActive(true);
               ActionWheel.SetActive(false); 
            }

        }
    }

    public void Selected() 
    {
        audioSource.PlayOneShot(clickSFX);
        selected = true;
        Debug.Log("Selected");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;     
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
