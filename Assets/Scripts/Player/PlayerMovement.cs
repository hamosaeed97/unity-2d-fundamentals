using UnityEngine;

/*The Required is used when we want a component to include another component. In this case, 
 * the movement needs (if used) the RidigBody component to be able to move the player.*/
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] protected float speed;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.transform.GetChild(1).GetComponent<SpriteRenderer>();
    }

    void LateUpdate() => Movement();

    private void Movement()
    {
        //Remember that Horizontal is for the X-axis and Vertical is for the Y-axis.
        float x = Input.GetAxis("Horizontal");
        //float y = Input.GetAxis("Vertical");

        //it if is true, right direction, left direction
        if (x > 0)
            spriteRenderer.flipX = true;
        else if (x < 0)
            spriteRenderer.flipX = false;

        //Example using the RigidBody component and another option such as the Transform component
        rb.position += speed * Time.deltaTime * new Vector2(x, 0);
    }
}
