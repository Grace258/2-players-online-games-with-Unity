using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float fireSpeed;

    private Rigidbody2D theRB;

    public GameObject fireEffect;


    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(fireSpeed * transform.localScale.x, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player1")
        {
            FindObjectOfType<GameManager>().HurtP1();
        }
        if (other.tag == "Player2")
        {
            FindObjectOfType<GameManager>().HurtP2();
        }
        Instantiate(fireEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
