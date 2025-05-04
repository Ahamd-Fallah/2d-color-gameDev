using UnityEngine;
using UnityEngine.SceneManagement;

public class AroController : MonoBehaviour
{
    public static GameObject Instance;
    public SpriteRenderer sprite;
    public Animator animator;
    public static float moveSpeed = 3f;
    public static float jumpForce = 7f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        CheckJump();
    }

    void Move()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        if (moveInput > 0) {
            sprite.flipX = false;
            rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
            animator.SetBool("isWalking",true);
        }
        else if (moveInput < 0) {
            sprite.flipX = true;
            rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
            animator.SetBool("isWalking",true);
        }
        else {
            animator.SetBool("isWalking",false);
        }
    }

    void CheckJump()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 1.1f, groundLayer);
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            animator.SetBool("isJumping",true);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
        else {
            animator.SetBool("isJumping",false);
        }
    }
    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.CompareTag("exit")) {
            SceneManager.LoadScene("Win");
        }
    }
}
