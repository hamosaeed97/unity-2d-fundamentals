using UnityEngine;

public class GravityZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyHealth enemyHealth = collision.gameObject.GetComponentInParent<EnemyHealth>();

        if (enemyHealth != null)
        {
            /*Gravity is activated at 1. Remember that this was for the enemies to fall.*/
            enemyHealth.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }
}
