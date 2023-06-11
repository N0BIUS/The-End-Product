using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapmove : MonoBehaviour
{
    public float speed;



    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y);
    }
}
