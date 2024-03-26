using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPC : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    float speed = 10f;

    [SerializeField]
    float jumpSpeed = 10f;

    bool onGround = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horInput * speed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
            onGround = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
            Destroy(collision.gameObject);
    }

}
