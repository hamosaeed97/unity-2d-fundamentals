using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EnemyWeakness : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponentInParent<PlayerHealth>() != null)
            GetComponentInParent<EnemyHealth>().DamageWithScoring(1);
    }
}