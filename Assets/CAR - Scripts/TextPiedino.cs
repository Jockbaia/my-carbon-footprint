using UnityEngine;
using UnityEngine.UI;


public class TextPiedino : MonoBehaviour
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

    public void setFeedback(string currentFeedback) {
        itemText.text = currentFeedback;
    }

}
