using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;
    public KeyCode throwBall;

    private Rigidbody2D theRB2;

    public Transform groundCheckPoint;

    public bool isGrounded;

    public float groundCheckRadius;

    public LayerMask whatIsGround;

    public Transform throwPoint;

    public GameObject fire;
    public AudioSource throwSound;

    // Start is called before the first frame update
    void Start()
    {
        theRB2 = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, whatIsGround);

        if (Input.GetKey(left))
        {
            theRB2.velocity = new Vector2(-moveSpeed, theRB2.velocity.y);
        }
        else if (Input.GetKey(right))
        {
            theRB2.velocity = new Vector2(moveSpeed, theRB2.velocity.y);
        }
        else
        {
            theRB2.velocity = new Vector2(0, theRB2.velocity.y);
        }

        if (Input.GetKeyDown(jump) && isGrounded)
        {
            theRB2.velocity = new Vector2(theRB2.velocity.x, jumpForce);
        }

        if (Input.GetKeyDown(throwBall))
        {          
            Instantiate(fire, throwPoint.position, throwPoint.rotation);

            throwSound.Play();
        }


    }
}
