using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    bool is_increasing = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        is_increasing = (is_increasing && transform.localScale.x < 15) || (!is_increasing && transform.localScale.x < 1);
        if(is_increasing)
            transform.localScale = new Vector3(transform.localScale.x + 1*Time.deltaTime, transform.localScale.y + 1*Time.deltaTime, transform.localScale.z + 1*Time.deltaTime);
        else
            transform.localScale = new Vector3(transform.localScale.x - 1*Time.deltaTime, transform.localScale.y - 1*Time.deltaTime, transform.localScale.z - 1*Time.deltaTime);   
             }
}
