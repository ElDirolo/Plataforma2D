using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public static bool isGrounded;
    
    void OnTriggerStay2D(Collider2D col)
    {
        isGrounded = true;
        
    }

    void OnTriggerExit2D(Collider2D col)
    {
       isGrounded = false;
    }
}
