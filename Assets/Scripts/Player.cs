using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    [SerializeField]
    float horizontalInput;
    float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.y < -26)
        {
            transform.position = new Vector3(0, transform.position.y*-1, 0);
        }
        // horizontalInput = Input.GetAxis("Horizontal");
        // verticalInput = Input.GetAxis("Vertical");
        
        // transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.down * Time.deltaTime * speed);


        // transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * speed);

        // transform.Rotate(Vector3.forward * Time.deltaTime * rotate_speed);
    }
}
