using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private bool enemy;
    [SerializeField] private int damage;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealth playerHealth = collision.gameObject.GetComponentInParent<PlayerHealth>();

        if (playerHealth != null)
        {
            playerHealth.Damage(damage);

            if (enemy)
                GetComponentInParent<EnemyHealth>().Damage(1);
        }
    }
}
