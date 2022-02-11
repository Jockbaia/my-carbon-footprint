using UnityEngine;
using UnityEngine.UI;


public class HintText : MonoBehaviour
{
    public Text itemText;
    

    // Start is called before the first frame update
    void Start()
    {
        itemText.text = "Che dormita! Bello al calduccio col mio termosifone. Forse troppo caldo: ho finito l’acqua nella bottiglia. Fammi controllare se ne è rimasta un po’...";
    }

    // Update is called once per frame
    void Update()
    {
        
            
    }

    public void setHint(string currentHint) {
        itemText.text = currentHint;
    }

}
