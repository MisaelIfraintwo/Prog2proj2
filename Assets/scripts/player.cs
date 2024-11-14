using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class player : MonoBehaviour
{
    public float jumpForce = 7f;
    private Rigidbody2D rb;
    public bool CanJump;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        CanJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && CanJump)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            CanJump = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ground")) { CanJump = true; }

    }
}
   
