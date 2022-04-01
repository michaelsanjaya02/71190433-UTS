using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D Rb;
    public float ms;
    void Start()
    {
        Rb = GetComponent<Rigidbody2d>();
    }

  
    void Update()
    {
        float horiz = Input.GetAxisRaw("Horizontal");
        Rb.velocity = new Vector2(ms * horiz, Rb.velocity.y); 
    }
}
