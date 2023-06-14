using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapmove : MonoBehaviour
{
    public static float speed;
    private float deletepos;

    private void Start()
    {
        speed = 5;
        deletepos = transform.position.x-80;
    }
    private void Update()
    {
        if (transform.position.x <= deletepos) 
        {
            Destroy(transform.gameObject);
        }
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y);
    }
    
}
