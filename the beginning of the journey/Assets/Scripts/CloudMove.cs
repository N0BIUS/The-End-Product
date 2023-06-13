using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public float speed;
    private float end;
    private float start;
    private void Start()
    {
        end = transform.position.x - 18.90f;
        start = transform.position.x;
    }
    void Update()
    {
        transform.position = new Vector3 (transform.position.x-speed*Time.deltaTime, transform.position.y, transform.position.z);
        if (transform.position.x <= end) 
        {
            transform.position = new Vector3(start, transform.position.y, transform.position.z);
        }
    }
}
