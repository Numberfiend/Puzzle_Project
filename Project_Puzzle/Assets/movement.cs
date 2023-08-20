using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float jumpspeed;
    private float moveinput;
    private bool faceR = true;

    private Rigidbody2D rb;

    private bool grounded;
    public Transform gcheck;
    public float checkRadius;
    public LayerMask whatisground;

    public int extrajump;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(gcheck.position, checkRadius, whatisground);

        moveinput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveinput * speed, rb.velocity.y);
        if (faceR == false && moveinput > 0)
        {
            flip();
        }
        else if(faceR == true && moveinput < 0)
        {
            flip();
        }
    }

    void Update()
    {
     if(grounded == true)
        {
            extrajump = 0;
        }
     if(Input.GetKeyDown(KeyCode.W) && extrajump > 0)
        {
            rb.velocity = Vector2.up * jumpspeed;
            extrajump--;
        }
     else if(Input.GetKeyDown(KeyCode.W) && extrajump == 0 && gcheck == true)
        {
            rb.velocity = Vector2.up * jumpspeed;
        }
    }
    void flip()
    {
        faceR = !faceR;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
