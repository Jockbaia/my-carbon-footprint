using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeLight : MonoBehaviour
{

    public GameObject light;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void lightSwitch() {
        light.GetComponent<Transform> ().position = new Vector3((float) 30000, (float) 0, (float) 0);
    }
}
