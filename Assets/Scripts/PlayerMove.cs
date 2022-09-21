using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5;
    private float horizontal;
    private Transform playertrasnform;
    private Rigidbody2D rigided;
    
    // Start is called before the first frame update
    void Start()
    {
        playertrasnform = GetComponent<Transform>();
        rigided = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        
        //playertrasnform.position += new Vector3 (horizontal * speed * Time.deltaTime, 0, 0);
        //playertrasnform.position += new Vector3 (1, 0, 0) * horizontal * speed * Time.deltaTime;
        //playertrasnform.Translate(Vector3.right * horizontal * speed * Time.deltaTime, Space.World);
        rigided.velocity = new Vector2(horizontal * speed, 0);
    }
}
