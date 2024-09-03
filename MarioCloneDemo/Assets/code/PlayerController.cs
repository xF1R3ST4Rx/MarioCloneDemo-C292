using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float runSpeed;
    [SerializeField] private float jumpSpeed;
    [SerializeField] private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        float moveInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * moveInput * runSpeed * Time.deltaTime);
        //rb2d.AddForce(Vector2.right * moveInput * runSpeed * Time.deltaTime, ForceMode2D.Impulse );
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb2d.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
        }
    }
}
