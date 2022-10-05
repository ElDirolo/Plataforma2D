using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5;
    public float jumpForce = 5;

    private Rigidbody2D rigided;
    private Animator anim;

    private float horizontal;

    public PlayableDirector director;
    //private Transform playertrasnform;
    

    void Start()
    {
        //playertrasnform = GetComponent<Transform>();
        rigided = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        //if(GroundChek.isGrounded){}
    }


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if(horizontal == 0)
        {
            anim.SetBool("Correr", false);
        }
        if(horizontal == 1)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
            anim.SetBool("Correr", true);
        }
        if(horizontal == -1)
        {
            transform.rotation = Quaternion.Euler(0,180,0);
            anim.SetBool("Correr", true);
        }

        if(Input.GetButtonDown("Jump"))
        {
            Debug.Log("Goomba muerto");
        }
        //playertrasnform.position += new Vector3 (horizontal * speed * Time.deltaTime, 0, 0);
        //playertrasnform.position += new Vector3 (1, 0, 0) * horizontal * speed * Time.deltaTime;
        //playertrasnform.Translate(Vector3.right * horizontal * speed * Time.deltaTime, Space.World);
    }

    void FixedUpdate()
    {
        rigided.velocity = new Vector2(horizontal * speed, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Cinematica")
        {
            director.Play();
        }
        
    }
}
