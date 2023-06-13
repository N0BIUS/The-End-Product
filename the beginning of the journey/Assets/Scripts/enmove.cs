using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmove : MonoBehaviour
{
    Quaternion round;
    public float speed;
    void FixedUpdate()
    {
        round.eulerAngles = new Vector3(transform.rotation.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z + speed * Time.deltaTime);
        transform.rotation = round;
    }
}
