using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFail : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject light = GameObject.Find("PlayerLight");
        if(light.transform.position.y - transform.position.y < 1 || light.transform.position.x - transform.position.x < 1) {
            light.SetActive(false);
        }
        
    }
}
