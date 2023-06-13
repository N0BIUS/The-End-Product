using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapmove : MonoBehaviour
{
    public static float speed;

    private void Start()
    {
        speed = 5;
    }


    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y);
    }
}
