using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    public GameObject[] prefabs;
    public Vector3 pos;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pos = new Vector3(57f, 6f, 0f);
           
            Instantiate(prefabs[Random.Range(0, prefabs.Length )], new Vector3(transform.position.x+30, 6, 0), Quaternion.identity);
            Object.Destroy(transform.gameObject);
        }
    }
}
