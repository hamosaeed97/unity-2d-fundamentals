using System.Collections;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private Sprite activatedSprite;
    [SerializeField] private Transform teleportPosition;

    private SpriteRenderer spriteRenderer;
    private Sprite originalSprite;

    private void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        originalSprite = spriteRenderer.sprite;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();

        if (player != null)
            StartCoroutine("ChangeAndTeleport", player);
    }

    IEnumerator ChangeAndTeleport(Player player)
    {
        spriteRenderer.sprite = activatedSprite;
        yield return new WaitForSeconds(1);
        player.gameObject.transform.position = teleportPosition.position;
        yield return new WaitForSeconds(2);
        spriteRenderer.sprite = originalSprite;
    }
}