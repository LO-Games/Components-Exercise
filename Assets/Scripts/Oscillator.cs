using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Oscillator : MonoBehaviour
{
    public float amplitude = 1f;
    public float frequency = 1f;
    public float rotationAngle = 45f;

    private Vector3 startPosition;
    private float rotationTime = 0f;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        Vector3 pos = transform.position;
        float sinValue = Mathf.Sin(Time.time * frequency + 45) * amplitude;
        transform.position = startPosition + Vector3.right * sinValue;

        rotationTime += Time.deltaTime * frequency;
        transform.rotation = Quaternion.Euler(0f, 0f, Mathf.Sin(rotationTime) * rotationAngle);
        // Debug.Log("Cube Movement: " + (pos - transform.position));
        
    }


    
}
