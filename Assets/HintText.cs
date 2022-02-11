using UnityEngine;
using UnityEngine.UI;


public class HintText : MonoBehaviour
{
    public Text itemText;
    

    // Start is called before the first frame update
    void Start()
    {
        itemText.text = "START";
    }

    // Update is called once per frame
    void Update()
    {
        
            
    }

    public void setHint(string currentHint) {
        itemText.text = currentHint;
    }

}
