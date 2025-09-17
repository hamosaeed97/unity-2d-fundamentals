using UnityEngine;

public class ReverseDirection : MonoBehaviour
{
    [SerializeField] private float speed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyMovement enemyMovement = collision.gameObject.GetComponentInParent<EnemyMovement>();

        if (enemyMovement != null)
        {
            enemyMovement.ReverseDirection();
            enemyMovement.AddSpeed(speed);
        }
    }
}
