using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBottle : MonoBehaviour
{

    private GameObject bottle;

    // Start is called before the first frame update
    void Start()
    {
        bottle = GameObject.Find("acqua");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void trashBottle() {
        bottle.transform.position = new Vector3(10000, 0, 0);
    }
}
