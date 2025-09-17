using UnityEngine;

public class EnemyHealth : Health
{
    [SerializeField] private int score;

    protected override void Start() => base.Start();

    public override void Damage(int damage)
    {
        base.Damage(damage);
        gameObject.transform.GetChild(1).GetComponent<BoxCollider2D>().enabled = false;
        GetComponentInChildren<Animator>().enabled = false;
        spriteRenderer.sprite = damageSprite;
        GetComponent<EnemyMovement>().enabled = false;
    }

    public void DamageWithScoring(int damage)
    {
        Damage(damage);
        EventsManager.SendScoreEnemyDeadEvent(score);
    }

    public override void Die() => Destroy(gameObject, 1);
}
