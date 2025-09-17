using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] protected int maxHealth;
    [SerializeField] protected int currentHealth;
    [SerializeField] protected Sprite damageSprite;
    protected SpriteRenderer spriteRenderer;

    protected virtual void Start() 
    {
        currentHealth = maxHealth;
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    public virtual void Damage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
            Die();
    }

    public virtual void Die() => EventsManager.FinishedLevelEvent(false);
}
