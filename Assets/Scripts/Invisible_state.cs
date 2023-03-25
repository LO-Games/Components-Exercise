using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible_state : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool invisble = GetComponent<Renderer>().enabled;
        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<Renderer>().enabled = !invisble;
        }
        
    }
}
