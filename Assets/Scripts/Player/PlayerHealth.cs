using System.Collections;
using UnityEngine;

public class PlayerHealth : Health
{
    [SerializeField] private Sprite originalSprite;
    [SerializeField] private float damageDelay;

    private Animator animator;

    protected override void Start()
    {
        base.Start();
        EventsManager.PlayerLifeUpdateEvent(currentHealth);
        animator = GetComponentInChildren<Animator>();
    }

    public override void Damage(int damage)
    {
        base.Damage(damage);
        StartCoroutine("RestartPlayerSprite");
        EventsManager.PlayerLifeUpdateEvent(currentHealth);
    }

    IEnumerator RestartPlayerSprite()
    {
        animator.enabled = false;
        spriteRenderer.sprite = damageSprite;
        yield return new WaitForSeconds(damageDelay);
        spriteRenderer.sprite = originalSprite;
        animator.enabled = true;
    }

    public void Restore(int restore)
    {
        currentHealth += restore;
        if (currentHealth > maxHealth)
            currentHealth = maxHealth;
    }

    private void OnDestroy() => Die();
}
