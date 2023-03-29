using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_Size : MonoBehaviour
{
    [SerializeField]
    private float scale_size = 5;
    public float scale_speed = 1;
    public float max_size = 15;
    public float min_size = 5;
    bool isIncreasing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float scale_change = Time.deltaTime * scale_size * scale_speed;
        isIncreasing = (isIncreasing && transform.localScale.x < max_size) || (!isIncreasing && transform.localScale.x < min_size);
        if(isIncreasing){
            transform.localScale = new Vector3(transform.localScale.x + scale_change, transform.localScale.y + scale_change, transform.localScale.z + scale_change);
        }
        else
        {
            transform.localScale = new Vector3(transform.localScale.x - scale_change, transform.localScale.y - scale_change, transform.localScale.z - scale_change);
        }
      
    }
}
