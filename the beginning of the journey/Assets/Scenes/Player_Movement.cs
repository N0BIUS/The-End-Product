using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Movement : MonoBehaviour
{
    public GameObject pr;

    Vector3 vel;
    
    public bool inair;
    public bool lw, rw;
    public bool j,r,l;
    public bool d=true;
    Rigidbody2D pr1;

    private void Start()
    {
        vel = new Vector3(0, pr1.velocity.y,0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "floor")
        {
           
            inair= false;
        }

        if (collision.gameObject.tag == "death")
        {
            lose();
        }
    }
    void lose() 
    {
        SceneManager.LoadScene("Runner");
    }
    private void Update()
    {
        if (pr.transform.position.x >= 7) { rw = true; } else { rw = false; }
        
        if(pr.transform.position.x <= -7) { lw = true; } else { lw = false; }
        pr1 = pr.GetComponent<Rigidbody2D>();

        if (pr.transform.position.y <= -2) { lose(); }


        if (inair==false&&Input.GetKeyDown("space")) 
        {
            j = true;
        }
        if (!rw&&Input.GetKey("d"))
        {
            r = true;
        }
        else { r = false; }
        if (!lw&&Input.GetKey("a"))
        {
            l = true;
        }
        else { l = false; }

        if (d!=true&&inair == false && Input.GetKeyDown("s"))
        {
            d = true;
            StartCoroutine(Slide());
            
          
        }
        
        
        pr.GetComponent<Animator>().SetBool("jump", inair);
    }
    private IEnumerator Slide() 
    {
        pr.GetComponent<Animator>().SetBool("slide", d);
        pr.GetComponent<CapsuleCollider2D>().size = new Vector2(0.002f, 0.19f);
        pr.GetComponent<CapsuleCollider2D>().offset = new Vector2(0f, -0.09f);
        d = false;
        yield return new WaitForSeconds(0.90f);
     
        pr.GetComponent<Animator>().SetBool("slide", d);
        pr.GetComponent<CapsuleCollider2D>().size = new Vector2(0.2f, 0.37f);
        pr.GetComponent<CapsuleCollider2D>().offset = new Vector2(0f, 0f);
      
    }
    void FixedUpdate()
    {

       
        
        if (j)
        {
            pr1.AddForce(transform.up * 8, ForceMode2D.Impulse);
            j = false;
            inair = true;
        }


        if (r&&!l)
        {
            vel = new Vector3(3, pr1.velocity.y);
        }
        else if (l&&!r)
        {
            vel = new Vector3(-3, pr1.velocity.y);
        }
        else 
        {
            vel = new Vector3(0, pr1.velocity.y,0);
        }
        

        pr1.velocity = vel;

    }
}