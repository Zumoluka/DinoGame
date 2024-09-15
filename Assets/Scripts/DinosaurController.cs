using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DinosaurController : MonoBehaviour
{
    public float jumpForce = 10f;
    private bool isGrounded = true;
    private Rigidbody2D rb;
    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica si el objeto con el que colisiona tiene el tag "Kill"
        if (collision.gameObject.CompareTag("Kill"))
        {
            // Reinicia la escena actual
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
