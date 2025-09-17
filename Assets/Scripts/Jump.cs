using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private float jumpAmount;
    [SerializeField] private bool isJumping;

    private Rigidbody2D rb;
    private Animator animator;

    private void Start()
    {
        //The component of the parent GO (player) is obtained.
        rb = GetComponentInParent<Rigidbody2D>();

        //The component of the children GO (player) is obtained.
        animator = gameObject.transform.parent.GetComponentInChildren<Animator>();

        isJumping = false;
    }

    void Update()
    {
        if (!isJumping)
            PlayerJump();
    }

    private void PlayerJump()
    {
        //Keyboard input (GetKey)
        if (Input.GetKey(KeyCode.Space))
        {
            //An instantaneous force (impulse) is applied to the vector up (0,1) * jumpAmount value.
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            isJumping = true;
            animator.SetBool("change", true);
        } else 
        {
            animator.SetBool("change", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag == "Ground")
            isJumping = false;
    } 
}
