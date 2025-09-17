using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float limit;
    [SerializeField] private int unit;

    private bool reverse;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        reverse = false;
        unit = -1;
    }

    void Update()
    {
        transform.position += new Vector3(unit * Time.deltaTime * speed, 0, 0);
    }

    //Check the current direction and apply the new one 
    public void ReverseDirection()
    {
        reverse = !reverse;
        switch (reverse)
        {
            case true:
                unit = 1;
                spriteRenderer.flipX = true;
                break;
            case false:
                unit = -1;
                spriteRenderer.flipX = false;
                break;
        }
    }

    public void AddSpeed(float speed)
    {
        if ((this.speed + speed) <= limit)
        {
            this.speed += speed;
        }
    }
}
