using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setCO2 : MonoBehaviour
{
    
    private GameObject player;
    public Text itemText;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Giocatore");
        itemText.text = "AA";
    }

    // Update is called once per frame
    void Update()
    {
        string myData = player.GetComponent<PlayerData>().getCO2().ToString(); 
        itemText.text = myData + " kg";
    }
}
